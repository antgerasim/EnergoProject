using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace OboronEnergoProject {

   public partial class Form1 : Form {

      private int clientsId;
      private string company_name;
      private DateTime dtFrom;
      private DateTime dtTo;
      private string middleName;
      private string name;
      private ReportDataSource rdts1;
      private string surname;
      private string type;

      public Form1() { InitializeComponent(); }

      private void Form1_Load(object sender, EventArgs e) { }

      private void reportViewer1_Load(object sender, EventArgs e) {
         rdts1 = new ReportDataSource("DataSet1", DataTable1BindingSource);
      }

      private void btnCreateReport_Click(object sender, EventArgs e) {

         initFields();

         if (type == "natural") {
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource =
               "OboronEnergoProject.Natural.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdts1);
            DataTable1TableAdapter.FillNatural(DataSet1.DataTable1, type, dtFrom,
               dtTo, clientsId, surname, name, middleName);
            reportViewer1.RefreshReport();
         }
         else if (type == "legal") {
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource =
               "OboronEnergoProject.Legal.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdts1);

            DataTable1TableAdapter.FillLegal(DataSet1.DataTable1, type, dtFrom,
               dtTo, clientsId, company_name);
            reportViewer1.RefreshReport();
         }
      }

      private void btnShowAllRP_Click(object sender, EventArgs e) {

         initFields();

         if (type == "natural") {
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource =
               "OboronEnergoProject.Natural.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdts1);
            DataTable1TableAdapter.FillAllNatural(DataSet1.DataTable1, dtFrom,
               dtTo);
            reportViewer1.RefreshReport();
         }
         else if (type == "legal") {

            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource =
               "OboronEnergoProject.Legal.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rdts1);
            DataTable1TableAdapter.FillAllLegal(DataSet1.DataTable1, dtFrom,
               dtTo);
            reportViewer1.RefreshReport();
         }

      }

      private void btnSignIn_Click(object sender, EventArgs e) {

         try {
            if (tryLogin(txtUsername.Text, txtPassword.Text, txtHost.Text)) {
               btnSignIn.Text = "Connected";
               rbNP.Enabled = true;
               rbLP.Enabled = true;
               reportViewer1.Enabled = true;
            }
            else {
               MessageBox.Show("Wrong login or password - access denied");
               btnSignIn.Text = "Sign In";
               rbNP.Enabled = false;
               rbLP.Enabled = false;
               reportViewer1.Enabled = false;
            }
         }
         catch (Exception ex) {
            MessageBox.Show(ex.Message);
         }
      }

      private bool tryLogin(string lgn, string pass, string host) {

         string connectionstring = "server=" + txtHost.Text
                                   + ";User Id=dbadmin;password=dbadmin;database=energodb";

         MySqlConnection con = new MySqlConnection(connectionstring);
         MySqlCommand cmd =
            new MySqlCommand(
               "SELECT * FROM employee WHERE user_name= '" + lgn
               + "' AND user_pass='" + pass + "'", con);
         con.Open();
         //add try catch if MySQLException occours

         //a DataReader allows to use results get from the command and execute
         //a command against the connection we signed to

         MySqlDataReader reader = cmd.ExecuteReader();

         if (reader.Read() == true) { //DataReader successfully read

            //if result is equal to null, login and password were wrong
            if (reader.IsDBNull(0)) {
               cmd.Connection.Close();
               reader.Dispose();
               cmd.Dispose();

               return false;
            }
               //close conn in both case after checking for creds

            else {
               cmd.Connection.Close();
               reader.Dispose();
               cmd.Dispose();

               return true;
            }
         }
            //else is used just in case anything is wrong with the reader
         else
            return false;
      }

      private void rbNP_CheckedChanged_1(object sender, EventArgs e) {
         btnCreateReport.Enabled = true;
         btnShowAllRP.Enabled = true;
         gbLP.Enabled = false;
         gbNP.Enabled = true;
         type = "natural";
         //MessageBox.Show(type);
      }

      private void rbLP_CheckedChanged_1(object sender, EventArgs e) {
         btnCreateReport.Enabled = true;
         btnShowAllRP.Enabled = true;
         gbLP.Enabled = true;
         gbNP.Enabled = false;
         type = "legal";

      }

      private void initFields() {

         company_name = txtCompanyName.Text;
         surname = txtSurname.Text;
         name = txtName.Text;
         middleName = txtMiddleName.Text;

         if (type == "natural") {

            if (!string.IsNullOrWhiteSpace(txtNPID.Text)) {
               clientsId = Convert.ToInt32(txtNPID.Text);
            }
         }
         else if (type == "legal") {
            if (!string.IsNullOrWhiteSpace(txtLPID.Text)) {
               clientsId = Convert.ToInt32(txtLPID.Text);
            }
         }

         if (rbNP.Checked) {
            dtFrom = dtPickerNPFrom.Value;
            dtTo = dtPickerNPTo.Value;
         }

         else if (rbLP.Checked) {
            dtFrom = dtPickerLPFrom.Value;
            dtTo = dtPickerLPTo.Value;
         }
      }

      private void txtCompanyName_TextChanged(object sender, EventArgs e) {
         txtLPID.Enabled = string.IsNullOrEmpty(txtCompanyName.Text);
         clientsId = 0;


      }

      private void txtLPID_TextChanged(object sender, EventArgs e) {
         txtCompanyName.Enabled = string.IsNullOrEmpty(txtLPID.Text);
         company_name = "";

      }

      private void txtSurname_TextChanged(object sender, EventArgs e)
      {
         txtNPID.Enabled = string.IsNullOrEmpty(txtSurname.Text);
         clientsId = 0;
      }

      private void txtName_TextChanged(object sender, EventArgs e)
      {
         txtNPID.Enabled = string.IsNullOrEmpty(txtName.Text);
         clientsId = 0;
      }

      private void txtMiddleName_TextChanged(object sender, EventArgs e)
      {
         txtNPID.Enabled = string.IsNullOrEmpty(txtMiddleName.Text);
         clientsId = 0;
      }

      private void txtNPID_TextChanged(object sender, EventArgs e)
      {
         txtSurname.Enabled = string.IsNullOrEmpty(txtNPID.Text);
         surname = "";
         txtName.Enabled = string.IsNullOrEmpty(txtNPID.Text);
         name = "";
         txtMiddleName.Enabled = string.IsNullOrEmpty(txtNPID.Text);
         middleName = "";
      }
   }
}


