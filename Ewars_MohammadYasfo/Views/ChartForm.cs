using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ewars.Views
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {

            // Data arrays.
            string[] seriesArray1 = { "Spinal Muscular Atrophy","Systemic Mastocytosis", "Acute Flaccid Paralysis", "Severe Acute Respiratory Infection", "Influenza Like Illness", "Acute Jaundice Syndrome", "Acute Watery Diarrhoea", "Diarrhoea with Blood(Dysentery)" , "Acute Diarrhoea" };
            int[] pointsArray1 = { 30, 15, 8, 25, 40, 10, 2, 5, 10 };
            // Set palette.
            this.chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            this.chart1.Titles.Add("نسبة الأمراض في المنطقة الصحية الأولى ");

            // Add series.
            for (int i = 0; i < seriesArray1.Length; i++)
            {
                // Add series.
                Series series = this.chart1.Series.Add(seriesArray1[i]);

                // Add point.
                series.Points.Add(pointsArray1[i]);
            }



            string[] seriesArray2 = { "مركز جبرين", "مركز المالكية", "مركز النيرب الاسعافي", "مركز شيخ نجار", "مركز شيخ زيات", "مركز الهلال الفلسطيني", "مركز النيرب الصحي"};
            int[] pointsArray2 = { 56, 15, 8, 25, 40, 10, 30};

            this.chart2.Palette = ChartColorPalette.Bright;
            
            this.chart2.Titles.Add("الاحصائية في منطقة الصحية الثالثة");

            for (int i = 0; i < seriesArray2.Length; i++)
            {

                Series series = this.chart2.Series.Add(seriesArray2[i]);

                series.Points.Add(pointsArray2[i]);
            }



            string[] seriesArray3 = { "المنطقة الصحية الاولى", "المنطقة الصحية الثانية ", "المنطقة الصحية الثالثة", "المنطقة الصحية الرابعة", "منطقة السفيرة", "منطقة منبج ", "منطقة الاتارب"};
            int[] pointsArray3 = { 30, 15, 8, 25, 40, 50, 10 };

            this.chart3.Palette = ChartColorPalette.Fire;

            this.chart3.Titles.Add("الاحصائية المصابين بمرض الأنفلونزا بحسب المنطقة الصحية");

            for (int i = 0; i < seriesArray3.Length; i++)
            {

                Series series = this.chart3.Series.Add(seriesArray3[i]);
                series.Points.Add(pointsArray3[i]);
            }


            string[] seriesArray4 = { "م.حلب الجامعي", "م.الشهباء", "م.الرجاء", "م.الأطفال", "مركز حلب الجديدة", "تألف الحمدانية", "م.المستقبل"};
            int[] pointsArray4 = { 50, 15, 8, 25, 20, 30, 3 };

            this.chart4.Palette = ChartColorPalette.SeaGreen;

            this.chart4.Titles.Add("الاحصائية المصابين بمرض الاسهال المدمى بحسب المنطقة الصحية");

            for (int i = 0; i < seriesArray4.Length; i++)
            {

                Series series = this.chart4.Series.Add(seriesArray4[i]);

                series.Points.Add(pointsArray4[i]);
            }
        }
    }
}
