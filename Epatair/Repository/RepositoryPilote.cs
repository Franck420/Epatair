﻿using Epatair.Dto;
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

        public int GetPilote(int IdPilote)
        {
            return 0;
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

        }
        public void SupprimerPilote(int IdPilote)
        {

        }
        public void ModifierPilote(PiloteDTO Pilote)
        {

        }
    }
}
