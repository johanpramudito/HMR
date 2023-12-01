using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Security.Cryptography;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;

namespace HealthMedicalRecords
{
    public partial class Dashboard : Form
    {
        private readonly string _googleApikey = "AIzaSyDntjfCzzHjB3GD9SbT1nLkS_EEeiA8Tc8";
        private readonly RestClient _client = new RestClient("https://maps.googleapis.com/");
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            lblAddPatient.ForeColor = System.Drawing.Color.Red;
            lblDiagnosis.ForeColor = System.Drawing.Color.Black;
            lblHistory.ForeColor = System.Drawing.Color.Black;

            panelNewPatient.Visible = true;
            panelAddInfo.Visible = false;
            panelFullHistory.Visible = false;
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            lblAddPatient.ForeColor = System.Drawing.Color.Black;
            lblDiagnosis.ForeColor = System.Drawing.Color.Red;
            lblHistory.ForeColor = System.Drawing.Color.Black;

            panelAddInfo.Visible = true;
            panelNewPatient.Visible = false;
            panelFullHistory.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            lblAddPatient.ForeColor = System.Drawing.Color.Black;
            lblDiagnosis.ForeColor = System.Drawing.Color.Black;
            lblHistory.ForeColor = System.Drawing.Color.Red;

            panelFullHistory.Visible = true;
            panelNewPatient.Visible = false;
            panelAddInfo.Visible = false;


            SqlCommand cmd = SQLConnection();

            cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelNewPatient.Visible = false;
            panelAddInfo.Visible = false;
            panelFullHistory.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String address = comboAddress.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboGender.Text;
                String blood = txtBlood.Text;
                String disease = txtAny.Text;
                int PID = Convert.ToInt32(txtPID.Text);


                SqlCommand cmd = SQLConnection();

                cmd.CommandText = "insert into AddPatient values ('" + name + "','" + address + "'," + contact + "," + age + ",'" + gender + "','"
                    + blood + "','" + disease + "'," + PID + ")";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Format or PID");
            }

            MessageBox.Show("Patient Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            comboAddress.ResetText();
            txtContact.Clear();
            txtAge.Clear();
            txtBlood.Clear();
            txtAny.Clear();
            txtPID.Clear();
            comboGender.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtPIDAddInfo.Text != "")
            {
                int PID = Convert.ToInt32(txtPIDAddInfo.Text);
                SqlCommand cmd = SQLConnection();
                cmd.CommandText = "select * from AddPatient where PID = " + PID + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int PID = Convert.ToInt32(txtPIDAddInfo.Text);
                String symptoms = txtBxSymptoms.Text;
                String diagnosis = txtBxDiagnosis.Text;
                String medicines = txtBxMedicines.Text;
                String ward = comboBxWard.Text;
                String wardType = comboBxWardType.Text;

                SqlCommand cmd = SQLConnection();

                cmd.CommandText = "insert into PatientMore values (" + PID + ",'" +
                    symptoms + "','" + diagnosis + "','" + medicines + "','" + ward + "','" + wardType + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Data Format or PID");
            }

            MessageBox.Show("Info Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPIDAddInfo.Clear();
            txtBxSymptoms.Clear();
            txtBxDiagnosis.Clear();
            txtBxMedicines.Clear();
            comboBxWard.ResetText();
            comboBxWardType.ResetText();

        }

        // Refactoring
        private static SqlCommand SQLConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=tcp:emrserver.database.windows.net,1433;Initial Catalog=Hospital;Persist Security Info=False;User ID=melvin;Password=Johan123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            return cmd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private int caretPosition;
        private DateTime lastTextChangedTime = DateTime.MinValue;
        private TimeSpan debounceDelay = TimeSpan.FromMilliseconds(500);

        private void comboAddress_TextChanged(object sender, EventArgs e)
        {
            lastTextChangedTime = DateTime.Now;

            Task.Delay(debounceDelay).ContinueWith(_ =>
            {
                if (DateTime.Now - lastTextChangedTime >= debounceDelay)
                {
                    BeginInvoke(new Action(() =>
                    {
                        if (computeSuggestions.IsBusy || string.IsNullOrEmpty(comboAddress.Text))
                            return;

                        caretPosition = comboAddress.SelectionStart;

                        computeSuggestions.RunWorkerAsync(comboAddress.Text);
                    }));
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void computeSuggestions_DoWork(object sender, DoWorkEventArgs e)
        {
            string input = e.Argument.ToString();

            try
            {
                var request = new RestRequest($"maps/api/place/autocomplete/json?input={input}&key={_googleApikey}");
                string response = _client.Execute(request).Content;

                if (response != null)
                {
                    AutoCompleteSimplified deserializedResponse = JsonConvert.DeserializeObject<AutoCompleteSimplified>(response);
                    e.Result = deserializedResponse;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                e.Result = ex;
            }
        }

        private void computeSuggestions_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception)
            {
                MessageBox.Show(@"Error fetching suggestions. ", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AutoCompleteSimplified deserializedResponse = (AutoCompleteSimplified)e.Result;

            if (deserializedResponse != null && deserializedResponse.Predictions != null && deserializedResponse.Predictions.Any())
            {
                comboAddress.Items.Clear();
                comboAddress.Items.AddRange(deserializedResponse.Predictions.Select(prediction => prediction.Description).ToArray());
            }

            comboAddress.Select(caretPosition, 0);

        }
    }
}
