﻿using ItaLog.Data.Context;
using ItaLog.Domain.Interfaces.Repositories;
using ItaLog.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace ItaLog.Api.Repository
{
    public class EnvironmentRepository : IEnvironmentRepository
    {
        private readonly ItaLogContext _context;
        public EnvironmentRepository(ItaLogContext context)
        {
            _context = context;
        }

        public void Add(Environment environment)
        {
            _context.Environments.Add(environment);
            _context.SaveChanges();
        }

        public Environment FindById(int id)
        {
            return _context.Environments.FirstOrDefault(environment => environment.Id == id);
        }

        public IEnumerable<Environment> GetAll()
        {
            return _context.Environments.ToList();
        }

        public void Remove(int id)
        {
            var user = _context.Environments.First(environment => environment.Id == id);
            _context.Environments.Remove(user);
            _context.SaveChanges();
        }

        public void Update(Environment environment)
        {
            _context.Environments.Update(environment);
            _context.SaveChanges();
        }
    }
}