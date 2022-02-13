using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SahaBT_.NETTraining
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DHM8QBL\\SQLEXPRESS; Initial Catalog=SahaBT ; Integrated Security=True");
           
        void ulkeler()
        {
            SqlDataAdapter da = new SqlDataAdapter(" Select Distinct Country From KisiListesi ", con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            con.Open();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Country"]);
            }

            con.Close();
        }
        void griddoldur()
            { 
               
               SqlDataAdapter da = new SqlDataAdapter("Select *From KisiListesi", con);
               DataSet ds = new DataSet();
               con.Open();
               da.Fill(ds, "KisiListesi");
               dtgridAll.DataSource = ds.Tables["KisiListesi"];
               con.Close();
            }
        void Kadınlar()
        {
            SqlDataAdapter da = new SqlDataAdapter(" Select *From KisiListesi where Gender='Female' ", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "KisiListesi");
            dtGridF.DataSource = ds.Tables["KisiListesi"];
            con.Close();
        }
        void Erkekler()
        {
            SqlDataAdapter da = new SqlDataAdapter(" Select *From KisiListesi where Gender='Male' ", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "KisiListesi");
            dtGridM.DataSource = ds.Tables["KisiListesi"];
            con.Close();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
             griddoldur();
             Kadınlar();
             Erkekler();
            ulkeler();

            MessageBox.Show(" Merhaba...");
         
        }
          

       
        private void rdBtnErkek_CheckedChanged(object sender, EventArgs e)
        {
          
            
                if (comboBox1.SelectedIndex != -1 &&  rdBtnErkek.Checked == true)

                {
                    
                    SqlDataAdapter da = new SqlDataAdapter(" Select *From KisiListesi where Gender='Male' and Country =('" + comboBox1.SelectedItem.ToString() + "') ", con);
                    DataSet ds = new DataSet();
                    con.Open();
                    da.Fill(ds, "KisiListesi");
                    dtgridAll.DataSource = ds.Tables["KisiListesi"];
                    con.Close();
                }
             
        }
       
        private void rdBtnKadın_CheckedChanged(object sender, EventArgs e)
        {
         
             if (comboBox1.SelectedIndex!=-1 && rdBtnKadın.Checked == true  )
              {
                    SqlDataAdapter da = new SqlDataAdapter(" Select *From KisiListesi where Gender='Female' and Country =('" + comboBox1.SelectedItem.ToString() + "') ", con);
                    DataSet ds = new DataSet();
                    con.Open();
                    da.Fill(ds, "KisiListesi");
                    dtgridAll.DataSource = ds.Tables["KisiListesi"];
                    con.Close();
              }
    
        }

        private void rdBtnHerkes_CheckedChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex != -1 && rdBtnHerkes.Checked == true )
            {
                SqlDataAdapter da = new SqlDataAdapter("Select *From KisiListesi where Country =('" + comboBox1.SelectedItem.ToString() + "') ", con);
                DataSet ds = new DataSet();
                con.Open();
                da.Fill(ds, "KisiListesi");
                dtgridAll.DataSource = ds.Tables["KisiListesi"];
                con.Close();


            }
          
        }
    }
}
