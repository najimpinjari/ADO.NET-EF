using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdO.net
{
    public class TrainerDb
    {
        //select all Trainers   

        public void AllTrainers(out List<Trainer> trainers , out List<Student> students)
        {
            #region selecting record from one table 


            List<Trainer> trainers = new List<Trainer>();
            string connectionString = "Data Source=DESKTOP-LQCK449\\SQLEXPRESS;Initial Catalog=ADODOTNET;Integrated Security=true;";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string cmdText = "select id , name , city , Experience  From Trainer ";
            SqlCommand cmd = new SqlCommand(cmdText, con);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Trainer t = new Trainer();
                    t.Id = (int)reader["ID"];
                    t.Name = reader["Name"].ToString();
                    t.City = reader["city"].ToString();
                    t.Experience = (int)reader["Experience"];

                    trainers.Add(t);
                }
            }
            con.Close();
            return trainers;
            #endregion selecting record from one table 

            #region slelecting record from two tables 

            trainers = new list<trainer>();
            students = new list<student>();

            string connectionstring = "data source=desktop-lqck449\\sqlexpress;initial catalog=adodotnet;integrated security=true;";
            sqlconnection connection = new sqlconnection(connectionstring);


            string cmdtext = "select id, name , city , experience from trainer;select rollnumber, name , gender, trainerid from student";
            sqlcommand cmd = new sqlcommand(cmdtext, connection);

            connection.open();

            sqldatareader reader = cmd.executereader();

            while (reader.read())
            {
                trainer t = new trainer()
                {
                    id = (int)reader["id"],
                    name = reader["name"].tostring(),
                    city = reader["city"].tostring(),
                    experience = (int)reader["experience"]
                };

                trainers.add(t);
            }

            reader.nextresult();

            while (reader.read())
            {
                student st = new student()
                {
                    rollnumber = (int)reader["rollnumber"],
                    name = reader["name"].tostring(),
                    gender = reader["gender"].tostring(),
                    trainerid = (int)reader["trainerid"]
                };
                students.add(st);
            }

            connection.close();


            #endregion slelecting record from two tables 

            #region SELECTING RECRORD FROM TWO TABLE USING SQL ADAPTER 

            trainers = new List<Trainer>(); // for assigning perpus
            students = new List<Student>();

            //connection string 
            string connectionString = "Data Source=DESKTOP-LQCK449\\SQLEXPRESS;Initial Catalog=ADODOTNET;Integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            // we create an object for connection string 

            string cmdtext = "select Id, Name , City , Experience from Trainer;select RollNumber, Name , Gender, TrainerId from Student";
            SqlDataAdapter adp = new SqlDataAdapter(cmdtext, con);  
            // we create a object for adapter same and its overlod class thats whay we add cammand (cmdtext)
            //and connection string 

            DataSet ds = new DataSet();
            adp.Fill(ds);

            if(ds !=  null && ds.Tables.Count > 0) 
            {
                if (ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {
                    for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                      var row =  ds.Tables[0].Rows[i];
                        Trainer t = new Trainer()
                        {
                            Id = (int)row["ID"],
                            Name = row["Name"].ToString(),
                            City = row["City"].ToString(),
                            Experience = (int)row["Experience"]
                        };

                        trainers.Add(t);
                    }
                }

                if (ds.Tables[1] != null && ds.Tables[1].Rows.Count > 0)
                {
                    for(int i = 0; i < ds.Tables[1].Rows.Count; i++) 
                    {
                        var row = ds.Tables[1].Rows[i];

                        Student s = new Student()
                        {
                            RollNumber = (int)row["Rollnumber"],
                            Name = row["Name"].ToString(),
                            Gender = row["Gender"].ToString(),
                            City = row["City"].ToString()
                        };l
                    }

                }
            }

            #endregion SELECTING RECRORD FROM TWO TABLE USING SQL ADAPTER 


        }



        // Select a trainer by id 

        //create a new Trainer

        //update exesting trainer  by id

        // delete to exesting trainer by id 
    }
}
