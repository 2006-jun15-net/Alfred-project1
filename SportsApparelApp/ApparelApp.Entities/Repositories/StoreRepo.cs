using ApparelApp.Entities.Interfaces;
using ApparelApp.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SportsApparelWebApp.Repositories
{
    public class StoreRepo : IStoreRepo
    {
        private readonly SportsApparelContext _contextStores;

        private readonly ILogger<StoreRepo> _logger;

        public StoreRepo()
        {
            _contextStores = new SportsApparelContext();
        }

        public StoreRepo(SportsApparelContext contextStores, ILogger<StoreRepo> logger)
        {
            _contextStores = contextStores ?? throw new ArgumentNullException(nameof(contextStores));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));


        }


        public IEnumerable<ApparelApp.Entities.Entities.Store> GetAll()
        {
            return _contextStores.Store.ToList();
        }

        public IEnumerable<SelectListItem> GetAllStores()
        {
            var selectList = new List<SelectListItem>();
            selectList = (from obj in _contextStores.Store
                          select new SelectListItem()
                          {
                              Text = obj.Location,
                              Value = obj.StoreId.ToString(),
                              Selected = true
                          }).ToList();
            return selectList;
        }

        public ApparelApp.Entities.Entities.Store GetById(int ID)
        {
            return _contextStores.Store.Find(ID);
        }


        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ApparelApp.Entities.Entities.Store store)
        {

            _contextStores.Entry(store).State = EntityState.Modified;


        }

        

        
    }
}
