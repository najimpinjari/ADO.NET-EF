using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdO.net
{
    public class TrainerDb
    {
        //select all Trainers   

        public List<Trainer> AllTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();
            string connectionString = "server.\\sqlexpress;database=ADODOTNET;integrated security=true;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string cmdText = "select id , name , city , Experience  From Trainer ";
            SqlCommand cmd = new SqlCommand(cmdText, con);

            SqlDataReader reader =  cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Trainer t = new Trainer();
                    t.Id = (int) reader["ID"];
                    t.Name = reader["Name"].ToString();
                    t.City = reader["city"].ToString();
                    t.Experience = (int)reader["Experience"];

                    trainers.Add(t);
                }
            }
            con.Close();
            return trainers; 
        }



        // Select a trainer by id 

        //create a new Trainer

        //update exesting trainer  by id

        // delete to exesting trainer by id 
    }
}
