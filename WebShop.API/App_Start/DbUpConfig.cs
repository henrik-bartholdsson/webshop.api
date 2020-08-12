using DbUp;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebShop.API.Models;

namespace WebShop.API.App_Start
{
    public class DbUpConfig
    {
        public static void InitDatabse(string connectionString)
        {
                EnsureDatabase.For.SqlDatabase(connectionString);

                var upgrader =
                    DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.Load("WebShop.Data"))
                    .LogToAutodetectedLog()
                    .Build();

#if DEBUG
                WaitForDatabase(upgrader);
#endif

                var a = upgrader.GetScriptsToExecute();
                upgrader.PerformUpgrade();
        }

        private static void WaitForDatabase(DbUp.Engine.UpgradeEngine upgrader)
        {
            while (!upgrader.TryConnect(out string connectionMessage)) { };
        }
    }
}