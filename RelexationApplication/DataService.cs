using System;
using System.Collections.Generic;
using System.Text;

namespace RelexationApplication
{
    public class DataService
    {
        Repository repository;
        public DataService()
        {
            repository = new Repository();
        }

        public List<Category> GetAllCategories()
        {
            return repository.GetCategories();
        }
    }
}
