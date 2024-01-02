using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlumberManagementApp.Model;

namespace PlumberManagementApp.DAL.Interfaces
{
    public interface IPlumberRepository
    {
        string GetAll();
        string Add();
        string Update();
        string Delete();

        PlumberModel GetById(string id);

    }
}
