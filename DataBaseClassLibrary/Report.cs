using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary
{
    public class Report : DataBase
    {
        // --- Variable and Proprty ---
        private int _reportID;
        public int ReportID
        {
            get { return _reportID; }
            set { _reportID = value; }
        }

        private int _reporterID;
        public int ReporterID
        {
            get { return _reporterID; }
            set { _reporterID = value; }
        }

        private int _healthSectorID;
        public int HealthSectorID
        {
            get { return _healthSectorID; }
            set { _healthSectorID = value; }
        }

        private string _reportType;
        public string ReportType
        {
            get { return _reportType; }
            set { _reportType = value; }
        }

        private int _epidemicWeek;
        public int EpidemicWeek
        {
            get { return _epidemicWeek; }
            set { _epidemicWeek = value; }
        }

        private DateTime _reportDate;
        public DateTime ReportDate
        {
            get { return _reportDate; }
            set { _reportDate = value; }
        }

        public string AddReport()
        {
            Cmd.CommandText = "AddReport";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@reportID", ReportID);
            Cmd.Parameters.AddWithValue("@reporterID", ReporterID);
            Cmd.Parameters.AddWithValue("@healthSectorID", HealthSectorID);
            Cmd.Parameters.AddWithValue("@reportType", ReportType);
            Cmd.Parameters.AddWithValue("@report_Date", ReportDate);
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

        public string UpdateReport()
        {
            Cmd.CommandText = "UpdateReport";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@reportID", ReportID);
            Cmd.Parameters.AddWithValue("@reporterID", ReporterID);
            Cmd.Parameters.AddWithValue("@healthSectorID", HealthSectorID);
            Cmd.Parameters.AddWithValue("@reportType", ReportType);
            Cmd.Parameters.AddWithValue("@report_Date", ReportDate);
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
