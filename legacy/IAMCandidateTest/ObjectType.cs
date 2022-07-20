using System;
using System.Collections.Generic;

//using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
//using (SqlCommand command = connection.CreateCommand())

namespace IAMCandidateTest
{
    [Serializable]
    public class ObjectType
    {
        public static readonly IReadOnlyList<ObjectType> All = new List<ObjectType>()
        {
            new ObjectType('A', "Animal"),
            new ObjectType('M', "Mineral"),
            new ObjectType('V', "Vegetable")
        };


        private ObjectType(char id, string name)
        {
            ID = id;
            Name = name;
        }


        public char ID { get; set; }

        public string Name { get; set; }
    }
}
