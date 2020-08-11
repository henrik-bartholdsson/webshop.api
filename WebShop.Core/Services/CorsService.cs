using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebShop.API.Models;

namespace WebShop.Core.Services
{
    public interface ICorsServiceA
    {
        string[] GetListOfAllActiveCors();
    }
    public class CorsServiceA : ICorsServiceA
    {
        public string[] GetListOfAllActiveCors()
        {
            using (var context = new WebShopContext())
            {
                var allActiveCors = context.CORS.Where(c => c.ACTIVE == true && !String.IsNullOrEmpty(c.ADDRESS) && !c.ADDRESS.Contains("*")).ToList();
                var allActiveCorsAsList = allActiveCors.Select(c => c.ADDRESS).ToArray();

                return allActiveCorsAsList;
            }
        }
    }
}
