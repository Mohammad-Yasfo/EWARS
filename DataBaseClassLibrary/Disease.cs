using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary
{
    public class Disease : DataBase
    {
        private int _diseaseID;
        public int DiseaseID
        {
            get { return _diseaseID; }
            set { _diseaseID = value; }
        }

        private string _nameAR;
        public string NameAR
        {
            get{ return _nameAR; }
            set{ _nameAR = value; }
        }

        private string _nameEN;
        public string NameEN
        {
            get { return _nameEN; }
            set { _nameEN = value; }
        }

        private string _symbol;
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }

        private string _describtion;
        public string Describtion
        {
            get { return _describtion; }
            set { _describtion = value; }
        }

        private string _symptoms;
        public string Symptoms
        {
            get { return _symptoms; }
            set { _symptoms = value; }
        }

        private float _warningBorder;
        public float WarningBorder
        {
            get { return _warningBorder; }
            set { _warningBorder = value; }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        private bool _instantDisease;
        public bool InstantDisease
        {
            get { return _instantDisease; }
            set { _instantDisease = value; }
        }

        public string AddDisease()
        {
            Cmd.CommandText = "AddDisease";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@namear", NameAR);
            Cmd.Parameters.AddWithValue("@nameen", NameEN);
            Cmd.Parameters.AddWithValue("@symbol", Symbol);
            Cmd.Parameters.AddWithValue("@describtion", Describtion);
            Cmd.Parameters.AddWithValue("@symptoms", Symptoms);
            Cmd.Parameters.AddWithValue("@warningborder", WarningBorder);
            Cmd.Parameters.AddWithValue("@notes", Notes);
            Cmd.Parameters.AddWithValue("@instantDisease", InstantDisease);
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

        public DataTable ViewDisease()
        {
            DataTable dt = new DataTable();
            Cmd.CommandText = "ViewDisease";

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

        public string UpdateDisease()
        {
            Cmd.CommandText = "UpdateDisease";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@diseaseID", DiseaseID);
            Cmd.Parameters.AddWithValue("@namear", NameAR);
            Cmd.Parameters.AddWithValue("@nameen", NameEN);
            Cmd.Parameters.AddWithValue("@symbol", Symbol);
            Cmd.Parameters.AddWithValue("@describtion", Describtion);
            Cmd.Parameters.AddWithValue("@symptoms", Symptoms);
            Cmd.Parameters.AddWithValue("@warningborder", WarningBorder);
            Cmd.Parameters.AddWithValue("@notes", Notes);
            Cmd.Parameters.AddWithValue("@instantDisease", InstantDisease);
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
