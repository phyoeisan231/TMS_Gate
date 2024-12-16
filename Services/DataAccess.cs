using System;
using System.Data.SQLite;
using System.IO;
using TMS_Gate.Models;

namespace TMS_Gate.Services
{
    public static class DataAccess
    {
        public static ResponseMessage AddGateInData(string inputText)
        {
            ResponseMessage msg = new ResponseMessage();
            // Ensure that the connection string is correctly fetched
            string dbpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GateDB.db");
            if (!File.Exists(dbpath))
            {
                msg.Status = false;
                msg.MessageContent = "Database file does not exist.";
                return msg;
            }

            using (var db = new SQLiteConnection($"Data Source={dbpath}"))
            {
                try
                {
                    db.Open();

                    var insertCommand = new SQLiteCommand();
                    insertCommand.Connection = db;

                    // Use parameterized query to prevent SQL injection attacks
                    insertCommand.CommandText = "INSERT INTO GateIn  VALUES (2,@Entry);";
                    insertCommand.Parameters.AddWithValue("@Entry", inputText);

                    insertCommand.ExecuteNonQuery();  // Use ExecuteNonQuery for insert/update commands

                    msg.Status = true;
                    msg.MessageContent = "Successfully saved!";
                }
                catch (Exception ex)
                {
                    msg.Status = false;
                    msg.MessageContent = $"Error: {ex.Message}";
                }
            }

            return msg;
        }

    }
}
