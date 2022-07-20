using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace IAMCandidateTest.Data
{
    public static class Database
    {
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public static IEnumerable<Animal> GetAnimals()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = "SELECT * FROM [dbo].[Animal]";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Animal> animals = new List<Animal>();
                    while (reader.Read())
                    {
                        animals.Add(ReadAnimalRow(reader));
                    }

                    return animals;
                }
            }
        }

        public static Animal GetAnimal(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = $"SELECT * FROM [dbo].[Animal] WHERE [ID] = '{id}'";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return ReadAnimalRow(reader);
                    }

                    return null;
                }
            }
        }

        private static Animal ReadAnimalRow(SqlDataReader reader)
        {
            return new Animal()
            {
                ID = reader.GetGuid(0),
                CommonName = reader.GetString(1),
                LegCount = reader.GetInt32(2),
                WingCount = reader.GetInt32(3),
                CanFly = reader.GetBoolean(4),
                TaxPhylum = reader.GetString(5),
                TaxClass = reader.GetString(6),
                TaxOrder = reader.GetString(7),
                TaxFamily = reader.GetString(8),
                TaxGenus = reader.GetString(9),
                TaxSpecies = reader.GetString(10)
            };
        }

        public static IEnumerable<Mineral> GetMinerals()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = "SELECT * FROM [dbo].[Mineral]";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Mineral> minerals = new List<Mineral>();

                    while (reader.Read())
                    {
                        minerals.Add(ReadMineralRow(reader));
                    }

                    return minerals;
                }
            }
        }

        public static Mineral GetMineral(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = $"SELECT * FROM [dbo].[Mineral] WHERE [ID] = '{id}'";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return ReadMineralRow(reader);
                    }

                    return null;
                }
            }
        }

        private static Mineral ReadMineralRow(SqlDataReader reader)
        {
            return new Mineral()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetString(1),
                Hardness = reader.GetDecimal(2),
                Luster = reader.GetString(3),
                Color = reader.GetString(4),
                Streak = reader.GetString(5),
                SpecificGravity = reader.GetDecimal(6),
                Diaphaneity = reader.GetString(7)
            };
        }

        public static IEnumerable<Vegetable> GetVegetables()
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = "SELECT * FROM [dbo].[Vegetable]";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<Vegetable> vegetables = new List<Vegetable>();

                    while (reader.Read())
                    {
                        vegetables.Add(ReadVegetableRow(reader));
                    }

                    return vegetables;
                }
            }
        }

        public static Vegetable GetVegetable(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            using (SqlCommand command = connection.CreateCommand())
            {
                connection.Open();

                command.CommandText = $"SELECT * FROM [dbo].[Vegetable] WHERE [ID] = '{id}'";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return ReadVegetableRow(reader);
                    }

                    return null;
                }
            }
        }

        private static Vegetable ReadVegetableRow(SqlDataReader reader)
        {
            return new Vegetable()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetString(1),
                EdiblePart = reader.GetString(2),
                IsBotanicalFruit = reader.GetBoolean(3)
            };
        }
    }
}
