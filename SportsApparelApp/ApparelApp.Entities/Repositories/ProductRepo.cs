﻿using ApparelApp.Entities.Interfaces;
using ApparelApp.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SportsApparelWebApp.Repositories
{
    public class ProductRepo:IProductRepo
    {
        private readonly SportsApparelContext _contextStores;

        private readonly ILogger<ProductRepo> _logger;

        public ProductRepo()
        {
            _contextStores = new SportsApparelContext();
        }

        public ProductRepo(SportsApparelContext contextStores, ILogger<ProductRepo> logger)
        {
            _contextStores = contextStores ?? throw new ArgumentNullException(nameof(contextStores));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));


        }

        public void Delete(int ID)
        {
            Product product = _contextStores.Product.Find(ID);
            _contextStores.Product.Remove(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _contextStores.Product.ToList();
        }

        public IEnumerable<SelectListItem> GetAllProducts()
        {
            var selectList = new List<SelectListItem>();
            selectList = (from obj in _contextStores.Product
                          select new SelectListItem()
                          {
                              Text = obj.Name,
                              Value = obj.ProdId.ToString(),
                              Selected = false
                          }).ToList();
            return selectList;
        }

        public Product GetById(int ID)
        {
            return _contextStores.Product.Find(ID);

        }

        public void Insert(Product product)
        {
            _contextStores.Product.Add(product);

        }

        public void Save()
        {
            _contextStores.SaveChanges();
        }

        public void Update(Product product)
        {
            _contextStores.Entry(product).State = EntityState.Modified;


        }
    }
}
