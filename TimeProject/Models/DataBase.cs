using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

using System.Configuration;

namespace TimeProject.Models
{
    public class DataBase
    {
        private DbConnection connexion;

        // On lui passe à partir de : AppConfig
        // string providerName = connex.ProviderName;
        // string connectionString = connex.ConnectionString;
        static DbConnection CreateDbConnection(string providerName, string connectionString)
        {
            // Assume failure.
            DbConnection connection = null;

            // Create the DbProviderFactory and DbConnection.
            if (connectionString != null)
            {
                try
                {
                    DbProviderFactory factory =
                        DbProviderFactories.GetFactory(providerName);

                    connection = factory.CreateConnection();
                    connection.ConnectionString = connectionString;
                }
                catch (Exception ex)
                {
                    // Set the connection to null if it was created.
                    if (connection != null)
                    {
                        connection = null;
                    }
                }
            }
            // Return the connection.
            return connection;
        }

        public void Connexion(DbConnection connexion)
        {
            connexion.Open();
        }
        public void DeConnexion(DbConnection connexion)
        {
            connexion.Close();
        }

        public string ConnexionToDataBase()
        {
            string messErreur = "";

            string providerName = ConfigurationManager.ConnectionStrings["MaConnection"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["MaConnection"].ConnectionString;

            DbConnection connexion = CreateDbConnection(providerName, connectionString);

            if (connexion != null)
            {
                try
                {
                    Connexion(connexion);
                    messErreur = "";
                }
                catch (Exception err)
                {
                    messErreur = (err.Message);
                }
                //finally
                //{
                //    DeConnexion(connexion);
                //    messErreur += "Deco";
                //}
            }
            return messErreur;
        }
    }
}
