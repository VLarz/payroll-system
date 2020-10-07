using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace celes_and_lolit_Payroll_and_Attendance.Winforms
{
    public partial class Employee_Attendance : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; USERNAME = root; PASSWORD = ; DATABASE = celes_and_lolit-payroll");
        public Employee_Attendance()
        {
            InitializeComponent();

            txtTimeIn.Text = System.DateTime.Now.ToString("yyyy/MM/dd " + "07:30:00");
            txtTimeOut.Text = System.DateTime.Now.ToString("yyyy/MM/dd " + "16:30:00");
        }

        private void btnTimein_Click(object sender, EventArgs e)
        {
            string status ="";
            DateTime timeIn = Convert.ToDateTime(txtTimeIn.Text);
            DateTime dateNow = DateTime.Parse(" 07:45:59");
            if (timeIn > dateNow)
            {
                status = "Late";
            }
            else
            {
                status = "On Time";
            }

            try
            {
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "INSERT INTO attendance(employee_id, time_in, status) " +
                                   "VALUES (@id, @timeIn, @status)";
                scom.Parameters.AddWithValue("@id", "86931880Dela Cuesta");
                scom.Parameters.AddWithValue("@timeIn", txtTimeIn.Text);
                scom.Parameters.AddWithValue("@status", status);
                scom.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully Time In.", alert.AlertType.success);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimeout_Click(object sender, EventArgs e)
        {
            decimal hoursWorked = 0;
            decimal overtime = 0;
            decimal late = 0;
            decimal undertime = 0;

            //try
            //{
                conn.Open();
                MySqlCommand scom = conn.CreateCommand();
                scom.CommandText = "UPDATE attendance SET time_out = @timeOut " +
                                   "WHERE employee_id = @id AND DATE(time_in) = @dateNow";
                scom.Parameters.AddWithValue("@id", "86931880Dela Cuesta");
                scom.Parameters.AddWithValue("@timeOut", txtTimeOut.Text);
                scom.Parameters.AddWithValue("@dateNow", System.DateTime.Now.ToString("yyyy/MM/dd"));
                scom.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                MySqlCommand scom1 = conn.CreateCommand();
                scom1.CommandText = "SELECT TIMESTAMPDIFF(MINUTE,time_in, time_out) AS 'hoursWorked', " +
                                    "TIMESTAMPDIFF(MINUTE, (SELECT CONCAT(DATE(time_in), ' ', '16:30:00')), time_out) AS 'overtime'," +
                                    "TIMESTAMPDIFF(MINUTE, (SELECT CONCAT(DATE(time_in),' ','07:45:59')), time_in) AS 'late'," +
                                    "TIMESTAMPDIFF(MINUTE, time_out, (SELECT CONCAT(DATE(time_in),' ','16:25:00'))) AS 'undertime'" +
                                    "FROM attendance " +
                                    "WHERE id = 39 AND employee_id = '86931880Dela Cuesta'";
                scom1.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                MySqlDataReader sdr = scom1.ExecuteReader();

                while (sdr.Read())
                {
                    hoursWorked = Convert.ToDecimal(sdr["hoursWorked"].ToString());
                    overtime = Convert.ToDecimal(sdr["overtime"].ToString());
                    late = Convert.ToDecimal(sdr["late"].ToString());
                    undertime = Convert.ToDecimal(sdr["undertime"].ToString());

                }
                conn.Close();
                sdr.Close();

                decimal totalHourWorked;
                decimal totalOvertime;
                decimal totalLate;
                decimal totalUndertime;


                totalHourWorked = (hoursWorked - 60) / 60;

                if (overtime < 0)
                {
                    totalOvertime = 0;
                }
                else
                {
                    totalOvertime = overtime / 60;
                }
                
                if(late < 0)
                {
                    totalLate = 0;
                }
                else
                {
                    totalLate = late / 60;
                }

                if(undertime < 0)
                {
                    totalUndertime = 0;
                }
                else
                {
                    totalUndertime = undertime / 60;
                }

                conn.Open();
                MySqlCommand scom2 = conn.CreateCommand();
            scom2.CommandText = "INSERT INTO hour_work (date, employee_id, regular_hours, overtime, late, undertime) VALUES (@date, @id, @regHours, @ot, @late, @ut)";
                                    //"VALUES (@date, @id, @regHours, @ot, @late, @ut)";
                scom2.Parameters.AddWithValue("@date", System.DateTime.Now.ToString("yyyy/MM/dd"));
                scom2.Parameters.AddWithValue("@id", "86931880Dela Cuesta");
                scom2.Parameters.AddWithValue("@regHours", totalHourWorked);
                scom2.Parameters.AddWithValue("@ot", totalOvertime);
                scom2.Parameters.AddWithValue("@late", totalLate);
                scom2.Parameters.AddWithValue("@ut", totalUndertime);
                scom2.ExecuteNonQuery();
                conn.Close();
                alert.Show("Successfully Time Out.", alert.AlertType.success);


                decimal rate = 0;
                decimal totalRate = 0;
                decimal hour = 0;
                conn.Open();
                MySqlCommand scom3 = conn.CreateCommand();
                scom3.CommandText = "SELECT salary.rate " +
                                    "FROM employee " +
                                    "INNER JOIN salary " +
                                    "ON employee.salary_id = salary.id " +
                                    "WHERE employee.id = '86931880dasdad'";
                MySqlDataReader sdr1 = scom3.ExecuteReader();

                while (sdr1.Read())
                {
                    rate = Convert.ToDecimal(sdr1["rate"].ToString());
                }
                conn.Close();
                sdr1.Close();
            
            if (overtime >= 8)
            {
                hour = 8;
            }
            else if (totalHourWorked >= 7.50m && 7.99m >= totalHourWorked)
            {
                hour = 7.50m;
            }
            else if (totalHourWorked <= 7.49m && totalHourWorked >= 7)
            {
                hour = 7;
            }
            else if (totalHourWorked >= 6.50m && totalHourWorked <= 6.99m)
            {
                hour = 6.50m;
            }
            else if (totalHourWorked <= 6.49m && totalHourWorked >= 6)
            {
                hour = 6;
            }
            else if (totalHourWorked <= 5.50m && totalHourWorked >= 5.99m)
            {
                hour = 5.50m;
            }
            else if (totalHourWorked <= 5.49m && totalHourWorked >= 5)
            {
                hour = 5;
            }
            else if (totalHourWorked <= 4.50m && totalHourWorked >= 4.99m)
            {
                hour = 4.50m;
            }
            else if (totalHourWorked <= 4.49m && totalHourWorked >= 4)
            {
                hour = 4;
            }

            totalRate = hour * rate;

            //if (totalOvertime >= 1)
            //{
                
            //}
        //catch(Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}
    }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal hour = 0;
            //decimal totalHourWorked1 = Convert.ToDecimal(textBox1.Text);
            //if (totalHourWorked1 >= 8)
            //{
            //    hour = 8;
            //}
            //else if (totalHourWorked1 >= 7.50m && 7.99m >= totalHourWorked1)
            //{
            //    hour = 7.50m;
            //}
            //else if (totalHourWorked1 <= 7.49m && totalHourWorked1 >= 7)
            //{
            //    hour = 7;
            //}
            //else if (totalHourWorked1 >= 6.50m && totalHourWorked1 <= 6.99m)
            //{
            //    hour = 6.50m;
            //}
            //else if (totalHourWorked1 <= 6.49m && totalHourWorked1 >= 6)
            //{
            //    hour = 6;
            //}
            //else if (totalHourWorked1 <= 5.50m && totalHourWorked1 >= 5.99m)
            //{
            //    hour = 5.50m;
            //}
            //else if (totalHourWorked1 <= 5.49m && totalHourWorked1 >= 5)
            //{
            //    hour = 5;
            //}
            //else if (totalHourWorked1 <= 4.50m && totalHourWorked1 >= 4.99m)
            //{
            //    hour = 4.50m;
            //}
            //else if (totalHourWorked1 <= 4.49m && totalHourWorked1 >= 4)
            //{
            //    hour = 4;
            //}

            //label1.Text = Convert.ToString(hour);


            decimal salary = 100;
            int a = (int)Decimal.Truncate(Convert.ToDecimal(textBox1.Text));
            decimal totalOvertime = salary * a;
            label1.Text = totalOvertime.ToString();
        }
    }
}
