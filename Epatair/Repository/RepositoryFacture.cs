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
    //Repository contenant les fonctions concernant les factures
    class RepositoryFacture :IRepositoryFacture
    {
        //initialisation de la chaine de connection à notre BD
        protected string ChaineConnexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["BDEpatAir"].ConnectionString;
            }
        }

        //Fonction permettant d'aller chercher et de retourner une liste de facture
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

        //Fonction pour créer une nouvelle facture
        public void NouvelleFacture(int avion, string instruteur, string pilote, double HeuredeVol, double HeureSol, DateTime HeureDemarrage, DateTime HeureArret, DateTime HeureAtterissage, DateTime HeureDecolage)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {

                connexion.Open();

                SqlCommand commande = new SqlCommand("INSERT INTO Tbl_Facture (HeureSol,HeureVol,IdAvion,IdInstruteur,IdPilote,HeureDemmage,HeureArret,HeureDecollage,HeureAtterissage) VALUES (@Avion,@instruteur,@pilote,@HeuredeVol,@HeureSol,@HeureDemarrage,@HeureArret,@HeureAtterissage,@HeureDecolage); SELECT SCOPE_IDENTITY()", connexion);

                commande.Parameters.AddWithValue("@Avion", avion);
                commande.Parameters.AddWithValue("@instruteur", instruteur);
                commande.Parameters.AddWithValue("@pilote", pilote);
                commande.Parameters.AddWithValue("@HeuredeVol", HeuredeVol);
                commande.Parameters.AddWithValue("@HeureSol", HeureSol);
                commande.Parameters.AddWithValue("@HeureDemarrage", HeureDemarrage);
                commande.Parameters.AddWithValue("@HeureArret", HeureArret);
                commande.Parameters.AddWithValue("@HeureAtterissage", HeureAtterissage);
                commande.Parameters.AddWithValue("@HeureDecolage", HeureDecolage);

                object valeur = commande.ExecuteScalar();
            }


        }


    }
}
