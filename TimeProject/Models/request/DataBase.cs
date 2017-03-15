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
        public static DbConnection GetConnexion()
        {
            return Connexion;
        }
        // Requete
        // Create Command
        public static DbCommand DBCreateCommand(string requete)
        {
            Command = Connexion.CreateCommand();
            Command.CommandText = requete;

            return Command;
        }
        // Structure général pour Insert Update et Delete
        public static int DBCUD(string requete)
        {
            int nbLigne = -1;

            try
            {
                nbLigne = DBCreateCommand(requete).ExecuteNonQuery();
            }
            catch(Exception err)
            {
                messErreur += (err.Message);
            }

            if (messErreur != "")
            {
                System.Windows.Forms.MessageBox.Show(messErreur);
                messErreur = "";
            }

            return nbLigne;
        }
        // Insert
        public static int DBInsert(string requete)
        {
            int nbLigne;

            nbLigne = DBCUD(requete);

            return nbLigne;
        }
        // Update
        public static int DBUpdate(string requete)
        {
            int nbLigne;

            nbLigne = DBCUD(requete);

            return nbLigne;
        }
        // Delete
        public static int DBDelete(string requete)
        {
            int nbLigne;

            nbLigne = DBCUD(requete);

            return nbLigne;
        }
        // Read
        public static DbDataReader DBSelect(string requete)
        {
            try
            {
                DataReader = DBCreateCommand(requete).ExecuteReader();
            }
            catch (Exception err)
            {
                messErreur += (err.Message);
            }

            if (messErreur != "")
            {
                System.Windows.Forms.MessageBox.Show(messErreur);
                messErreur = "";
            }
            
            return DataReader;
        }
        // Fermeture du DataReader
        public static void FermeDataReader(DbDataReader dataReader)
        {
            // DataReader.Close();
            dataReader.Close();
        }
    }
}