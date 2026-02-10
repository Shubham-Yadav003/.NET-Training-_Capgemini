using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADODotnetDemo
{
    internal class ConnectedEnvDemo
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader dataReader;

        string ConString =
            "Data Source=Lenovo_Ideapad\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True;";

        
        public void GetAllStudent()
        {
            try
            {
                connection = new SqlConnection(ConString);
                connection.Open();
                Console.WriteLine("Connection Opened");

                cmd = new SqlCommand("SELECT * FROM Students", connection);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(
                        $"Id: {dataReader["StudentId"]}, " +
                        $"Name: {dataReader["Name"]}, " +
                        $"Course: {dataReader["Course"]}, " +
                        $"Marks: {dataReader["Marks"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                    Console.WriteLine("Connection Closed");
                }
            }
        }

       
        public void GetStudentById(int id)
        {
            try
            {
                string sql = $"SELECT * FROM Students WHERE StudentId = {id}";
                connection = new SqlConnection(ConString);
                connection.Open();

                cmd = new SqlCommand(sql, connection);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(
                        $"Id: {dataReader["StudentId"]}, " +
                        $"Name: {dataReader["Name"]}, " +
                        $"Course: {dataReader["Course"]}, " +
                        $"Marks: {dataReader["Marks"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        
        public void GetStudentByCourseName(string course)
        {
            try
            {
                string sql = $"SELECT * FROM Students WHERE Course = '{course}'";
                connection = new SqlConnection(ConString);
                connection.Open();

                cmd = new SqlCommand(sql, connection);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(
                        $"Id: {dataReader["StudentId"]}, " +
                        $"Name: {dataReader["Name"]}, " +
                        $"Course: {dataReader["Course"]}, " +
                        $"Marks: {dataReader["Marks"]}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

       
        public void AddNewStudent(int id, string name, string course, int marks)
        {
            try
            {
                string sql =
                    $"INSERT INTO Students VALUES({id}, '{name}', '{course}', {marks})";

                connection = new SqlConnection(ConString);
                connection.Open();

                cmd = new SqlCommand(sql, connection);
                int cnt = cmd.ExecuteNonQuery();

                Console.WriteLine($"{cnt} record(s) inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert failed: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        
        public void UpdateStudent(int id, string name, string course, int marks, int studentId)
        {
            try
            {
                string sql =
                    $"UPDATE Students SET StudentId={id}, Name='{name}', Course='{course}', Marks={marks} " +
                    $"WHERE StudentId={studentId}";

                connection = new SqlConnection(ConString);
                connection.Open();

                cmd = new SqlCommand(sql, connection);
                int cnt = cmd.ExecuteNonQuery();

                Console.WriteLine($"{cnt} record(s) updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update failed: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void Delete(int id)
        {
            try
            {
                string sql = $"DELETE FROM Students WHERE StudentId = {id}";
                connection = new SqlConnection(ConString);
                connection.Open();

                cmd = new SqlCommand(sql, connection);
                int cnt = cmd.ExecuteNonQuery();

                Console.WriteLine($"{cnt} record(s) deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete failed: " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
