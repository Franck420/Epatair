using Epatair.Dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Repository
{
    class RepositoryPilote : IRepositoryPilote
    {

        protected string ChaineConnexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["BDEpatAir"].ConnectionString;
            }
        }

       public  List<PiloteDTO> GetListePilote()
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
                        var mapper = new Mappeur.MappeurPilote();
                        var dto = new PiloteDTO();
                        mapper.Map(reader, dto);
                        listePilote.Add(dto);
                    }
                }
                return listePilote;
            } 
        }

        public PiloteDTO GetPilote(int IdPilote)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select * from Tbl_Pilote where IdPilote=@IdPilote", connexion);

                commande.Parameters.AddWithValue("@IdPilote", IdPilote);
                connexion.Open();
                using (SqlDataReader reader = commande.ExecuteReader())
                    if (reader.Read())
                    {
                        var mapper = new Mappeur.MappeurPilote();
                        var dto = new PiloteDTO();
                        mapper.Map(reader, dto);                        
                        return dto;
                    }
                    else
                        return null;
            }
        }

        public List<PiloteDTO> GetListePilote(string grade)
        {
            var listePilote = new List<PiloteDTO>();
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("SELECT * FROM Tbl_Pilote where grade = @Grade", connexion);
                commande.Parameters.AddWithValue("@Grade", grade);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mapper = new Mappeur.MappeurPilote();
                        var dto = new PiloteDTO();
                        mapper.Map(reader, dto);
                        listePilote.Add(dto);
                    }
                }
                return listePilote;
            }
        }
        public void NouveauPilote(PiloteDTO Pilote)
        {
            int grade =0;

            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select IdGrade from Tbl_Grade where Titre="+Pilote.Grade, connexion);
                using (SqlDataReader reader = commande.ExecuteReader())
                    if (reader.Read())
                    {
                        grade = (int)reader["IdGrade"];
                    }                    

                SqlCommand commande2 = new SqlCommand("INSERT INTO Tbl_Pilote (IdPilote,Nom,IdGrade ) VALUES (@Nom,"+grade+"); SELECT SCOPE_IDENTITY()", connexion);

                commande2.Parameters.AddWithValue("@Nom", Pilote.Nom);
                connexion.Open();
                object valeur = commande2.ExecuteScalar(); 
                Pilote.IdPilote = int.Parse(valeur.ToString());
            }
        }
        public void SupprimerPilote(int IdPilote)
        {

        }
        public void ModifierPilote(PiloteDTO Pilote)
        {

        }
    }
}
