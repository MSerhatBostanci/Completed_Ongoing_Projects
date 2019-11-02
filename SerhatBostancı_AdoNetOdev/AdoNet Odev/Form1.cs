using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertRegion_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtRegionDescription.Text))
            {
                return;
            }
            #endregion

            SqlConnection cnn = new SqlConnection("server=tcp:DESKTOP-39N2HP5,1433;database=Northwind2;Trusted_Connection=true");

            SqlCommand cmd = new SqlCommand("insert into Region(RegionID,RegionDescription) values ((select top 1 RegionID from Region order by RegionID desc)+1 ,@RegionDescription)", cnn);

            cmd.Parameters.AddWithValue("@RegionDescription", txtRegionDescription.Text);



            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
            try
            {
                int ess = cmd.ExecuteNonQuery();
                txtRegionRowsAffected.Text = ess.ToString();
                
                if(ess>0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu");
            }
            finally
            {
                cnn.Close();
            }
        }

        private void btnInsertShippers_Click(object sender, EventArgs e)
        {
            #region Validation
            if ((string.IsNullOrWhiteSpace(txtShippersCompanyName.Text)) || (string.IsNullOrWhiteSpace(mtxtShipperPhone.Text)))
            {
                return;
            }
            #endregion

            SqlConnection cnn = new SqlConnection("server=tcp:DESKTOP-39N2HP5,1433;database=Northwind2;Trusted_Connection=true");

            SqlCommand cmd = new SqlCommand("insert into Shippers(CompanyName,Phone) values (@CompanyName,@Phone)", cnn);

            cmd.Parameters.AddWithValue("@CompanyName", txtShippersCompanyName.Text);
            cmd.Parameters.AddWithValue("@Phone", mtxtShipperPhone.Text);



            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
            try
            {
                int ess = cmd.ExecuteNonQuery();
                txtShippersRowsAffected.Text = ess.ToString();

                if (ess > 0)
                {
                    MessageBox.Show("Kayıt Başarılı");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir hata oluştu");
            }
            finally
            {
                cnn.Close();
            }

        }
    }
}
