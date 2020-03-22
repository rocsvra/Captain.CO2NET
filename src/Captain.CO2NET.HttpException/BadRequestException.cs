using Microsoft.Extensions.Localization;
using System;
using System.Runtime.Serialization;

namespace Captain.CO2NET.HttpException
{
    [Serializable]
    public class BadRequestException : BaseHttpException
    {
        public BadRequestException(IStringLocalizer localizer, string transactionId, string code, params string[] args)
            : base(localizer, transactionId, code, args)
        {
        }

        public BadRequestException(IStringLocalizer localizer, string transactionId, string code, Exception innerException, params string[] args)
            : base(localizer, transactionId, code, innerException, args)
        {
        }

        protected BadRequestException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
