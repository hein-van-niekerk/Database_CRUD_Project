using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PRG252_Assignment2_Milestone1
{
    internal class DataHandler
    {
        public DataHandler() { }

        SqlConnection conn = new SqlConnection("Data Source=(local); Initial Catalog= PatientsDB; Integrated Security= SSPI");
        SqlCommand command;
        SqlDataReader reader;

        Student myStudent = new Student();
        Module myModule = new Module();

        public void Register(int sNumber,string sName,string sSurname,Image sPicture,DateTime sDoB,string sGender,string sPhoneNumber,string sAddress, string mCode, string mName, string mDescription, string mResources)
        {

            string insertString = @"INSERT INTO Students(// insert column names please) VALUES(@sNumber,@sName,@sSurname,@sPicture,@sDoB,@sGender,@sPhoneNumber,@sAddress,@mCode,@mName,@mDescription,@mResources)";
            SqlCommand insertcmd = new SqlCommand(insertString, conn);
            conn.Open();
            insertcmd.Parameters.Add("@sNumber", SqlDbType.Int).Value = sNumber;
            insertcmd.Parameters.Add("@sName", SqlDbType.VarChar).Value = sName;
            insertcmd.Parameters.Add("@sSurname", SqlDbType.VarChar).Value = sSurname;
            insertcmd.Parameters.Add("@sPicture", SqlDbType.Image).Value = sPicture;
            insertcmd.Parameters.Add("@sDoB", SqlDbType.Date).Value = sDoB;
            insertcmd.Parameters.Add("@sGender", SqlDbType.VarChar).Value = sGender;
            insertcmd.Parameters.Add("@sPhoneNumber", SqlDbType.VarChar).Value = sPhoneNumber;
            insertcmd.Parameters.Add("@sAddress", SqlDbType.VarChar).Value = sAddress;
            insertcmd.Parameters.Add("@mCode", SqlDbType.VarChar).Value = mCode;
            insertcmd.Parameters.Add("@mName", SqlDbType.VarChar).Value = mName;
            insertcmd.Parameters.Add("@mDescription", SqlDbType.VarChar).Value = mDescription;
            insertcmd.Parameters.Add("@mResources", SqlDbType.VarChar).Value = mResources;

            insertcmd.ExecuteReader();
            MessageBox.Show("Data written succesfully");
            conn.Close();
        }

        public void Delete(int sNumber)
        {
            string query = @"DELETE FROM Students WHERE StudentNumber = ('" + sNumber + "')";
            conn.Open();
            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Details have been deleted");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not find student");

            }
            finally
            {
                conn.Close();
            }
        }

        public List<Student> Search(int sNumber)
        {
            string query = @"SELECT FROM Students WHERE StudentNumber = ('" + sNumber + "')";

            conn.Open();
            command = new SqlCommand(query, conn);

            List<Student> studentList = new List<Student>();

            try
            {
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    myStudent.StudentNumber = int.Parse(reader[0].ToString());
                    myStudent.StudentName = reader[1].ToString();
                    myStudent.StudentSurname = reader[2].ToString();
                    //CONTINUE HERE WITH ALL FIELDS



                    studentList.Add(new Student(myStudent.StudentNumber, myStudent.StudentName, myStudent.StudentPicture,myStudent.DoB1, myStudent.StudentGender, myStudent.PhoneNumber, myStudent.Address));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not find student in database");

            }
            finally
            {
                conn.Close();
            }
            return studentList;
        }

        public void Update(int sNumber, string sName, string sSurname, Image sPicture, DateTime sDoB, string sGender, string sPhoneNumber, string sAddress, string mCode, string mName, string mDescription, string mResources)
        {
            string query = @"UPDATE Students SET StudentNumber = ('" + sNumber + "'),FirstName = ('" + sName + "'),LastName = ('" + sSurname + "'),StudentPicture = ('" + sPicture + "'),DateOfBirth = ('" + sDoB + "'),Gender = ('" + sGender + "'),PhoneNumber = ('" + sPhoneNumber + "'),Address = ('" + sAddress + "')";
            conn.Open();
            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Details have been updated");
            }
            catch (Exception)
            {
                MessageBox.Show("Details could not be updated");

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
