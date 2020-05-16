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
    class RepositoryAvion : IRepositoryAvion
    {
        MappeurAvion mapper = new MappeurAvion();

        protected string ChaineConnexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["BDEpatAir"].ConnectionString;
            }
        }


        public AvionDTO GetAvion(int IdAvion) 
        {
            AvionDTO patate = new AvionDTO();
            return patate;
        }
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
        public void NouvealleAvion(AvionDTO Avion) 
        { 
        
        }
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
        public void ModifierAvion(AvionDTO Avion)
        {
        
        }
    }
}
