﻿using Captain.DB2NET.NPoco.Demo.Models;
using Captain.DB2NET.NPoco4Mysql;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Captain.DB2NET.NPoco.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MysqlTestController : ControllerBase
    {
        private readonly ILogger<MysqlTestController> _logger;
        private readonly IMySqlDb _db;

        public MysqlTestController(ILogger<MysqlTestController> logger, IMySqlDb db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public IEnumerable<TestAVo> Get()
        {
            return _db.Query<TestAVo>("select A,id as B,Id as C from TestA");
        }

        [HttpPost]
        public object Post()
        {
            return _db.Insert(new TestA
            {
                Id = Guid.NewGuid().ToString(),
                A = Guid.NewGuid().ToString(),
            });
        }

        [HttpPost("Transaction")]
        public IActionResult PostTransaction()
        {
            _db.BeginTransaction();
            _db.Insert(new TestA
            {
                Id = Guid.NewGuid().ToString(),
                A = Guid.NewGuid().ToString(),
            });
            _db.Insert(new TestA
            {
                Id = Guid.NewGuid().ToString(),
                A = Guid.NewGuid().ToString(),
            });
            _db.CompleteTransaction();
            return Ok();
        }

        [HttpPut("{id}")]
        public int Put(string id, TestADto dto)
        {
            var testA = _db.SingleOrDefaultById<TestA>(id);
            testA.A = dto.A;
            return _db.Update(testA);
        }

        [HttpDelete("{id}")]
        public object Delete(string id)
        {
            return _db.Delete<TestA>(id);
        }
    }
}
