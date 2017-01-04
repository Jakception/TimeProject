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
        private static DbConnection connexion;
        private static DbCommand commande;
        private static DbDataReader dataReader;

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

        static public void Connexion(DbConnection connexion)
        {
            connexion.Open();
        }
        static public void DeConnexion(DbConnection connexion)
        {
            connexion.Close();
        }

       static public string ConnexionToDataBase()
        {
            string messErreur = "";

            string providerName = ConfigurationManager.ConnectionStrings["MaConnection"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["MaConnection"].ConnectionString;

            connexion = CreateDbConnection(providerName, connectionString);

            if (connexion != null)
            {
                try
                {
                    Connexion(connexion);
                    messErreur = "";
                }
                catch (Exception err)
                {
                    messErreur += (err.Message);
                }
                //finally
                //{
                //    DeConnexion(connexion);
                //}
            }
            return messErreur;
        }
        // FONCTION A VIRER DES QUE TOUT LES MONDE A TESTER
        static public string TestConnexion()
        {
            // INSERT INTO `client`(`NOMCLIENT`) VALUES ('TEST');
            
            string messRes = "";
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
                //}
            }

            if (messErreur == "")
            { 
                commande = connexion.CreateCommand();
                commande.CommandText = "SELECT NOMCLIENT FROM client;";
                dataReader = commande.ExecuteReader();
                if (dataReader.Read())
                {
                    messRes = dataReader[0].ToString();
                }
                dataReader.Close();
            }
            else
            {
                messRes = messErreur;
            }

            return messRes;
        }
    }
}