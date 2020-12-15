using DBBeadando.Models.Records;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBeadando.Models.Manager
{
    class KaszinoJatekokTabla
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;User Id=Q4NGPR;Password=EKE2020;";
            oc.ConnectionString = connectionString;
            return oc;
        }

        public List<Jatekok> Select()
        {
            List<Jatekok> records = new List<Jatekok>();
            OracleConnection oc = new OracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT k.nev, j.asztalkod, j.jatekasztalneve,j.gyarto,j.asztallimit,j.asztal_datuma,j.jatektipusa FROM jatekok j INNER JOIN krupiek i ON k_id = j.krupie_id"
            };
            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Jatekok jatek = new Jatekok();
                jatek.Asztalkod = reader["asztalkod"].ToString();
                jatek.Jatekasztalneve = reader["jatekasztalneve"].ToString();
                jatek.Gyarto = reader["gyarto"].ToString();
                jatek.Jatektipusa = reader["jatektipusa"].ToString();

                records.Add(jatek);
            }
            oc.Close();

            return records;
        }
    }
}
