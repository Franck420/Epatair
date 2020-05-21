using Epatair.Dto;
using Epatair.Mappeur;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Repository
{
    //Repository contenant les fonctions concernant les avions
    class RepositoryAvion : IRepositoryAvion
    {
        MappeurAvion mapper = new MappeurAvion();

        //initialisation de la chaine de connection à notre BD
        protected string ChaineConnexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["BDEpatAir"].ConnectionString;
            }
        }

        //fonctions pour aller chercher et retourner la liste des avions
        public List<AvionDTO> GetListeAvion()
        {
            var listeAvion = new List<AvionDTO>();
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select * from Tbl_Avion", connexion);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dto = new AvionDTO();
                        mapper.Map(reader, dto);
                        listeAvion.Add(dto);
                    }
                }
                return listeAvion;
            }
        }

        //Fonction pour créé un avion
        public void NouvealleAvion(string Nom, int IdLogbook, double Tarif)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                connexion.Open();

                SqlCommand commande = new SqlCommand("INSERT INTO Tbl_Avion (Nom,IdLogbook,Tarif) VALUES (@Nom,@IdLogbook,@Tarif); SELECT SCOPE_IDENTITY()", connexion);
                commande.Parameters.AddWithValue("@Nom", Nom);
                commande.Parameters.AddWithValue("@IdLogbook", IdLogbook);
                commande.Parameters.AddWithValue("@Tarif", Tarif);
                object valeur = commande.ExecuteScalar();
            }
        }

        //Fonction pour supprimer un avion
        public void SupprimerAvion(int IdAvion)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("DELETE FROM Tbl_Avion WHERE IdAvion = @IdAvion", connexion);
                commande.Parameters.AddWithValue("@IdAvion", IdAvion);
                connexion.Open();
                commande.ExecuteNonQuery();
            }
        }
        //Fonction pour modifier un avion
        public void ModifierAvion(AvionDTO Avion)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("update Tbl_Avion set Nom = @Nom, IdLogbook = @IdLogbook, Tarif = @Tarif where IdAvion = @IdAvion", connexion);

                commande.Parameters.AddWithValue("@IdAvion", Avion.IdAvion);
                commande.Parameters.AddWithValue("@Nom", Avion.Nom);
                commande.Parameters.AddWithValue("@IdLogbook", Avion.IdLogbook);
                commande.Parameters.AddWithValue("@Tarif", Avion.Tarif);
                connexion.Open();
                commande.ExecuteNonQuery();
            }
        }

        public AvionDTO GetAvion(int IdAvion)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select * from Tbl_Avion where IdAvion=@IdAvion", connexion);
                commande.Parameters.AddWithValue("@IdAvion", IdAvion);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                    if (reader.Read())
                    {
                        var dto = new AvionDTO();
                        mapper.Map(reader, dto);
                        return dto;
                    }
                    else
                        return null;
            }
        }

        public AvionDTO GetAvion(string NomAvion)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select * from Tbl_Avion where Nom=@NomAvion", connexion);
                commande.Parameters.AddWithValue("@NomAvion", NomAvion);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                    if (reader.Read())
                    {
                        var dto = new AvionDTO();
                        mapper.Map(reader, dto);
                        return dto;
                    }
                    else
                        return null;
            }
        }
    }
}
