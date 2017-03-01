using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

using System.Configuration;

namespace TimeProject.Models
{
    public static class DataBase
    {
        private static DbConnection Connexion { get; set; }
        private static DbCommand Command { get; set; }
        private static DbDataReader DataReader { get; set; }
        private static string messErreur { get; set; }

        // Récupère les informations du App.config et créée la connexion
        public static DbConnection CreateDbConnection(string providerName, string connectionString)
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

                    messErreur = "";
                }
                catch (Exception ex)
                {
                    // Set the connection to null if it was created.
                    if (connection != null)
                    {
                        connection = null;
                    }
                    messErreur += ex.Message;
                }
            }
            // Return the connection.
            return connection;
        }

        public static void OpenConnexion(DbConnection connexion)
        {
            connexion.Open();
        }
        public static void DeConnexion(DbConnection connexion)
        {
            connexion.Close();
        }
        // Créer et ouvre la connexion
        public static DbConnection ConnexionToDataBase()
        {
            // string messErreur = "";

            string providerName = ConfigurationManager.ConnectionStrings["MaConnection"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["MaConnection"].ConnectionString;

            Connexion = CreateDbConnection(providerName, connectionString);

            if (Connexion != null)
            {
                try
                {
                    OpenConnexion(Connexion);
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

            if(messErreur != "")
            {
                System.Windows.Forms.MessageBox.Show(messErreur);
                messErreur = "";
            }

            return Connexion;
        }

        // FONCTION A VIRER DES QUE TOUT LES MONDE A TESTER
        //public static string TestConnexion()
        //{
        //    // INSERT INTO `client`(`NOMCLIENT`) VALUES ('TEST');
            
        //    string messRes = "";
        //    string messErreur = "";

        //    string providerName = ConfigurationManager.ConnectionStrings["MaConnection"].ProviderName;
        //    string connectionString = ConfigurationManager.ConnectionStrings["MaConnection"].ConnectionString;

        //    DbConnection connexion = CreateDbConnection(providerName, connectionString);

        //    if (connexion != null)
        //    {
        //        try
        //        {
        //            OpenConnexion(connexion);
        //            messErreur = "";
        //        }
        //        catch (Exception err)
        //        {
        //            messErreur = (err.Message);
        //        }
        //        //finally
        //        //{
        //        //    DeConnexion(connexion);
        //        //}
        //    }

        //    if (messErreur == "")
        //    { 
        //        Command = connexion.CreateCommand();
        //        Command.CommandText = "SELECT CODE_PROJET FROM projet;";
        //        DataReader = Command.ExecuteReader();
        //        if (DataReader.Read())
        //        {
        //            messRes = DataReader[0].ToString();
        //        }
        //        DataReader.Close();
        //    }
        //    else
        //    {
        //        messRes = messErreur;
        //    }

        //    return messRes;
        //}
    }
}