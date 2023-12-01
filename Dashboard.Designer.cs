namespace HealthMedicalRecords
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnAddPatient;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnHistory = new Button();
            btnAddDiagnosis = new Button();
            lblAddPatient = new Label();
            lblDiagnosis = new Label();
            lblHistory = new Label();
            panelNewPatient = new Panel();
            comboAddress = new ComboBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            btnSave = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboGender = new ComboBox();
            txtPID = new TextBox();
            txtAny = new TextBox();
            txtBlood = new TextBox();
            txtAge = new TextBox();
            txtContact = new TextBox();
            txtName = new TextBox();
            label9 = new Label();
            panelAddInfo = new Panel();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox9 = new PictureBox();
            button1 = new Button();
            comboBxWardType = new ComboBox();
            label16 = new Label();
            comboBxWard = new ComboBox();
            label18 = new Label();
            txtBxMedicines = new TextBox();
            label15 = new Label();
            txtBxDiagnosis = new TextBox();
            label14 = new Label();
            txtBxSymptoms = new TextBox();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            txtPIDAddInfo = new TextBox();
            label12 = new Label();
            label11 = new Label();
            panelFullHistory = new Panel();
            FullHistory = new Label();
            dataGridView2 = new DataGridView();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            computeSuggestions = new System.ComponentModel.BackgroundWorker();
            btnAddPatient = new Button();
            panelNewPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelAddInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFullHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = Color.Transparent;
            btnAddPatient.FlatStyle = FlatStyle.Flat;
            btnAddPatient.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddPatient.ForeColor = Color.White;
            btnAddPatient.Image = (Image)resources.GetObject("btnAddPatient.Image");
            btnAddPatient.Location = new Point(46, 360);
            btnAddPatient.Margin = new Padding(2);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(223, 31);
            btnAddPatient.TabIndex = 1;
            btnAddPatient.Text = "Add New Patient Record";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Transparent;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = (Image)resources.GetObject("btnHistory.Image");
            btnHistory.Location = new Point(599, 360);
            btnHistory.Margin = new Padding(2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(224, 31);
            btnHistory.TabIndex = 7;
            btnHistory.Text = "Full History of Patient";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnAddDiagnosis
            // 
            btnAddDiagnosis.BackColor = Color.Transparent;
            btnAddDiagnosis.FlatStyle = FlatStyle.Flat;
            btnAddDiagnosis.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddDiagnosis.ForeColor = Color.White;
            btnAddDiagnosis.Image = (Image)resources.GetObject("btnAddDiagnosis.Image");
            btnAddDiagnosis.Location = new Point(321, 360);
            btnAddDiagnosis.Margin = new Padding(2);
            btnAddDiagnosis.Name = "btnAddDiagnosis";
            btnAddDiagnosis.Size = new Size(224, 31);
            btnAddDiagnosis.TabIndex = 8;
            btnAddDiagnosis.Text = "Add Diagnosis Information";
            btnAddDiagnosis.UseVisualStyleBackColor = false;
            btnAddDiagnosis.Click += btnAddDiagnosis_Click;
            // 
            // lblAddPatient
            // 
            lblAddPatient.AutoSize = true;
            lblAddPatient.Location = new Point(25, 367);
            lblAddPatient.Margin = new Padding(2, 0, 2, 0);
            lblAddPatient.Name = "lblAddPatient";
            lblAddPatient.Size = new Size(17, 15);
            lblAddPatient.TabIndex = 9;
            lblAddPatient.Text = "⬤";
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.AutoSize = true;
            lblDiagnosis.Location = new Point(300, 367);
            lblDiagnosis.Margin = new Padding(2, 0, 2, 0);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(17, 15);
            lblDiagnosis.TabIndex = 10;
            lblDiagnosis.Text = "⬤";
            // 
            // lblHistory
            // 
            lblHistory.AccessibleRole = AccessibleRole.None;
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(578, 367);
            lblHistory.Margin = new Padding(2, 0, 2, 0);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(17, 15);
            lblHistory.TabIndex = 11;
            lblHistory.Text = "⬤";
            // 
            // panelNewPatient
            // 
            panelNewPatient.Controls.Add(comboAddress);
            panelNewPatient.Controls.Add(pictureBox8);
            panelNewPatient.Controls.Add(pictureBox7);
            panelNewPatient.Controls.Add(pictureBox6);
            panelNewPatient.Controls.Add(pictureBox5);
            panelNewPatient.Controls.Add(pictureBox4);
            panelNewPatient.Controls.Add(pictureBox3);
            panelNewPatient.Controls.Add(pictureBox2);
            panelNewPatient.Controls.Add(label10);
            panelNewPatient.Controls.Add(btnSave);
            panelNewPatient.Controls.Add(label8);
            panelNewPatient.Controls.Add(label7);
            panelNewPatient.Controls.Add(label6);
            panelNewPatient.Controls.Add(label5);
            panelNewPatient.Controls.Add(label4);
            panelNewPatient.Controls.Add(label3);
            panelNewPatient.Controls.Add(label2);
            panelNewPatient.Controls.Add(comboGender);
            panelNewPatient.Controls.Add(txtPID);
            panelNewPatient.Controls.Add(txtAny);
            panelNewPatient.Controls.Add(txtBlood);
            panelNewPatient.Controls.Add(txtAge);
            panelNewPatient.Controls.Add(txtContact);
            panelNewPatient.Controls.Add(txtName);
            panelNewPatient.Controls.Add(label9);
            panelNewPatient.Location = new Point(11, 7);
            panelNewPatient.Margin = new Padding(2);
            panelNewPatient.Name = "panelNewPatient";
            panelNewPatient.Size = new Size(827, 349);
            panelNewPatient.TabIndex = 14;
            // 
            // comboAddress
            // 
            comboAddress.BackColor = SystemColors.GradientInactiveCaption;
            comboAddress.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboAddress.FormattingEnabled = true;
            comboAddress.Location = new Point(181, 83);
            comboAddress.Margin = new Padding(2);
            comboAddress.Name = "comboAddress";
            comboAddress.Size = new Size(603, 23);
            comboAddress.TabIndex = 42;
            comboAddress.TextChanged += comboAddress_TextChanged;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Gray;
            pictureBox8.Location = new Point(50, 340);
            pictureBox8.Margin = new Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(649, 1);
            pictureBox8.TabIndex = 41;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Gray;
            pictureBox7.Location = new Point(50, 292);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(729, 1);
            pictureBox7.TabIndex = 40;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Gray;
            pictureBox6.Location = new Point(181, 231);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(602, 1);
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Gray;
            pictureBox5.Location = new Point(181, 165);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(602, 1);
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gray;
            pictureBox4.Location = new Point(181, 135);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(602, 1);
            pictureBox4.TabIndex = 37;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Location = new Point(182, 105);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(602, 1);
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.Location = new Point(182, 77);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(602, 1);
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkOliveGreen;
            label10.Location = new Point(313, 15);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(205, 20);
            label10.TabIndex = 33;
            label10.Text = "Add New Patient Record";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(720, 315);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(68, 29);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(45, 247);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(230, 17);
            label8.TabIndex = 30;
            label8.Text = "Any Major Disease Suffered Before";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(45, 212);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 29;
            label7.Text = "Blood Group";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(45, 142);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 17);
            label6.TabIndex = 28;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 116);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 27;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 177);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 26;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 87);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 17);
            label3.TabIndex = 25;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 24;
            label2.Text = "Name";
            // 
            // comboGender
            // 
            comboGender.BackColor = SystemColors.GradientInactiveCaption;
            comboGender.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female" });
            comboGender.Location = new Point(181, 175);
            comboGender.Margin = new Padding(2);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(603, 23);
            comboGender.TabIndex = 23;
            // 
            // txtPID
            // 
            txtPID.BackColor = SystemColors.GradientInactiveCaption;
            txtPID.BorderStyle = BorderStyle.None;
            txtPID.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPID.Location = new Point(50, 321);
            txtPID.Margin = new Padding(2);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(649, 16);
            txtPID.TabIndex = 22;
            // 
            // txtAny
            // 
            txtAny.BackColor = SystemColors.GradientInactiveCaption;
            txtAny.BorderStyle = BorderStyle.None;
            txtAny.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAny.Location = new Point(50, 273);
            txtAny.Margin = new Padding(2);
            txtAny.Name = "txtAny";
            txtAny.Size = new Size(734, 16);
            txtAny.TabIndex = 21;
            // 
            // txtBlood
            // 
            txtBlood.BackColor = SystemColors.GradientInactiveCaption;
            txtBlood.BorderStyle = BorderStyle.None;
            txtBlood.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBlood.Location = new Point(181, 212);
            txtBlood.Margin = new Padding(2);
            txtBlood.Name = "txtBlood";
            txtBlood.Size = new Size(603, 16);
            txtBlood.TabIndex = 20;
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.GradientInactiveCaption;
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAge.Location = new Point(181, 144);
            txtAge.Margin = new Padding(2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(603, 16);
            txtAge.TabIndex = 19;
            // 
            // txtContact
            // 
            txtContact.BackColor = SystemColors.GradientInactiveCaption;
            txtContact.BorderStyle = BorderStyle.None;
            txtContact.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(181, 116);
            txtContact.Margin = new Padding(2);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(603, 16);
            txtContact.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.GradientInactiveCaption;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(181, 59);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(603, 16);
            txtName.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(45, 299);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 17);
            label9.TabIndex = 31;
            label9.Text = "Patient ID";
            // 
            // panelAddInfo
            // 
            panelAddInfo.Controls.Add(pictureBox10);
            panelAddInfo.Controls.Add(pictureBox11);
            panelAddInfo.Controls.Add(pictureBox13);
            panelAddInfo.Controls.Add(pictureBox9);
            panelAddInfo.Controls.Add(button1);
            panelAddInfo.Controls.Add(comboBxWardType);
            panelAddInfo.Controls.Add(label16);
            panelAddInfo.Controls.Add(comboBxWard);
            panelAddInfo.Controls.Add(label18);
            panelAddInfo.Controls.Add(txtBxMedicines);
            panelAddInfo.Controls.Add(label15);
            panelAddInfo.Controls.Add(txtBxDiagnosis);
            panelAddInfo.Controls.Add(label14);
            panelAddInfo.Controls.Add(txtBxSymptoms);
            panelAddInfo.Controls.Add(label13);
            panelAddInfo.Controls.Add(dataGridView1);
            panelAddInfo.Controls.Add(txtPIDAddInfo);
            panelAddInfo.Controls.Add(label12);
            panelAddInfo.Controls.Add(label11);
            panelAddInfo.Location = new Point(11, 7);
            panelAddInfo.Margin = new Padding(2);
            panelAddInfo.Name = "panelAddInfo";
            panelAddInfo.Size = new Size(827, 349);
            panelAddInfo.TabIndex = 34;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Gray;
            pictureBox10.Location = new Point(567, 182);
            pictureBox10.Margin = new Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(245, 1);
            pictureBox10.TabIndex = 44;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Gray;
            pictureBox11.Location = new Point(567, 157);
            pictureBox11.Margin = new Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(245, 1);
            pictureBox11.TabIndex = 43;
            pictureBox11.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Gray;
            pictureBox13.Location = new Point(567, 131);
            pictureBox13.Margin = new Padding(2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(245, 1);
            pictureBox13.TabIndex = 42;
            pictureBox13.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Gray;
            pictureBox9.Location = new Point(567, 107);
            pictureBox9.Margin = new Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(245, 1);
            pictureBox9.TabIndex = 36;
            pictureBox9.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(739, 303);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(73, 34);
            button1.TabIndex = 19;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBxWardType
            // 
            comboBxWardType.BackColor = SystemColors.GradientInactiveCaption;
            comboBxWardType.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBxWardType.FormattingEnabled = true;
            comboBxWardType.Items.AddRange(new object[] { "General", "Duo", "Single", "None" });
            comboBxWardType.Location = new Point(567, 259);
            comboBxWardType.Margin = new Padding(2);
            comboBxWardType.Name = "comboBxWardType";
            comboBxWardType.Size = new Size(245, 24);
            comboBxWardType.TabIndex = 18;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(435, 262);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(94, 17);
            label16.TabIndex = 17;
            label16.Text = "Type of Ward";
            // 
            // comboBxWard
            // 
            comboBxWard.BackColor = SystemColors.GradientInactiveCaption;
            comboBxWard.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBxWard.FormattingEnabled = true;
            comboBxWard.Items.AddRange(new object[] { "Yes", "No" });
            comboBxWard.Location = new Point(567, 221);
            comboBxWard.Margin = new Padding(2);
            comboBxWard.Name = "comboBxWard";
            comboBxWard.Size = new Size(245, 24);
            comboBxWard.TabIndex = 16;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(435, 227);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(116, 17);
            label18.TabIndex = 15;
            label18.Text = "Ward Required ?";
            // 
            // txtBxMedicines
            // 
            txtBxMedicines.BackColor = SystemColors.GradientInactiveCaption;
            txtBxMedicines.BorderStyle = BorderStyle.None;
            txtBxMedicines.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMedicines.Location = new Point(567, 163);
            txtBxMedicines.Margin = new Padding(2);
            txtBxMedicines.Name = "txtBxMedicines";
            txtBxMedicines.Size = new Size(245, 16);
            txtBxMedicines.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(435, 164);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(71, 17);
            label15.TabIndex = 8;
            label15.Text = "Medicines";
            // 
            // txtBxDiagnosis
            // 
            txtBxDiagnosis.BackColor = SystemColors.GradientInactiveCaption;
            txtBxDiagnosis.BorderStyle = BorderStyle.None;
            txtBxDiagnosis.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxDiagnosis.Location = new Point(567, 136);
            txtBxDiagnosis.Margin = new Padding(2);
            txtBxDiagnosis.Name = "txtBxDiagnosis";
            txtBxDiagnosis.Size = new Size(245, 16);
            txtBxDiagnosis.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(435, 139);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(70, 17);
            label14.TabIndex = 6;
            label14.Text = "Diagnosis";
            // 
            // txtBxSymptoms
            // 
            txtBxSymptoms.BackColor = SystemColors.GradientInactiveCaption;
            txtBxSymptoms.BorderStyle = BorderStyle.None;
            txtBxSymptoms.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxSymptoms.Location = new Point(567, 112);
            txtBxSymptoms.Margin = new Padding(2);
            txtBxSymptoms.Name = "txtBxSymptoms";
            txtBxSymptoms.Size = new Size(245, 16);
            txtBxSymptoms.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(435, 113);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(76, 17);
            label13.TabIndex = 4;
            label13.Text = "Symptom's";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, 0);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(422, 349);
            dataGridView1.TabIndex = 3;
            // 
            // txtPIDAddInfo
            // 
            txtPIDAddInfo.BackColor = SystemColors.GradientInactiveCaption;
            txtPIDAddInfo.BorderStyle = BorderStyle.None;
            txtPIDAddInfo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPIDAddInfo.Location = new Point(567, 87);
            txtPIDAddInfo.Margin = new Padding(2);
            txtPIDAddInfo.Name = "txtPIDAddInfo";
            txtPIDAddInfo.Size = new Size(245, 16);
            txtPIDAddInfo.TabIndex = 2;
            txtPIDAddInfo.TextChanged += textBox1_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(435, 88);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(69, 17);
            label12.TabIndex = 1;
            label12.Text = "Patient ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkOliveGreen;
            label11.Location = new Point(515, 15);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(212, 40);
            label11.TabIndex = 0;
            label11.Text = "Adding More Information \r\nAbout Patient";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFullHistory
            // 
            panelFullHistory.Controls.Add(FullHistory);
            panelFullHistory.Controls.Add(dataGridView2);
            panelFullHistory.Location = new Point(11, 7);
            panelFullHistory.Margin = new Padding(2);
            panelFullHistory.Name = "panelFullHistory";
            panelFullHistory.Size = new Size(827, 349);
            panelFullHistory.TabIndex = 20;
            // 
            // FullHistory
            // 
            FullHistory.AutoSize = true;
            FullHistory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            FullHistory.ForeColor = Color.DarkOliveGreen;
            FullHistory.Location = new Point(300, 5);
            FullHistory.Margin = new Padding(2, 0, 2, 0);
            FullHistory.Name = "FullHistory";
            FullHistory.Size = new Size(207, 24);
            FullHistory.TabIndex = 1;
            FullHistory.Text = "Full History of Patient";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 40);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(827, 301);
            dataGridView2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(827, 346);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.close_icon1;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(805, 7);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(33, 33);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // computeSuggestions
            // 
            computeSuggestions.DoWork += computeSuggestions_DoWork;
            computeSuggestions.RunWorkerCompleted += computeSuggestions_RunWorkerCompleted;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(846, 397);
            Controls.Add(button2);
            Controls.Add(panelAddInfo);
            Controls.Add(panelFullHistory);
            Controls.Add(panelNewPatient);
            Controls.Add(btnHistory);
            Controls.Add(pictureBox1);
            Controls.Add(lblHistory);
            Controls.Add(lblDiagnosis);
            Controls.Add(lblAddPatient);
            Controls.Add(btnAddDiagnosis);
            Controls.Add(btnAddPatient);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Dashboard";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panelNewPatient.ResumeLayout(false);
            panelNewPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelAddInfo.ResumeLayout(false);
            panelAddInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFullHistory.ResumeLayout(false);
            panelFullHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnHospitalInfo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnAddPatient;
        private Button btnHistory;
        private Button btnAddDiagnosis;
        private Label lblAddPatient;
        private Label lblDiagnosis;
        private Label lblHistory;
        private Panel panelNewPatient;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboGender;
        private TextBox txtPID;
        private TextBox txtAny;
        private TextBox txtBlood;
        private TextBox txtAge;
        private TextBox txtContact;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Button btnSave;
        private Panel panelAddInfo;
        private Label label12;
        private Label label11;
        private TextBox txtBxMedicines;
        private Label label15;
        private TextBox txtBxDiagnosis;
        private Label label14;
        private TextBox txtBxSymptoms;
        private Label label13;
        private TextBox txtPIDAddInfo;
        private Button button1;
        private ComboBox comboBxWardType;
        private Label label16;
        private ComboBox comboBxWard;
        private Label label18;
        private Panel panelFullHistory;
        private Label FullHistory;
        private DataGridView dataGridView2;
        private Button button2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox13;
        private DataGridView dataGridView1;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
        private ComboBox comboAddress;
        private System.ComponentModel.BackgroundWorker computeSuggestions;
    }
}