using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODotnetDemo
{
    internal class DisconnectEnvDemo
    {
        string conString =
            "Data Source=Lenovo_Ideapad\\SQLEXPRESS;Initial Catalog=sms;Integrated Security=True;";

        public void GetAllStudent()
        {
            SqlConnection sqlConnection = new SqlConnection(conString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Students", sqlConnection);
            // instanc eof data set
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Students");
            //foreach (DataRow row in dataSet.Tables["Students"].Rows)
            //{
            //    Console.WriteLine(
            //        $"Id: {row["StudentId"]}, " +
            //        $"Name: {row["Name"]}, " +
            //        $"Course: {row["Course"]}, " +
            //        $"Marks: {row["Marks"]}");
            //}
            foreach(DataRow row in dataSet.Tables["Students"].Rows) {

                Console.WriteLine(
                 $"Id: {row["StudentId"]}, " +
                   $"Name: {row["Name"]}, " +
                    $"Course: {row["Course"]}, " +
                    $"Marks: {row["Marks"]}"
                    );
            }
        }

        public void GetStudentById(int id) {
            SqlConnection sqlConnection = new SqlConnection(conString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Students", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Students");
            bool isStudentFound = false;

            for(int i=0;i< dataSet.Tables["Students"].Rows.Count; i++)
            {
                if (Convert.ToInt32(dataSet.Tables["Students"].Rows[i]["StudentId"]) == id)
                {
                    Console.WriteLine($"Students Id: {dataSet.Tables["Students"].Rows[i][0]} | Name: {dataSet.Tables["Students"].Rows[i][1]} | Course: {dataSet.Tables["Students"].Rows[i][2]} | Marks : {dataSet.Tables["Students"].Rows[i][3]}");
                    isStudentFound = true;
                }
            }
            if (!isStudentFound)
            {
                Console.WriteLine("Student Not Found");
            }
        }
    


public void AddNewStudent() {
            SqlConnection sqlConnection = new SqlConnection(conString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Students", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet, "Students");
            DataRow row = dataSet.Tables["Students"].NewRow();

            Console.WriteLine("Enter Student Details");
            Console.WriteLine("Enter Student Id");
            int studentId = Convert.ToInt32(Console.ReadLine());
            row[0] = studentId;

            Console.WriteLine("Enter Student Name");
            string studentName = Console.ReadLine();
            row[1] = studentName;

            Console.WriteLine("Enter Student Course");
            string studentCourse = Console.ReadLine();
            row[2] = studentName;

            Console.WriteLine("Enter Student Marks");
            int   studentMarks = Convert.ToInt32(Console.ReadLine());
            row[3] = studentMarks;

            dataSet.Tables["Students"].Rows.Add(row);

            //new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(dataSet, "Students");

            Console.WriteLine("Student Registered Successfully");




        }

        public void UpdateStudent() { }
    }
}
