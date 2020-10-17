using HelloWorld.Models;
using HelloWorld.Data;

namespace HelloWorld.Business
{
    public class Traitement
    {
        static public bool AjouterEmploye(Employe employe)
        {
            try
            {
                using (var db = new HelloWorldContext())
                {
                    db.Employes.Add(employe);
                    var count = db.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                
                throw e;
            }

            return true;
        }

        static public bool SupprimerEmploye(Employe employe)
        {
            try
            {
                using (var db = new HelloWorldContext())
                {
                    db.Employes.Remove(employe);
                    var count = db.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                
                throw e;
            }

            return true;
        }        

        static public bool ModifierEmploye(Employe employe)
        {
            try
            {
                using (var db = new HelloWorldContext())
                {
                    db.Employes.Update(employe);
                    var count = db.SaveChanges();
                }
            }
            catch (System.Exception e)
            {
                
                throw e;
            }

            return true;
        }        

        static public Employe ObtenirEmploye(int id)
        {
            Employe employe = null;

            try
            {
                using (var db = new HelloWorldContext())
                {
                    employe = db.Employes.Find(id);
                }
            }
            catch (System.Exception e)
            {
                
                throw e;
            }

            return employe;
        }        


    }
}