using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClassLibrary
{
    public class PatientFile : DataBase
    {
        // --- Variable and Proprty ---
        private int _patientFileID;
        public int PatientFileID
        {
            get { return _patientFileID; }
            set { _patientFileID = value; }
        }

        private int _diseaseID;
        public int DiseaseID
        {
            get { return _diseaseID; }
            set { _diseaseID = value; }
        }

        private int _nationalID;
        public int NationalID
        {
            get { return _nationalID; }
            set { _nationalID = value; }
        }

        private int _laboratoryID;
        public int LaboratoryID
        {
            get { return _laboratoryID; }
            set { _laboratoryID = value; }
        }

        private int _doctorID;
        public int DoctorID
        {
            get { return _doctorID; }
            set { _doctorID = value; }
        }

        private int _informerID;
        public int InformerID
        {
            get { return _informerID; }
            set { _informerID = value; }
        }

        private int _healthSector;
        public int HealthSector
        {
            get { return _healthSector; }
            set { _healthSector = value; }
        }

        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }

        private string _statusName;
        public string StatusName
        {
            get { return _statusName; }
            set { _statusName = value; }
        }

        private string _reason;
        public string Reason
        {
            get { return _reason; }
            set { _reason = value; }
        }

        private DateTime _dateRecivingReport;
        public DateTime DateRecivingReport
        {
            get { return _dateRecivingReport; }
            set { _dateRecivingReport = value; }
        }

        private DateTime _dateIllnessSymptoms;
        public DateTime DateIllnessSymptoms
        {
            get { return _dateIllnessSymptoms; }
            set { _dateIllnessSymptoms = value; }
        }

        private DateTime _dateRivision;
        public DateTime DateRivision
        {
            get { return _dateRivision; }
            set { _dateRivision = value; }
        }

        private bool _currentState;
        public bool CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; }
        }

        // --- Methods
        public string AddPatientFile()
        {
            Cmd.CommandText = "AddPatientFile";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@diseaseID", DiseaseID);
            Cmd.Parameters.AddWithValue("@nationalID", NationalID);
            Cmd.Parameters.AddWithValue("@laboratoryID", LaboratoryID);
            Cmd.Parameters.AddWithValue("@doctorID", DoctorID);
            Cmd.Parameters.AddWithValue("@informerID", InformerID);
            Cmd.Parameters.AddWithValue("@healthSector", HealthSector);
            Cmd.Parameters.AddWithValue("@HNotes", Notes);
            Cmd.Parameters.AddWithValue("@statusName", StatusName);
            Cmd.Parameters.AddWithValue("@reason", Reason);
            Cmd.Parameters.AddWithValue("@dateRecivingReport", DateRecivingReport);
            Cmd.Parameters.AddWithValue("@dateIllnessSymptoms", DateIllnessSymptoms);
            Cmd.Parameters.AddWithValue("@dateRivision", DateRivision);
            Cmd.Parameters.AddWithValue("@currentState", CurrentState);
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
        public DataTable ViewAllPatientFiles()
        {
            DataTable dt = new DataTable();
            Cmd.CommandText = "ViewAllPatientFiles";
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
            Cmd.CommandText = "UpdatePatientFile";
            Cmd.Parameters.Clear();
            Cmd.Parameters.AddWithValue("@patientFileID", PatientFileID);
            Cmd.Parameters.AddWithValue("@diseaseID", DiseaseID);
            Cmd.Parameters.AddWithValue("@nationalID", NationalID);
            Cmd.Parameters.AddWithValue("@laboratoryID", LaboratoryID);
            Cmd.Parameters.AddWithValue("@doctorID", DoctorID);
            Cmd.Parameters.AddWithValue("@informerID", InformerID);
            Cmd.Parameters.AddWithValue("@healthSector", HealthSector);
            Cmd.Parameters.AddWithValue("@HNotes", Notes);
            Cmd.Parameters.AddWithValue("@statusName", StatusName);
            Cmd.Parameters.AddWithValue("@reason", Reason);
            Cmd.Parameters.AddWithValue("@dateRecivingReport", DateRecivingReport);
            Cmd.Parameters.AddWithValue("@dateIllnessSymptoms", DateIllnessSymptoms);
            Cmd.Parameters.AddWithValue("@dateRivision", DateRivision);
            Cmd.Parameters.AddWithValue("@currentState", CurrentState);
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

        public DataTable ChartPatientDiseaseHS()
        {
            Cmd.Parameters.Clear();
            Cmd.CommandText = "ChartPatientDiseaseHS";
            Cmd.Parameters.AddWithValue("@healthSectorID", HealthSector);
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
