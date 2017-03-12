using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*using (var context = new DBContext())
            {
                // Create database
                context.Database.EnsureCreated();

                var user = new cuentasusuario { cuentasusuarioId = 1152217168, CU_Usuario = "diego", CU_Password = "diegoverde", CU_Perfil = 1 };
                context.CuentasUsuario.Add(user);
            }*/

            var host = new WebHostBuilder()
            .UseUrls("http://0.0.0.0:5000/")
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>()
            .Build();
 
            host.Run();            
        }
    }
}
