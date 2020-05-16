using Epatair.Dto;
using Epatair.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epatair.Repositorie
{
    class RepositoryFacture:IRepositoryFacture
    {
        protected string ChaineConnexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["BDEpatAir"].ConnectionString;
            }
        }

      


        

        public List<Dto.FactureDto> GetListeFacture()
        {
            var liste = new List<FactureDto>();

            using (SqlConnection connection = new SqlConnection(ChaineConnexion))
            {
                SqlCommand command = new SqlCommand("Select * From Facture", connection);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mapper = new Mappeur.MappeurFacture();
                        var dto = new FactureDto();
                        mapper.Map(reader, dto);
                        liste.Add(dto);

                    }

                }
                return liste;

            }


        }

        public void NouvelleFacture(FactureDto facture)
        {
            //a faire avec Francis
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("INSERT INTO Facture (Titre) VALUES (@TitreArticle); SELECT SCOPE_IDENTITY()", connexion);

                connexion.Open();
                object valeur = commande.ExecuteScalar(); // Existe aussi pour MySQL.Data
                facture.Idfacture = int.Parse(valeur.ToString());
            }


        }


    }
}
