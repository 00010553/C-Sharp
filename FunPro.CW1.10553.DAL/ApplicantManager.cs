using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW1._10553.DAL
{
    public class ApplicantManager : DbManager
    {
        public void Create(Applicant A)
        {
            var connection = Connection;
            try
            {
                var sql = $@"INSERT INTO ap_applicant (ap_name_10553, ap_score_10553, ap_tests_taken_10553) 
                            VALUES ('{A.ap_name_10553}',  '{A.ap_score_10553}', '{A.ap_tests_taken_10553}')";
                var comm = new SqlCeCommand(sql, connection);
                connection.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void Update(Applicant A)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                UPDATE ap_applicant SET 
                ap_name_10553 = '{A.ap_name_10553}',                  
                ap_score_10553 = '{A.ap_score_10553}', 
                ap_tests_taken_10553 = '{A.ap_tests_taken_10553}'
                WHERE ap_id_10553 = {A.ap_id_10553}";
                var comm = new SqlCeCommand(sql, connection);
                connection.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }

            }
        }

        public void Delete(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $"DELETE FROM ap_applicant WHERE ap_id_10553 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public Applicant GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                SELECT ap_id_10553, ap_name_10553,  ap_score_10553, ap_tests_taken_10553
                FROM ap_applicant
                WHERE ap_id_10553 = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var A = GetFromReader(reader);
                    return A;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return null;
        }

        public List<Applicant> GetAll()
        {
            var connection = Connection;
            var result = new List<Applicant>();
            try
            {
                var sql = "SELECT ap_id_10553, ap_name_10553,  ap_score_10553, ap_tests_taken_10553 FROM ap_applicant";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var A = GetFromReader(reader);
                    result.Add(A);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }

        private Applicant GetFromReader(SqlCeDataReader reader)
        {
            var A = new Applicant
            {
                ap_id_10553 = Convert.ToInt32(reader.GetValue(0)),
                ap_name_10553 = reader.GetValue(1).ToString(),
                ap_score_10553 = reader.GetValue(2).ToString(),
                ap_tests_taken_10553 = reader.GetValue(3).ToString()
            };
            return A;
        }
    }



}
