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

        List<PiloteDTO> GetListePilote()
        {

            var listePilote = new List<PiloteDTO>();
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("SELECT * FROM Tbl_Pilote", connexion);
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

        PiloteDTO GetPilote(int IdPilote)
        {

        }

        List<PiloteDTO> GetListePilote(string grade)
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
        void NouveauPilote(PiloteDTO Pilote)
        {

        }
        void SupprimerPilote(int IdPilote)
        {

        }
        void ModifierPilote(PiloteDTO Pilote)
        {

        }
    }
}
