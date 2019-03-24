using System;
using System.Collections.Generic;
using sensei_api.Models;
using Npgsql;
using System.Data;

namespace sensei_api.Ado
{     
    public class DB_Util   
    {   
        string connString = "Host=tad;Port=5432;Username=postgres;Database=tadpgweb";

        public List<License> getLicenses()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                List<License> lsLicense = new List<License>();

                using (var cmd = new NpgsqlCommand("select id, description,	user_number, storage_limit,	creation_date from sensei.license", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lsLicense.Add(new License
                        {
                            id = Convert.ToInt32(reader["id"]),
                            description = reader["description"].ToString(),
                            user_number = Convert.ToInt32(reader["user_number"]),
                            storage_limit = Convert.ToInt32(reader["storage_limit"]),
                            creation_date = Convert.ToDateTime(reader["creation_date"])
                        });
                    }
                }

                return lsLicense;
            }
        }
        
    }

}


