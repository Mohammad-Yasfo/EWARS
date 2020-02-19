using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary
{
    public class Patient : DataBase
    {
        // --- Variable and Proprty ---
        private int _nationalID;
        public int NationalID
        {
            get { return _nationalID; }
            set { _nationalID = value; }
        }

        private string _fname;
        public string FName
        {
            get { return _fname; }
            set { _fname = value; }
        }

        private string _lname;
        public string LName
        {
            get { return _lname; }
            set { _lname = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private bool _gender;
        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private bool _marriedState;
        public bool MarriedState
        {
            get { return _marriedState; }
            set { _marriedState = value; }
        }

        // --- Methods
        public string AddPatient()
        {
            Cmd.CommandText = "AddPatient";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@nationalID", NationalID);
            Cmd.Parameters.AddWithValue("@fname", FName);
            Cmd.Parameters.AddWithValue("@lname", LName);
            Cmd.Parameters.AddWithValue("@age", Age);
            Cmd.Parameters.AddWithValue("@address", Address);
            Cmd.Parameters.AddWithValue("@gender", Gender);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@marriedState", MarriedState);
            try
            {
                Cn.Open();
                Cmd.ExecuteNonQuery();
                Cn.Close();

                return "تمت الاضافة بنجاح";
            }
            catch (Exception e1)
            {
                if (Cn.State == ConnectionState.Open) { Cn.Close(); }
                return e1.Message;
            }
        }

        public DataTable ViewPatient()
        {
            DataTable dt = new DataTable();
            Cmd.CommandText = "ViewPatientInfo";

            try
            {
                Cn.Open();
                rdr = Cmd.ExecuteReader();
                dt.Load(rdr);
                Cn.Close();
                return dt;
            }
            catch (Exception e1)
            {
                if (Cn.State == ConnectionState.Open)
                    Cn.Close();
                dt.Columns.Add(e1.Message);
                return dt;

            }
        }

        public string UpdatePatient()
        {
            Cmd.CommandText = "UpdatePatient";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@nationalID", NationalID);
            Cmd.Parameters.AddWithValue("@fname", FName);
            Cmd.Parameters.AddWithValue("@lname", LName);
            Cmd.Parameters.AddWithValue("@age", Age);
            Cmd.Parameters.AddWithValue("@address", Address);
            Cmd.Parameters.AddWithValue("@gender", Gender);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@marriedState", MarriedState);
            try
            {
                Cn.Open();
                Cmd.ExecuteNonQuery();
                Cn.Close();

                return "تمت التعديل بنجاح";
            }
            catch (Exception e1)
            {
                if (Cn.State == ConnectionState.Open) { Cn.Close(); }
                return e1.Message;
            }
        }
    }
}
