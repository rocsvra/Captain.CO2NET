using Microsoft.Extensions.Localization;
using System;
using System.Runtime.Serialization;

namespace Captain.CO2NET.HttpException
{
    /// <summary>
    /// http异常基类
    /// </summary>
    public abstract class BaseHttpException : Exception
    { 
        private readonly IStringLocalizer _localizer;
        private readonly string[] _args;

        protected BaseHttpException(IStringLocalizer localizer, string transactionId, string code, params string[] args)
            : base(code)
        {
            _localizer = localizer;
            _args = args;
            TransactionId = transactionId;
            Code = code;
        }

        protected BaseHttpException(IStringLocalizer localizer, string transactionId, string code, Exception innerException, params string[] args)
            : base(code, innerException)
        {
            _localizer = localizer;
            _args = args;
            TransactionId = transactionId;
            Code = code;
        }

        protected BaseHttpException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// 事务编号
        /// </summary>
        public string TransactionId { get; }


        /// <summary>
        /// 错误码
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public override string Message => _localizer[Code, _args];

        /// <summary>
        /// 错误明细
        /// </summary>  
        public virtual string Detail => _localizer[Code + "_Detail", _args];
    }
}
