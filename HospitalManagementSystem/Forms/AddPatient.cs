using System;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace HospitalManagementSystem.Windows
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtName.Text) == true)
            {
                MessageBox.Show("Name field cannot be empty!");
            }
            else
            {
                try
                {
                    DataAccess access = new DataAccess();
                    string insertPatientQuery = "begin insertPatient(:p1, :p2, :p3, :p4, :p5, :p6, :p7); end;";

                    OracleCommand command = new OracleCommand(
                       insertPatientQuery, access.Connection);
                    

                    command.Parameters.Add("p1", OracleDbType.Varchar2).Value = txtName.Text;
                    command.Parameters.Add("p2", OracleDbType.Varchar2).Value = cmbGender.Text.ToString();
                    command.Parameters.Add("p3", OracleDbType.Varchar2).Value = txtAge.Text;
                    command.Parameters.Add("p4", OracleDbType.Varchar2).Value = txtDgn.Text;
                    command.Parameters.Add("p5", OracleDbType.Varchar2).Value = txtDocId.Text;
                    command.Parameters.Add("p6", OracleDbType.Varchar2).Value = txtRoom.Text;
                    command.Parameters.Add("p7", OracleDbType.Varchar2).Value = txtBill.Text;

                    int rowsUpdated = command.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not inserted");
                    }
                    else
                    {
                        MessageBox.Show("Successfully inserted new patient!");
                    }

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadDoctor(string doctorName, string doctorID)
        {
            txtDocId.Text = doctorID;
            try
            {
                
                txtDocName.Text = doctorName;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
