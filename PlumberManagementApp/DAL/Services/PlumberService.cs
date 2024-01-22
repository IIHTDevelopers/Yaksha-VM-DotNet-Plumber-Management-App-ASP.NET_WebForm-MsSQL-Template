using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PlumberManagementApp.DAL.Interfaces;
using PlumberManagementApp.Model;

namespace PlumberManagementApp.DAL.Services
{
    public class PlumberService : Interfaces.IPlumberService
    {
        private Interfaces.IPlumberRepository _repository;

        public PlumberService(Interfaces.IPlumberRepository repository)
        {
            _repository = repository;
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

        public PlumberModel GetById(string id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}