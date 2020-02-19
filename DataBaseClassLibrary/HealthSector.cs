using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary
{
    public class HealthSector : DataBase
    {
        private int _healthSectorID;
        public int HealthSectorID
        {
            get { return _healthSectorID; }
            set { _healthSectorID = value; }
        }

        private int _healthSectorTypeID;
        public int HealthSectorTypeID
        {
            get { return _healthSectorTypeID; }
            set { _healthSectorTypeID = value; }
        }

        private int _healthRegionID;
        public int HealthRegionID
        {
            get { return _healthRegionID; }
            set { _healthRegionID = value; }
        }

        private int _referenceID;
        public int ReferenceID
        {
            get { return _referenceID; }
            set { _referenceID = value; }
        }

        private int _epidemicWeek;
        public int EpidemicWeek
        {
            get { return _epidemicWeek; }
            set { _epidemicWeek = value; }
        }

        private string _hsName;
        public string HSName
        {
            get { return _hsName; }
            set { _hsName = value; }
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

        private string _faxNumber;
        public string FaxNumber
        {
            get { return _faxNumber; }
            set { _faxNumber = value; }
        }

        private bool _reportCheck;
        public bool ReportCheck
        {
            get { return _reportCheck; }
            set { _reportCheck = value; }
        }


        //   ---Methods
        public DataTable ViewHealthSector()
        {
            DataTable dt = new DataTable();
            Cmd.CommandText = "ViewHealthSector";
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

        public DataTable ChartPatientDiseaseHR()
        {
            Cmd.Parameters.Clear();
            Cmd.CommandText = "ChartPatientDiseaseHR";
            Cmd.Parameters.AddWithValue("@healthRegionID", HealthRegionID);
            DataTable dt = new DataTable();
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
    }
}
