using System;
using HelloWorld.Data;
using HelloWorld.Business;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            using (var db = new HelloWorldContext())
            {
                Console.WriteLine();
                Console.WriteLine("Les employés en base de données :");
                foreach (var employe in db.Employes)
                {
                    Console.WriteLine(" - {0} {1}", employe.Nom, employe.Prenom);
                    foreach (var telephone in employe.Telephones)
                    {
                        Console.WriteLine(" -- {0} {1}", telephone.TypeTelephone.Libelle, telephone.Numero);
                    }

                }
            }

            var e = Traitement.ObtenirEmploye(1);
            Console.WriteLine("{0} {1}", e.Nom, e.Prenom);
            // foreach (var telephone in employe.Telephones)
            // {
            //     Console.WriteLine("{0} {1}", telephone.Numero, telephone.TypeTelephone.Libelle);
            // }



            // using (var db = new HelloWorldContext())
            // {
            //     db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            //     var count = db.SaveChanges();
            //     Console.WriteLine("{0} records saved to database", count);

            //     Console.WriteLine();
            //     Console.WriteLine("All blogs in database:");
            //     foreach (var blog in db.Blogs)
            //     {
            //         Console.WriteLine(" - {0}", blog.Url);
            //     }
            // }


        }
    }
}
