using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PlumberManagementApp.DAL.Interfaces;

namespace PlumberManagementApp.DAL.Services
{
    public class PlumberRepository : Interfaces.IPlumberRepository
    {
        private PlumberDbContext _context;

        public PlumberRepository(PlumberDbContext context)
        {
            _context = context;
        }

        public Model.PlumberModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string GetAll()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}