﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imeshma.Entity;
using Imeshma.DAL.Interfaces;
using System.Data.Entity.Infrastructure;
using System.Data.Common;
using System.Data.SqlClient;
 using System.Data;

namespace Imeshma.DAL.Repositroy
{
    public class ProductRepo :IProductRepo
    {
        ImeshmaEntities _db;
        public ProductRepo()
        {
            //_db = new ImeshmaEntities();
        }


        public List<Products> GetProductDetails(string search)
        {
            List<Products> _productList;
            try
            {
               
                using (_db = new ImeshmaEntities())
                {
                    DbDataReader _reader;
                    //_db.Database.Initialize(force: false);
                    _db.Database.Connection.Open();
                    DbCommand _dbCmd = _db.Database.Connection.CreateCommand();
                    _dbCmd.CommandText = "GetProductDetails";
                    _dbCmd.CommandType = CommandType.StoredProcedure;
                    _dbCmd.CommandTimeout = 60 * 5;
                    _dbCmd.Parameters.AddRange(new SqlParameter[] {
                         new SqlParameter("@search",search )
                         //new SqlParameter("@CountryId",CountryId ),
                         //new SqlParameter("@UserId",UserID ),
                         //    new SqlParameter("@IsMedicine",IsMedicine)


                    });
                    _reader = _dbCmd.ExecuteReader();

                    _productList = ((IObjectContextAdapter)_db).ObjectContext.Translate<Products>(_reader).ToList();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //if (_db.Database.Connection.State == ConnectionState.Open)
                //{
                //    _db.Database.Connection.Close();
                //}
            }

            return _productList;
       

        }

        public void SaveProducts(List<Product> products)
        {
            ImeshmaEntities _db = new ImeshmaEntities();
            _db.Products.AddRange(products);
            _db.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            ImeshmaEntities _db = new ImeshmaEntities();
             return   _db.Categories.ToList();

        }

    }
}
