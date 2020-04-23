﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItaLog.Application.Interface;
using ItaLog.Application.ViewModels;
using ItaLog.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItaLog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly ILevelApplication _app;
        public LevelController(ILevelApplication app)
        {
            _app = app;
        }

        [HttpGet]
        public ActionResult<IEnumerable<LevelViewModel>> GetUsers()
        {
            return Ok(_app.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var user = _app.FindById(id);

            if (user is null)
                return NotFound();

            return Ok(user);
        }

        [HttpPost]
        public ActionResult Create([FromBody] LevelViewModel level)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));

            _app.Add(level);

            return CreatedAtAction(nameof(GetById), new { id = level.Id }, level);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] LevelViewModel level)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Values.SelectMany(e => e.Errors));

            if (level.Id != id)
                return BadRequest();

            var levelFind = _app.FindById(id);

            if (levelFind is null)
                return NotFound();

            levelFind.Description = level.Description;

            _app.Update(levelFind);

            return Ok();
        }

        [HttpDelete("{id}")]
        public 
            ActionResult Delete(int id)
        {
            var userFind = _app.FindById(id);

            if (userFind is null)
                return NotFound();

            _app.Remove(id);

            return Ok();
        }
    }
}