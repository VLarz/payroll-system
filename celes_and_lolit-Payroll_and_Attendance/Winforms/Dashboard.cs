using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;
namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Dashboard : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORd = ; DATABASe = marj_hardware");
        public Dashboard()
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(pnlGraph, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnlCard1, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnlCard2, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnlCard3, 5);
            Bunifu.Framework.Lib.Elipse.Apply(pnlCard4, 5);
            //showGraphStockLevel();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
        //private void showGraphStockLevel()
        //{
        //    ColumnSeries col = new ColumnSeries()
        //    {
        //        Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)),
        //        DataLabels = true,
        //        Values = new ChartValues<int>(),
        //        LabelPoint = point => point.Y.ToString()
        //    };

        //    Axis ax = new Axis()
        //    {
        //        Separator = new Separator()
        //        {
        //            Step = 1,
        //            IsEnabled = false
        //        },
        //        LabelsRotation = 20


        //    };
        //    ax.Labels = new List<string>();
        //    cartesianChart1.Zoom = ZoomingOptions.X;
        //    conn.Open();
        //    MySqlCommand scom = conn.CreateCommand();
        //    scom.CommandText = "SELECT * FROM product WHERE reorder > stocks ORDER BY stocks ASC LIMIT 20";
        //    MySqlDataReader dr = scom.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        int getStocks = Convert.ToInt32(dr["stocks"].ToString());
        //        string getNames = dr["name"].ToString();
        //        col.Values.Add(getStocks);
        //        ax.Labels.Add(getNames);
        //    }
        //    conn.Close();

        //    cartesianChart1.Series.Add(col);
        //    cartesianChart1.AxisX.Add(ax);

        //    cartesianChart1.AnimationsSpeed = TimeSpan.FromMilliseconds(2000);
        //    cartesianChart1.AxisY.Add(new Axis
        //    {
        //        LabelFormatter = value => value + " Stock(s)",
        //        Separator = new Separator()
        //    });

        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
