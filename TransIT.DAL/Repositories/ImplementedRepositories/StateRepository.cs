﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransIT.DAL.Models;
using TransIT.DAL.Models.Entities;
using TransIT.DAL.Repositories.InterfacesRepositories;

namespace TransIT.DAL.Repositories.ImplementedRepositories
{
    public class StateRepository : BaseRepository<State>, IStateRepository
    {
        public StateRepository(TransITDBContext context)
               : base(context)
        {
        }
        
        public override Task<IQueryable<State>> SearchExpressionAsync(IEnumerable<string> strs) =>
            Task.FromResult(
                GetQueryable().Where(entity =>
                    strs.Any(str => entity.TransName.ToUpperInvariant().Contains(str)))
                );
    }
}
