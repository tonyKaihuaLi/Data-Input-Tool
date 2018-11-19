using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataImport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenFiles_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.textFilePath.Text = ofd.FileName;

                ImportData(ofd.FileName);

                MessageBox.Show("succeed");
            }
        }

        private void ImportData(string ofdFileName)
        {
            string temp = string.Empty;
            //File.ReadAllLines();
            using (StreamReader reader=new StreamReader(ofdFileName,Encoding.Default))
            {
                reader.ReadLine(); //delete first line
                string connectStr = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;//"server = LIKAIHUA-SURFAC;uid = sa;pwd = 123456;database = 0413DB";
            

                using (SqlConnection conn = new SqlConnection(connectStr))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        while (!string.IsNullOrEmpty(temp = reader.ReadLine()))
                        {
                            //Console.WriteLine(temp);
                            var strs = temp.Split(',');
                            string sql = string.Format("insert into StuInfo(stuName,stuGender, stuBirthDate,stuPhoneNumber) values ('{0}','{1}','{2}','{3}')",strs[1],strs[2],strs[3],strs[4]);
                          
                            cmd.CommandText=sql;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
