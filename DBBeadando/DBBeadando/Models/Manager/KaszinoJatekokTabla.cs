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

        public int Delete(Jatekok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM jatekok WHERE asztalkod = :aszalkod"
            };

            OracleParameter asztalkodParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":asztalkod",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Asztalkod
            };
            command.Parameters.Add(asztalkodParameter);

            command.Connection = oc;
            command.Transaction = ot;

            int affectedRows = 0;
            try
            {
                affectedRows = command.ExecuteNonQuery();
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }
            oc.Close();

            return affectedRows;
        }

        public int Insert(Jatekok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_KaszinoJatekok"
            };

            OracleParameter asztalkodParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_asztalkod",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Asztalkod
            };
            command.Parameters.Add(asztalkodParameter);

            OracleParameter jatekasztalneveParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_jatekasztalneve",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Jatekasztalneve
            };
            command.Parameters.Add(jatekasztalneveParameter);

            OracleParameter gyartoParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_gyarto",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Gyarto
            };
            command.Parameters.Add(gyartoParameter);

            OracleParameter asztallimitParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_asztallimit",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Asztallimit
            };
            command.Parameters.Add(asztallimitParameter);

            OracleParameter krupieParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_krupie",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Krupie
            };
            command.Parameters.Add(krupieParameter);

            OracleParameter asztal_datumaParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_asztal_datuma",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Asztal_datuma
            };
            command.Parameters.Add(asztal_datumaParameter);

            OracleParameter jatektipusaParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_jatektipusa",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Jatektipusa
            };
            command.Parameters.Add(jatektipusaParameter);

            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };

            command.Connection = oc;
            command.Transaction = ot;

            oc.Close();

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
                ot.Commit();
                return affectedRows;
            }
            catch (Exception)
            {
                ot.Rollback();
                return 0;
            }

        }

        public bool CheckAsztalkod(string asztalkod)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_asztalkod"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter asztalkodParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_asztalkod",
                Direction = System.Data.ParameterDirection.Input,
                Value = asztalkod
            };

            command.Parameters.Add(asztalkodParameter);

            command.Connection = oc;
            oc.Close();

            try
            {
                int successful = int.Parse(correct.Value.ToString());
                return successful != 0;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}

