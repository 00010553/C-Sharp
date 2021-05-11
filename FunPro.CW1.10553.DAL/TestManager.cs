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
    public class TestManager: DbManager
    {
        public void Create(Test t)
        {
            var connection = Connection;
            try
            {
                var sql = $@"INSERT INTO 
                ts_tests( ts_name_10553, ts_q1_10553, ts_q1_answer_10553 , ts_q2_10553, ts_q2_answer_10553, ts_q3_10553, ts_q3_answer_10553)
                VALUES
                ('{t.ts_name_10553}','{t.ts_q1_10553}', '{t.ts_q1_answer_10553}', '{t.ts_q2_10553}', '{t.ts_q2_answer_10553}', '{t.ts_q3_10553}', '{t.ts_q3_answer_10553}')";
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

        public void Update(Test t)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                UPDATE ts_tests SET
                ts_name_10553 = '{t.ts_name_10553}', 
                ts_q1_10553 = '{t.ts_q1_10553 }',  
                ts_q1_answer_10553  = '{t.ts_q1_answer_10553}', 
                ts_q2_10553  = '{t.ts_q2_10553}'
                ts_q2_answer_10553  = '{t.ts_q2_answer_10553}',
                ts_q3_10553  = '{t.ts_q3_10553}',
                ts_q3_answer_10553  = '{t.ts_q3_answer_10553}',
                WHERE ts_id_10553 = {t.ts_id_10553}";
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
                var sql = $"DELETE FROM ts_tests WHERE ts_id_10553 = {id}";
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

        public Test GetById(int id)
        {
            var connection = Connection;
            try
            {
                var sql = $@"
                SELECT ts_id_10553, ts_name_10553, ats_q1_10553, ts_q1_answer_10553 , ts_q2_10553, ts_q2_answer_10553, ts_q3_10553, ts_q3_answer_10553 FROM ts_tests
                WHERE ts_id_10553 = {id}";
                var comm = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = comm.ExecuteReader();
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

        public List<Test> GetAll()
        {
            var connection = Connection;
            var result = new List<Test>();
            try
            {
                var sql = "SELECT ts_id_10553, ts_name_10553, ts_q1_10553, ts_q1_answer_10553 , ts_q2_10553, ts_q2_answer_10553, ts_q3_10553, ts_q3_answer_10553 FROM ts_tests";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var t = GetFromReader(reader);
                    result.Add(t);
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

        private Test GetFromReader(SqlCeDataReader reader)
        {
            var t = new Test
            {
                ts_id_10553 = Convert.ToInt32(reader.GetValue(0)),
                ts_name_10553 = reader.GetValue(1).ToString(),
                ts_q1_10553 = reader.GetValue(2).ToString(),
                ts_q1_answer_10553 = reader.GetValue(3).ToString(),
                ts_q2_10553 = reader.GetValue(4).ToString(),
                ts_q2_answer_10553 = reader.GetValue(5).ToString(),
                ts_q3_10553 = reader.GetValue(6).ToString(),
                ts_q3_answer_10553 = reader.GetValue(7).ToString(),
            };
            return t;
        }

    }
}
