using System;
using System.Linq;
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
                var allActiveCors = context.CORS.Where(cors => cors.ACTIVE == true && !String.IsNullOrEmpty(cors.ADDRESS) && !cors.ADDRESS.Contains("*")).ToList();
                var allActiveCorsAsList = allActiveCors.Select(c => c.ADDRESS).ToArray();

                return allActiveCorsAsList;
            }
        }
    }
}
