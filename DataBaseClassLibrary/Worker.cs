using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary
{
    public class Worker : DataBase
    {
        // --- Variable and Proprty ---
        private int _workerID;
        public int WorkerID
        {
            get { return _workerID; }
            set { _workerID = value; }
        }

        private int _workTypeID;
        public int WorkTypeID
        {
            get { return _workTypeID; }
            set { _workTypeID = value; }
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

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
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


        // --- Methods
        public string AddWorker()
        {
            Cmd.CommandText = "AddWorker";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@workerTypeID", WorkerID);
            Cmd.Parameters.AddWithValue("@fname", FName);
            Cmd.Parameters.AddWithValue("@lname", LName);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@address", Address);
            Cmd.Parameters.AddWithValue("@gender", Gender);
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

        public DataTable ViewWorker()
        {
            DataTable dt = new DataTable();
            Cmd.CommandText = "ViewWorker";

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

        public string UpdateWorker()
        {
            Cmd.CommandText = "UpdateWorker";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@workerTypeID", WorkerID);
            Cmd.Parameters.AddWithValue("@fname", FName);
            Cmd.Parameters.AddWithValue("@lname", LName);
            Cmd.Parameters.AddWithValue("@phone", Phone);
            Cmd.Parameters.AddWithValue("@address", Address);
            Cmd.Parameters.AddWithValue("@gender", Gender);
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
