using Npgsql;
using SaveTheOceanLib;
using System;
using System.Collections.Generic;

public class RescueDAO
{
    private string connectionString;

    public RescueDAO(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void InsertRescue(rescue rescue, string animalSuperFamily, string localization, int affectDegree)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO rescues (rescue_num, rescue_date, animal_superfamily, affect_degree, localization) " +
                           "VALUES (@RescueNum, @RescueDate, @AnimalSuperfamily, @AffectDegree, @Localization)";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RescueNum", rescue.RescueNum);
                command.Parameters.AddWithValue("@RescueDate", rescue.RescueDate);
                command.Parameters.AddWithValue("@AnimalSuperfamily", animalSuperFamily);
                command.Parameters.AddWithValue("@AffectDegree", affectDegree);
                command.Parameters.AddWithValue("@Localization", localization);
                command.ExecuteNonQuery();
            }
        }
    }

    //He intentado que funcione, pero algo falla con AnimalSuperFamily, AffectDegree y Localization
    /*
    public List<rescue> GetAllRescues()
    {
        List<rescue> rescues = new List<rescue>();
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT rescue_num, rescue_date, animal_superfamily, affect_degree, localization FROM rescues";
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rescues.Add(new rescue
                        {
                            RescueNum = reader.GetInt32(0),
                            RescueDate = reader.GetString(1),
                            AnimalSuperFamily = reader.GetString(2),
                            AffectDegree = reader.GetInt32(3),
                            Localization = reader.GetString(4)
                        });
                    }
                }
            }
        }
        return rescues;
    }*/
}
