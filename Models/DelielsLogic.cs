using MySql.Data.MySqlClient;    
using System;    
using System.Collections.Generic;    

namespace AllinDigitalTools.Models
{
    public class DelielLogicsModel
    {   
        public string ConnectionString { get; set; }

        public DelielLogicsModel(string connectionString)    
        {    
            this.ConnectionString = connectionString;    
        } 

        private MySqlConnection GetConnection()    
        {    
            return new MySqlConnection(ConnectionString);    
        }
        // fech data from database
        public List<DelielsModel> GetAllAlbums()  
        {  
            List<DelielsModel> list = new List<DelielsModel>();  
        
            using (MySqlConnection conn = GetConnection())  
            {  
                conn.Open();  
                MySqlCommand cmd = new MySqlCommand("select * from user where iduser < 10", conn);  
        
                using (var reader = cmd.ExecuteReader())  
                {  
                    while (reader.Read())  
                    {  
                        list.Add(new DelielsModel()  
                        {  
                            iduser = Convert.ToInt32(reader["iduser"]),  
                            Name = reader["Name"].ToString(),  
                            Age = Convert.ToInt32(reader["Age"]),  

                        });  
                    }  
                }  
            }  
            return list;  
        }

        public DelielsModel DelielsOne()
        {
            DelielsModel obj = new DelielsModel()
            {
                Name = "Mohammed Rahil",
                Age = 20,
            };
            return obj;
        }
    }
}
