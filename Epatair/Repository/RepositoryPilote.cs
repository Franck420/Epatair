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
    //Repository contenant les fonctions concernant les pilotes
    class RepositoryPilote : IRepositoryPilote
    {

        MappeurPilote mapper = new MappeurPilote();

        protected string ChaineConnexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["BDEpatAir"].ConnectionString;
            }
        }

        //fonctions pour aller chercher et retourner la liste des pilotes
        public List<PiloteDTO> GetListePilote()
        {
            var listePilote = new List<PiloteDTO>();
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select IdPilote,Nom,Titre from Tbl_Pilote inner join Tbl_Grade on Tbl_Pilote.IdGrade = Tbl_Grade.IdGrade", connexion);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {                       
                        var dto = new PiloteDTO();
                        mapper.Map(reader, dto);
                        listePilote.Add(dto);
                    }
                }
                return listePilote;
            } 
        }

        //Fonction pour aller chercher un pilote grâce à son ID
        public PiloteDTO GetPilote(int IdPilote)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select * from Tbl_Pilote inner join Tbl_Grade on Tbl_Pilote.IdGrade = Tbl_Grade.IdGrade where IdPilote=@IdPilote", connexion);
                commande.Parameters.AddWithValue("@IdPilote", IdPilote);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                    if (reader.Read())
                    {                        
                        var dto = new PiloteDTO();
                        mapper.Map(reader, dto);                        
                        return dto;
                    }
                    else
                        return null;
            }
        }

        //Fonction pour aller chercher un Pilote avec le nom
        public PiloteDTO GetPilote(string NomPilote)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select * from Tbl_Pilote inner join Tbl_Grade on Tbl_Pilote.IdGrade = Tbl_Grade.IdGrade where Nom=@NomPilote", connexion);
                commande.Parameters.AddWithValue("@NomPilote", NomPilote);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                    if (reader.Read())
                    {
                        var dto = new PiloteDTO();
                        mapper.Map(reader, dto);
                        return dto;
                    }
                    else
                        return null;
            }
        }

        //Fonction pour aller chercher une liste de pilotes selon leur grade
        public List<PiloteDTO> GetListePilote(string grade)
        {
            var listePilote = new List<PiloteDTO>();
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select IdPilote,Nom,Titre from Tbl_Pilote inner join Tbl_Grade on Tbl_Pilote.IdGrade = Tbl_Grade.IdGrade where Titre = @Grade", connexion);
                commande.Parameters.AddWithValue("@Grade", grade);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {                       
                        var dto = new PiloteDTO();
                        mapper.Map(reader, dto);
                        listePilote.Add(dto);
                    }
                }
                return listePilote;
            }
        }

        //Fonction pour créé un pilote
        public void NouveauPilote(PiloteDTO Pilote)
        {
            int grade =0;

            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select IdGrade from Tbl_Grade where Titre = @Grade", connexion);
                commande.Parameters.AddWithValue("@Grade", Pilote.Grade);
                connexion.Open();
                using (SqlDataReader reader = commande.ExecuteReader())
                    if (reader.Read())
                    {
                        grade = (int)reader["IdGrade"];
                    }                    

                SqlCommand commande2 = new SqlCommand("INSERT INTO Tbl_Pilote (Nom,IdGrade ) VALUES (@Nom,"+grade+"); SELECT SCOPE_IDENTITY()", connexion);
                commande2.Parameters.AddWithValue("@Nom", Pilote.Nom);               
                object valeur = commande2.ExecuteScalar(); 
                Pilote.IdPilote = int.Parse(valeur.ToString());
            }
        }

        //Fonction pour supprimer un pilote
        public void SupprimerPilote(int IdPilote)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("DELETE FROM Tbl_Pilote WHERE IdPilote = @IdPilote", connexion);
                commande.Parameters.AddWithValue("@IdPilote", IdPilote);
                connexion.Open();
                commande.ExecuteNonQuery();
            }
        }

        //Fonction pour modifier un pilote
        public void ModifierPilote(PiloteDTO Pilote)
        {
            int grade = 0;

            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("update Tbl_Pilote set Nom = @Nom, IdGrade = @Grade where IdPilote = @IdPilote", connexion);
                                
                if (Pilote.Grade == "Pilote")
                    grade = 1;
                else if (Pilote.Grade == "Instructeur")
                    grade = 2;

                commande.Parameters.AddWithValue("@IdPilote", Pilote.IdPilote);
                commande.Parameters.AddWithValue("@Nom", Pilote.Nom);
                commande.Parameters.AddWithValue("@Grade", grade);
                connexion.Open();
                commande.ExecuteNonQuery();
            }
        }
    }
}
