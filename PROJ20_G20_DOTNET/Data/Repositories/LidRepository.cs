﻿using Microsoft.EntityFrameworkCore;
using PROJ20_G20_DOTNET.Data;
using PROJ20_G20_DOTNET.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJ20_G20_DOTNET.Data.Repositories {
    public class LidRepository : ILidRepository {
        private readonly JiuJitsuDbContext _context;
        private readonly DbSet<Lid> _leden;

        public LidRepository(JiuJitsuDbContext context) {
            _context = context;
            _leden = context.Leden;
        }

        public void Add(Lid lid) {
            _leden.Add(lid);
        }

        public void Delete(Lid lid) {
            _leden.Remove(lid);
        }

        public IEnumerable<Lid> GetAll() {
            return _leden.ToList();
        }

        public Lid GetBy(int id) {
            return _leden.SingleOrDefault(l => l.Id == id);
        }

        public void SaveChanges() {
            _context.SaveChanges();
        }
    }
}
