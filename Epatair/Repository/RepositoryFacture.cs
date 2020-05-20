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
        Mappeur.MappeurFacture mapper = new Mappeur.MappeurFacture();

        //Fonction permettant d'aller chercher et de retourner une liste de facture
        public List<Dto.FactureDto> GetListeFacture()
        {
            var liste = new List<FactureDto>();

            using (SqlConnection connection = new SqlConnection(ChaineConnexion))
            {
                SqlCommand command = new SqlCommand("Select * From Tbl_Facture", connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        var dto = new FactureDto();
                        mapper.Map(reader, dto);
                        liste.Add(dto);

                    }

                }
                return liste;

            }


        }

        //Fonction pour créer une nouvelle facture
        public void NouvelleFacture(FactureDto facture)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {

                connexion.Open();

                SqlCommand commande = new SqlCommand("INSERT INTO Tbl_Facture (HeureSol,HeureVol,IdAvion,IdInstruteur,IdPilote,HeureDemmage,HeureArret,HeureDecollage,HeureAtterissage) VALUES (@Avion,@instruteur,@pilote,@HeuredeVol,@HeureSol,@HeureDemarrage,@HeureArret,@HeureAtterissage,@HeureDecolage); SELECT SCOPE_IDENTITY()", connexion);

                commande.Parameters.AddWithValue("@Avion", facture.avion);
                commande.Parameters.AddWithValue("@instruteur", facture.Instructeur.IdPilote);
                commande.Parameters.AddWithValue("@pilote", facture.Pilote.IdPilote);
                commande.Parameters.AddWithValue("@HeuredeVol", facture.HrVol);
                commande.Parameters.AddWithValue("@HeureSol", facture.HrSol);
                commande.Parameters.AddWithValue("@HeureDemarrage", facture.HrDemarrage);
                commande.Parameters.AddWithValue("@HeureArret", facture.HrArret);
                commande.Parameters.AddWithValue("@HeureAtterissage", facture.HrAtterissage);
                commande.Parameters.AddWithValue("@HeureDecolage", facture.HrDecollage);

                object valeur = commande.ExecuteScalar();
            }


        }

        public FactureDto GetFacture(int IdFacture)
        {
            using (SqlConnection connexion = new SqlConnection(ChaineConnexion))
            {
                SqlCommand commande = new SqlCommand("select * from Tbl_Facture where IdFacture=@IdFacture", connexion);
                commande.Parameters.AddWithValue("@IdFacture", IdFacture);
                connexion.Open();

                using (SqlDataReader reader = commande.ExecuteReader())
                    if (reader.Read())
                    {
                        var dto = new FactureDto();
                        mapper.Map(reader, dto);
                        return dto;
                    }
                    else
                        return null;
            }
        }

    }
}
