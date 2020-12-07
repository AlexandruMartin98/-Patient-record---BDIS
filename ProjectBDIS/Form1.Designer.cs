namespace ProjectBDIS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPatient = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabAddDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateTimePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.tabModify = new System.Windows.Forms.TabPage();
            this.btnModify = new System.Windows.Forms.Button();
            this.dateTimePickerModify = new System.Windows.Forms.DateTimePicker();
            this.tbAgeModify = new System.Windows.Forms.TextBox();
            this.tbAddressModify = new System.Windows.Forms.TextBox();
            this.tbLastNameModify = new System.Windows.Forms.TextBox();
            this.tbFirstNameModify = new System.Windows.Forms.TextBox();
            this.tbCNPModify = new System.Windows.Forms.TextBox();
            this.labelAgeModify = new System.Windows.Forms.Label();
            this.labelBirthDateModify = new System.Windows.Forms.Label();
            this.labelAddressModify = new System.Windows.Forms.Label();
            this.labelLastNameModify = new System.Windows.Forms.Label();
            this.labelFirstNameModify = new System.Windows.Forms.Label();
            this.labelCNPModify = new System.Windows.Forms.Label();
            this.tabFind = new System.Windows.Forms.TabPage();
            this.tbFind3 = new System.Windows.Forms.TextBox();
            this.tbFind2 = new System.Windows.Forms.TextBox();
            this.tbFind1 = new System.Windows.Forms.TextBox();
            this.labelFind3 = new System.Windows.Forms.Label();
            this.labelFind2 = new System.Windows.Forms.Label();
            this.labelFind1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPerson = new ProjectBDIS.DataSetPerson();
            this.tabConsultations = new System.Windows.Forms.TabPage();
            this.tabControlConsultation = new System.Windows.Forms.TabControl();
            this.tpCoView = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerConsultation = new System.Windows.Forms.DateTimePicker();
            this.labelMedication = new System.Windows.Forms.Label();
            this.labelDiagnostic = new System.Windows.Forms.Label();
            this.labelDateConsultation = new System.Windows.Forms.Label();
            this.labelConsultationCNP = new System.Windows.Forms.Label();
            this.labelCID = new System.Windows.Forms.Label();
            this.tbMedication = new System.Windows.Forms.TextBox();
            this.tbDiagnostic = new System.Windows.Forms.TextBox();
            this.tbConsultationCNP = new System.Windows.Forms.TextBox();
            this.tbCID = new System.Windows.Forms.TextBox();
            this.tpCoAdd = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDatecAdd = new System.Windows.Forms.DateTimePicker();
            this.labelConsMedicationAdd = new System.Windows.Forms.Label();
            this.labelConsDiagnosticAdd = new System.Windows.Forms.Label();
            this.labelConsDatecAdd = new System.Windows.Forms.Label();
            this.labelConsCnpAdd = new System.Windows.Forms.Label();
            this.labelConsCidAdd = new System.Windows.Forms.Label();
            this.tbMedicationAdd = new System.Windows.Forms.TextBox();
            this.tbDiagnosticAdd = new System.Windows.Forms.TextBox();
            this.tbConsCnpAdd = new System.Windows.Forms.TextBox();
            this.tbConsCidAdd = new System.Windows.Forms.TextBox();
            this.btnAddConsultation = new System.Windows.Forms.Button();
            this.tpCoModify = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDatecModify = new System.Windows.Forms.DateTimePicker();
            this.labelConsMedicationModify = new System.Windows.Forms.Label();
            this.labelConsDiagnosticModify = new System.Windows.Forms.Label();
            this.labelConsDatecModify = new System.Windows.Forms.Label();
            this.labelConsCnpModify = new System.Windows.Forms.Label();
            this.labelConsCidModify = new System.Windows.Forms.Label();
            this.tbMedicationModify = new System.Windows.Forms.TextBox();
            this.tbDiagnosticModify = new System.Windows.Forms.TextBox();
            this.tbConsCnpModify = new System.Windows.Forms.TextBox();
            this.tbConsCidModify = new System.Windows.Forms.TextBox();
            this.btnModifyConsultation = new System.Windows.Forms.Button();
            this.tpCoDelete = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelShowDiagnosticForDelete = new System.Windows.Forms.Label();
            this.labelShowCidForDelete = new System.Windows.Forms.Label();
            this.labelShowMedicationForDelete = new System.Windows.Forms.Label();
            this.labelShowCnpForDelete = new System.Windows.Forms.Label();
            this.labelShowDatecForDelete = new System.Windows.Forms.Label();
            this.labelConsSearchDelete = new System.Windows.Forms.Label();
            this.tbSearchDiagnosticDelete = new System.Windows.Forms.TextBox();
            this.btnDeleteConsultation = new System.Windows.Forms.Button();
            this.labelConsultationErrorPrevent = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIAGNOSTICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mEDICATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSULTATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetConsultation = new ProjectBDIS.DataSetConsultation();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.pERSONTableAdapter = new ProjectBDIS.DataSetPersonTableAdapters.PERSONTableAdapter();
            this.cONSULTATIONTableAdapter = new ProjectBDIS.DataSetConsultationTableAdapters.CONSULTATIONTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabAddDelete.SuspendLayout();
            this.tabModify.SuspendLayout();
            this.tabFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPerson)).BeginInit();
            this.tabConsultations.SuspendLayout();
            this.tabControlConsultation.SuspendLayout();
            this.tpCoView.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpCoAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpCoModify.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpCoDelete.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPatient);
            this.tabControl1.Controls.Add(this.tabConsultations);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 498);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPatient
            // 
            this.tabPatient.Controls.Add(this.tabControl2);
            this.tabPatient.Controls.Add(this.dataGridView1);
            this.tabPatient.Location = new System.Drawing.Point(4, 25);
            this.tabPatient.Name = "tabPatient";
            this.tabPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatient.Size = new System.Drawing.Size(989, 469);
            this.tabPatient.TabIndex = 0;
            this.tabPatient.Text = "Pacienti";
            this.tabPatient.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabAddDelete);
            this.tabControl2.Controls.Add(this.tabModify);
            this.tabControl2.Controls.Add(this.tabFind);
            this.tabControl2.Location = new System.Drawing.Point(511, 19);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(450, 422);
            this.tabControl2.TabIndex = 1;
            // 
            // tabAddDelete
            // 
            this.tabAddDelete.Controls.Add(this.btnAdd);
            this.tabAddDelete.Controls.Add(this.dateTimePickerAdd);
            this.tabAddDelete.Controls.Add(this.tbAge);
            this.tabAddDelete.Controls.Add(this.tbAddress);
            this.tabAddDelete.Controls.Add(this.tbLastName);
            this.tabAddDelete.Controls.Add(this.tbFirstName);
            this.tabAddDelete.Controls.Add(this.tbCNP);
            this.tabAddDelete.Controls.Add(this.labelAge);
            this.tabAddDelete.Controls.Add(this.labelBirthDate);
            this.tabAddDelete.Controls.Add(this.labelAddress);
            this.tabAddDelete.Controls.Add(this.labelLastName);
            this.tabAddDelete.Controls.Add(this.labelFirstName);
            this.tabAddDelete.Controls.Add(this.labelCNP);
            this.tabAddDelete.Location = new System.Drawing.Point(4, 25);
            this.tabAddDelete.Name = "tabAddDelete";
            this.tabAddDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddDelete.Size = new System.Drawing.Size(442, 393);
            this.tabAddDelete.TabIndex = 0;
            this.tabAddDelete.Text = "Adaugare";
            this.tabAddDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(129, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTimePickerAdd
            // 
            this.dateTimePickerAdd.Location = new System.Drawing.Point(158, 216);
            this.dateTimePickerAdd.Name = "dateTimePickerAdd";
            this.dateTimePickerAdd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerAdd.TabIndex = 12;
            this.dateTimePickerAdd.ValueChanged += new System.EventHandler(this.dateTimePickerAdd_ValueChanged);
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(158, 264);
            this.tbAge.Name = "tbAge";
            this.tbAge.ReadOnly = true;
            this.tbAge.Size = new System.Drawing.Size(200, 22);
            this.tbAge.TabIndex = 11;
            this.tbAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAge_keyPressed);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(158, 168);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(200, 22);
            this.tbAddress.TabIndex = 9;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(158, 127);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(200, 22);
            this.tbLastName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(158, 82);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(200, 22);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(158, 40);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(200, 22);
            this.tbCNP.TabIndex = 6;
            this.tbCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNP_keyPressed);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(70, 264);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(49, 17);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Varsta";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(31, 216);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(88, 17);
            this.labelBirthDate.TabIndex = 4;
            this.labelBirthDate.Text = "Data nasterii";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(66, 168);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(53, 17);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Adresa";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(54, 127);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(65, 17);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Prenume";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(74, 82);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(45, 17);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Nume";
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Location = new System.Drawing.Point(83, 40);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(36, 17);
            this.labelCNP.TabIndex = 0;
            this.labelCNP.Text = "CNP";
            // 
            // tabModify
            // 
            this.tabModify.Controls.Add(this.btnDelete);
            this.tabModify.Controls.Add(this.btnModify);
            this.tabModify.Controls.Add(this.dateTimePickerModify);
            this.tabModify.Controls.Add(this.tbAgeModify);
            this.tabModify.Controls.Add(this.tbAddressModify);
            this.tabModify.Controls.Add(this.tbLastNameModify);
            this.tabModify.Controls.Add(this.tbFirstNameModify);
            this.tabModify.Controls.Add(this.tbCNPModify);
            this.tabModify.Controls.Add(this.labelAgeModify);
            this.tabModify.Controls.Add(this.labelBirthDateModify);
            this.tabModify.Controls.Add(this.labelAddressModify);
            this.tabModify.Controls.Add(this.labelLastNameModify);
            this.tabModify.Controls.Add(this.labelFirstNameModify);
            this.tabModify.Controls.Add(this.labelCNPModify);
            this.tabModify.Location = new System.Drawing.Point(4, 25);
            this.tabModify.Name = "tabModify";
            this.tabModify.Padding = new System.Windows.Forms.Padding(3);
            this.tabModify.Size = new System.Drawing.Size(442, 393);
            this.tabModify.TabIndex = 1;
            this.tabModify.Text = "Modificare/Stergere";
            this.tabModify.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(190, 298);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(129, 36);
            this.btnModify.TabIndex = 26;
            this.btnModify.Text = "Modifica";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dateTimePickerModify
            // 
            this.dateTimePickerModify.Location = new System.Drawing.Point(157, 216);
            this.dateTimePickerModify.Name = "dateTimePickerModify";
            this.dateTimePickerModify.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerModify.TabIndex = 24;
            this.dateTimePickerModify.ValueChanged += new System.EventHandler(this.dateTimePickerModify_ValueChanged);
            // 
            // tbAgeModify
            // 
            this.tbAgeModify.Location = new System.Drawing.Point(157, 264);
            this.tbAgeModify.Name = "tbAgeModify";
            this.tbAgeModify.ReadOnly = true;
            this.tbAgeModify.Size = new System.Drawing.Size(200, 22);
            this.tbAgeModify.TabIndex = 23;
            // 
            // tbAddressModify
            // 
            this.tbAddressModify.Location = new System.Drawing.Point(157, 168);
            this.tbAddressModify.Name = "tbAddressModify";
            this.tbAddressModify.Size = new System.Drawing.Size(200, 22);
            this.tbAddressModify.TabIndex = 22;
            // 
            // tbLastNameModify
            // 
            this.tbLastNameModify.Location = new System.Drawing.Point(157, 127);
            this.tbLastNameModify.Name = "tbLastNameModify";
            this.tbLastNameModify.Size = new System.Drawing.Size(200, 22);
            this.tbLastNameModify.TabIndex = 21;
            // 
            // tbFirstNameModify
            // 
            this.tbFirstNameModify.Location = new System.Drawing.Point(157, 82);
            this.tbFirstNameModify.Name = "tbFirstNameModify";
            this.tbFirstNameModify.Size = new System.Drawing.Size(200, 22);
            this.tbFirstNameModify.TabIndex = 20;
            // 
            // tbCNPModify
            // 
            this.tbCNPModify.Location = new System.Drawing.Point(157, 40);
            this.tbCNPModify.Name = "tbCNPModify";
            this.tbCNPModify.ReadOnly = true;
            this.tbCNPModify.Size = new System.Drawing.Size(200, 22);
            this.tbCNPModify.TabIndex = 19;
            // 
            // labelAgeModify
            // 
            this.labelAgeModify.AutoSize = true;
            this.labelAgeModify.Location = new System.Drawing.Point(69, 264);
            this.labelAgeModify.Name = "labelAgeModify";
            this.labelAgeModify.Size = new System.Drawing.Size(49, 17);
            this.labelAgeModify.TabIndex = 18;
            this.labelAgeModify.Text = "Varsta";
            // 
            // labelBirthDateModify
            // 
            this.labelBirthDateModify.AutoSize = true;
            this.labelBirthDateModify.Location = new System.Drawing.Point(30, 216);
            this.labelBirthDateModify.Name = "labelBirthDateModify";
            this.labelBirthDateModify.Size = new System.Drawing.Size(88, 17);
            this.labelBirthDateModify.TabIndex = 17;
            this.labelBirthDateModify.Text = "Data nasterii";
            // 
            // labelAddressModify
            // 
            this.labelAddressModify.AutoSize = true;
            this.labelAddressModify.Location = new System.Drawing.Point(65, 168);
            this.labelAddressModify.Name = "labelAddressModify";
            this.labelAddressModify.Size = new System.Drawing.Size(53, 17);
            this.labelAddressModify.TabIndex = 16;
            this.labelAddressModify.Text = "Adresa";
            // 
            // labelLastNameModify
            // 
            this.labelLastNameModify.AutoSize = true;
            this.labelLastNameModify.Location = new System.Drawing.Point(53, 127);
            this.labelLastNameModify.Name = "labelLastNameModify";
            this.labelLastNameModify.Size = new System.Drawing.Size(65, 17);
            this.labelLastNameModify.TabIndex = 15;
            this.labelLastNameModify.Text = "Prenume";
            // 
            // labelFirstNameModify
            // 
            this.labelFirstNameModify.AutoSize = true;
            this.labelFirstNameModify.Location = new System.Drawing.Point(73, 82);
            this.labelFirstNameModify.Name = "labelFirstNameModify";
            this.labelFirstNameModify.Size = new System.Drawing.Size(45, 17);
            this.labelFirstNameModify.TabIndex = 14;
            this.labelFirstNameModify.Text = "Nume";
            // 
            // labelCNPModify
            // 
            this.labelCNPModify.AutoSize = true;
            this.labelCNPModify.Location = new System.Drawing.Point(82, 40);
            this.labelCNPModify.Name = "labelCNPModify";
            this.labelCNPModify.Size = new System.Drawing.Size(36, 17);
            this.labelCNPModify.TabIndex = 13;
            this.labelCNPModify.Text = "CNP";
            // 
            // tabFind
            // 
            this.tabFind.Controls.Add(this.tbFind3);
            this.tabFind.Controls.Add(this.tbFind2);
            this.tabFind.Controls.Add(this.tbFind1);
            this.tabFind.Controls.Add(this.labelFind3);
            this.tabFind.Controls.Add(this.labelFind2);
            this.tabFind.Controls.Add(this.labelFind1);
            this.tabFind.Location = new System.Drawing.Point(4, 25);
            this.tabFind.Name = "tabFind";
            this.tabFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabFind.Size = new System.Drawing.Size(442, 393);
            this.tabFind.TabIndex = 2;
            this.tabFind.Text = "Cautare";
            this.tabFind.UseVisualStyleBackColor = true;
            // 
            // tbFind3
            // 
            this.tbFind3.Location = new System.Drawing.Point(185, 237);
            this.tbFind3.Name = "tbFind3";
            this.tbFind3.Size = new System.Drawing.Size(195, 22);
            this.tbFind3.TabIndex = 5;
            this.tbFind3.TextChanged += new System.EventHandler(this.tbFind3_TextChanged);
            // 
            // tbFind2
            // 
            this.tbFind2.Location = new System.Drawing.Point(185, 167);
            this.tbFind2.Name = "tbFind2";
            this.tbFind2.Size = new System.Drawing.Size(195, 22);
            this.tbFind2.TabIndex = 4;
            this.tbFind2.TextChanged += new System.EventHandler(this.tbFind2_TextChanged);
            // 
            // tbFind1
            // 
            this.tbFind1.Location = new System.Drawing.Point(185, 98);
            this.tbFind1.Name = "tbFind1";
            this.tbFind1.Size = new System.Drawing.Size(195, 22);
            this.tbFind1.TabIndex = 3;
            this.tbFind1.TextChanged += new System.EventHandler(this.tbFind1_TextChanged);
            // 
            // labelFind3
            // 
            this.labelFind3.AutoSize = true;
            this.labelFind3.Location = new System.Drawing.Point(89, 237);
            this.labelFind3.Name = "labelFind3";
            this.labelFind3.Size = new System.Drawing.Size(90, 17);
            this.labelFind3.TabIndex = 2;
            this.labelFind3.Text = "Cautare CNP";
            // 
            // labelFind2
            // 
            this.labelFind2.AutoSize = true;
            this.labelFind2.Location = new System.Drawing.Point(82, 167);
            this.labelFind2.Name = "labelFind2";
            this.labelFind2.Size = new System.Drawing.Size(97, 17);
            this.labelFind2.TabIndex = 1;
            this.labelFind2.Text = "Cautare nume";
            // 
            // labelFind1
            // 
            this.labelFind1.AutoSize = true;
            this.labelFind1.Location = new System.Drawing.Point(61, 98);
            this.labelFind1.Name = "labelFind1";
            this.labelFind1.Size = new System.Drawing.Size(118, 17);
            this.labelFind1.TabIndex = 0;
            this.labelFind1.Text = "Cautare prenume";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNPDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.bIRTHDATEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pERSONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(448, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLevel_CellClick);
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // bIRTHDATEDataGridViewTextBoxColumn
            // 
            this.bIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.HeaderText = "BIRTHDATE";
            this.bIRTHDATEDataGridViewTextBoxColumn.Name = "bIRTHDATEDataGridViewTextBoxColumn";
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            // 
            // pERSONBindingSource
            // 
            this.pERSONBindingSource.DataMember = "PERSON";
            this.pERSONBindingSource.DataSource = this.dataSetPerson;
            // 
            // dataSetPerson
            // 
            this.dataSetPerson.DataSetName = "DataSetPerson";
            this.dataSetPerson.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabConsultations
            // 
            this.tabConsultations.Controls.Add(this.tabControlConsultation);
            this.tabConsultations.Controls.Add(this.labelConsultationErrorPrevent);
            this.tabConsultations.Controls.Add(this.dataGridView2);
            this.tabConsultations.Location = new System.Drawing.Point(4, 25);
            this.tabConsultations.Name = "tabConsultations";
            this.tabConsultations.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultations.Size = new System.Drawing.Size(989, 469);
            this.tabConsultations.TabIndex = 1;
            this.tabConsultations.Text = "Consultatii";
            this.tabConsultations.UseVisualStyleBackColor = true;
            // 
            // tabControlConsultation
            // 
            this.tabControlConsultation.Controls.Add(this.tpCoView);
            this.tabControlConsultation.Controls.Add(this.tpCoAdd);
            this.tabControlConsultation.Controls.Add(this.tpCoModify);
            this.tabControlConsultation.Controls.Add(this.tpCoDelete);
            this.tabControlConsultation.Location = new System.Drawing.Point(483, 56);
            this.tabControlConsultation.Name = "tabControlConsultation";
            this.tabControlConsultation.SelectedIndex = 0;
            this.tabControlConsultation.Size = new System.Drawing.Size(500, 360);
            this.tabControlConsultation.TabIndex = 17;
            // 
            // tpCoView
            // 
            this.tpCoView.Controls.Add(this.groupBox1);
            this.tpCoView.Location = new System.Drawing.Point(4, 25);
            this.tpCoView.Name = "tpCoView";
            this.tpCoView.Padding = new System.Windows.Forms.Padding(3);
            this.tpCoView.Size = new System.Drawing.Size(492, 331);
            this.tpCoView.TabIndex = 0;
            this.tpCoView.Text = "Vizualizare";
            this.tpCoView.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerConsultation);
            this.groupBox1.Controls.Add(this.labelMedication);
            this.groupBox1.Controls.Add(this.labelDiagnostic);
            this.groupBox1.Controls.Add(this.labelDateConsultation);
            this.groupBox1.Controls.Add(this.labelConsultationCNP);
            this.groupBox1.Controls.Add(this.labelCID);
            this.groupBox1.Controls.Add(this.tbMedication);
            this.groupBox1.Controls.Add(this.tbDiagnostic);
            this.groupBox1.Controls.Add(this.tbConsultationCNP);
            this.groupBox1.Controls.Add(this.tbCID);
            this.groupBox1.Location = new System.Drawing.Point(22, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 257);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerConsultation
            // 
            this.dateTimePickerConsultation.Location = new System.Drawing.Point(175, 115);
            this.dateTimePickerConsultation.Name = "dateTimePickerConsultation";
            this.dateTimePickerConsultation.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerConsultation.TabIndex = 14;
            // 
            // labelMedication
            // 
            this.labelMedication.AutoSize = true;
            this.labelMedication.Location = new System.Drawing.Point(25, 221);
            this.labelMedication.Name = "labelMedication";
            this.labelMedication.Size = new System.Drawing.Size(107, 17);
            this.labelMedication.TabIndex = 10;
            this.labelMedication.Text = "Medicamentatie";
            // 
            // labelDiagnostic
            // 
            this.labelDiagnostic.AutoSize = true;
            this.labelDiagnostic.Location = new System.Drawing.Point(58, 171);
            this.labelDiagnostic.Name = "labelDiagnostic";
            this.labelDiagnostic.Size = new System.Drawing.Size(74, 17);
            this.labelDiagnostic.TabIndex = 9;
            this.labelDiagnostic.Text = "Diagnostic";
            // 
            // labelDateConsultation
            // 
            this.labelDateConsultation.AutoSize = true;
            this.labelDateConsultation.Location = new System.Drawing.Point(22, 121);
            this.labelDateConsultation.Name = "labelDateConsultation";
            this.labelDateConsultation.Size = new System.Drawing.Size(110, 17);
            this.labelDateConsultation.TabIndex = 8;
            this.labelDateConsultation.Text = "Data consultatie";
            // 
            // labelConsultationCNP
            // 
            this.labelConsultationCNP.AutoSize = true;
            this.labelConsultationCNP.Location = new System.Drawing.Point(45, 68);
            this.labelConsultationCNP.Name = "labelConsultationCNP";
            this.labelConsultationCNP.Size = new System.Drawing.Size(87, 17);
            this.labelConsultationCNP.TabIndex = 7;
            this.labelConsultationCNP.Text = "CNP Pacient";
            // 
            // labelCID
            // 
            this.labelCID.AutoSize = true;
            this.labelCID.Location = new System.Drawing.Point(29, 13);
            this.labelCID.Name = "labelCID";
            this.labelCID.Size = new System.Drawing.Size(103, 17);
            this.labelCID.TabIndex = 6;
            this.labelCID.Text = "Consultation ID";
            // 
            // tbMedication
            // 
            this.tbMedication.Location = new System.Drawing.Point(175, 218);
            this.tbMedication.Name = "tbMedication";
            this.tbMedication.Size = new System.Drawing.Size(201, 22);
            this.tbMedication.TabIndex = 5;
            // 
            // tbDiagnostic
            // 
            this.tbDiagnostic.Location = new System.Drawing.Point(175, 168);
            this.tbDiagnostic.Name = "tbDiagnostic";
            this.tbDiagnostic.Size = new System.Drawing.Size(201, 22);
            this.tbDiagnostic.TabIndex = 4;
            // 
            // tbConsultationCNP
            // 
            this.tbConsultationCNP.Location = new System.Drawing.Point(175, 65);
            this.tbConsultationCNP.Name = "tbConsultationCNP";
            this.tbConsultationCNP.ReadOnly = true;
            this.tbConsultationCNP.Size = new System.Drawing.Size(201, 22);
            this.tbConsultationCNP.TabIndex = 2;
            // 
            // tbCID
            // 
            this.tbCID.Location = new System.Drawing.Point(175, 10);
            this.tbCID.Name = "tbCID";
            this.tbCID.ReadOnly = true;
            this.tbCID.Size = new System.Drawing.Size(201, 22);
            this.tbCID.TabIndex = 1;
            // 
            // tpCoAdd
            // 
            this.tpCoAdd.Controls.Add(this.groupBox2);
            this.tpCoAdd.Controls.Add(this.btnAddConsultation);
            this.tpCoAdd.Location = new System.Drawing.Point(4, 25);
            this.tpCoAdd.Name = "tpCoAdd";
            this.tpCoAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpCoAdd.Size = new System.Drawing.Size(492, 331);
            this.tpCoAdd.TabIndex = 1;
            this.tpCoAdd.Text = "Adaugare";
            this.tpCoAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerDatecAdd);
            this.groupBox2.Controls.Add(this.labelConsMedicationAdd);
            this.groupBox2.Controls.Add(this.labelConsDiagnosticAdd);
            this.groupBox2.Controls.Add(this.labelConsDatecAdd);
            this.groupBox2.Controls.Add(this.labelConsCnpAdd);
            this.groupBox2.Controls.Add(this.labelConsCidAdd);
            this.groupBox2.Controls.Add(this.tbMedicationAdd);
            this.groupBox2.Controls.Add(this.tbDiagnosticAdd);
            this.groupBox2.Controls.Add(this.tbConsCnpAdd);
            this.groupBox2.Controls.Add(this.tbConsCidAdd);
            this.groupBox2.Location = new System.Drawing.Point(22, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 257);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePickerDatecAdd
            // 
            this.dateTimePickerDatecAdd.Location = new System.Drawing.Point(175, 115);
            this.dateTimePickerDatecAdd.Name = "dateTimePickerDatecAdd";
            this.dateTimePickerDatecAdd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatecAdd.TabIndex = 14;
            // 
            // labelConsMedicationAdd
            // 
            this.labelConsMedicationAdd.AutoSize = true;
            this.labelConsMedicationAdd.Location = new System.Drawing.Point(25, 221);
            this.labelConsMedicationAdd.Name = "labelConsMedicationAdd";
            this.labelConsMedicationAdd.Size = new System.Drawing.Size(107, 17);
            this.labelConsMedicationAdd.TabIndex = 10;
            this.labelConsMedicationAdd.Text = "Medicamentatie";
            // 
            // labelConsDiagnosticAdd
            // 
            this.labelConsDiagnosticAdd.AutoSize = true;
            this.labelConsDiagnosticAdd.Location = new System.Drawing.Point(58, 171);
            this.labelConsDiagnosticAdd.Name = "labelConsDiagnosticAdd";
            this.labelConsDiagnosticAdd.Size = new System.Drawing.Size(74, 17);
            this.labelConsDiagnosticAdd.TabIndex = 9;
            this.labelConsDiagnosticAdd.Text = "Diagnostic";
            // 
            // labelConsDatecAdd
            // 
            this.labelConsDatecAdd.AutoSize = true;
            this.labelConsDatecAdd.Location = new System.Drawing.Point(22, 121);
            this.labelConsDatecAdd.Name = "labelConsDatecAdd";
            this.labelConsDatecAdd.Size = new System.Drawing.Size(110, 17);
            this.labelConsDatecAdd.TabIndex = 8;
            this.labelConsDatecAdd.Text = "Data consultatie";
            // 
            // labelConsCnpAdd
            // 
            this.labelConsCnpAdd.AutoSize = true;
            this.labelConsCnpAdd.Location = new System.Drawing.Point(45, 68);
            this.labelConsCnpAdd.Name = "labelConsCnpAdd";
            this.labelConsCnpAdd.Size = new System.Drawing.Size(87, 17);
            this.labelConsCnpAdd.TabIndex = 7;
            this.labelConsCnpAdd.Text = "CNP Pacient";
            // 
            // labelConsCidAdd
            // 
            this.labelConsCidAdd.AutoSize = true;
            this.labelConsCidAdd.Location = new System.Drawing.Point(29, 13);
            this.labelConsCidAdd.Name = "labelConsCidAdd";
            this.labelConsCidAdd.Size = new System.Drawing.Size(103, 17);
            this.labelConsCidAdd.TabIndex = 6;
            this.labelConsCidAdd.Text = "Consultation ID";
            // 
            // tbMedicationAdd
            // 
            this.tbMedicationAdd.Location = new System.Drawing.Point(175, 218);
            this.tbMedicationAdd.Name = "tbMedicationAdd";
            this.tbMedicationAdd.Size = new System.Drawing.Size(201, 22);
            this.tbMedicationAdd.TabIndex = 5;
            // 
            // tbDiagnosticAdd
            // 
            this.tbDiagnosticAdd.Location = new System.Drawing.Point(175, 168);
            this.tbDiagnosticAdd.Name = "tbDiagnosticAdd";
            this.tbDiagnosticAdd.Size = new System.Drawing.Size(201, 22);
            this.tbDiagnosticAdd.TabIndex = 4;
            // 
            // tbConsCnpAdd
            // 
            this.tbConsCnpAdd.Location = new System.Drawing.Point(175, 65);
            this.tbConsCnpAdd.Name = "tbConsCnpAdd";
            this.tbConsCnpAdd.ReadOnly = true;
            this.tbConsCnpAdd.Size = new System.Drawing.Size(201, 22);
            this.tbConsCnpAdd.TabIndex = 2;
            // 
            // tbConsCidAdd
            // 
            this.tbConsCidAdd.Location = new System.Drawing.Point(175, 10);
            this.tbConsCidAdd.Name = "tbConsCidAdd";
            this.tbConsCidAdd.ReadOnly = true;
            this.tbConsCidAdd.Size = new System.Drawing.Size(201, 22);
            this.tbConsCidAdd.TabIndex = 1;
            // 
            // btnAddConsultation
            // 
            this.btnAddConsultation.Location = new System.Drawing.Point(221, 296);
            this.btnAddConsultation.Name = "btnAddConsultation";
            this.btnAddConsultation.Size = new System.Drawing.Size(80, 29);
            this.btnAddConsultation.TabIndex = 11;
            this.btnAddConsultation.Text = "Adauga";
            this.btnAddConsultation.UseVisualStyleBackColor = true;
            this.btnAddConsultation.Click += new System.EventHandler(this.btnAddConsultation_Click);
            // 
            // tpCoModify
            // 
            this.tpCoModify.Controls.Add(this.groupBox3);
            this.tpCoModify.Controls.Add(this.btnModifyConsultation);
            this.tpCoModify.Location = new System.Drawing.Point(4, 25);
            this.tpCoModify.Name = "tpCoModify";
            this.tpCoModify.Size = new System.Drawing.Size(492, 331);
            this.tpCoModify.TabIndex = 2;
            this.tpCoModify.Text = "Modificare";
            this.tpCoModify.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerDatecModify);
            this.groupBox3.Controls.Add(this.labelConsMedicationModify);
            this.groupBox3.Controls.Add(this.labelConsDiagnosticModify);
            this.groupBox3.Controls.Add(this.labelConsDatecModify);
            this.groupBox3.Controls.Add(this.labelConsCnpModify);
            this.groupBox3.Controls.Add(this.labelConsCidModify);
            this.groupBox3.Controls.Add(this.tbMedicationModify);
            this.groupBox3.Controls.Add(this.tbDiagnosticModify);
            this.groupBox3.Controls.Add(this.tbConsCnpModify);
            this.groupBox3.Controls.Add(this.tbConsCidModify);
            this.groupBox3.Location = new System.Drawing.Point(22, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 257);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // dateTimePickerDatecModify
            // 
            this.dateTimePickerDatecModify.Location = new System.Drawing.Point(175, 115);
            this.dateTimePickerDatecModify.Name = "dateTimePickerDatecModify";
            this.dateTimePickerDatecModify.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatecModify.TabIndex = 14;
            // 
            // labelConsMedicationModify
            // 
            this.labelConsMedicationModify.AutoSize = true;
            this.labelConsMedicationModify.Location = new System.Drawing.Point(25, 221);
            this.labelConsMedicationModify.Name = "labelConsMedicationModify";
            this.labelConsMedicationModify.Size = new System.Drawing.Size(107, 17);
            this.labelConsMedicationModify.TabIndex = 10;
            this.labelConsMedicationModify.Text = "Medicamentatie";
            // 
            // labelConsDiagnosticModify
            // 
            this.labelConsDiagnosticModify.AutoSize = true;
            this.labelConsDiagnosticModify.Location = new System.Drawing.Point(58, 171);
            this.labelConsDiagnosticModify.Name = "labelConsDiagnosticModify";
            this.labelConsDiagnosticModify.Size = new System.Drawing.Size(74, 17);
            this.labelConsDiagnosticModify.TabIndex = 9;
            this.labelConsDiagnosticModify.Text = "Diagnostic";
            // 
            // labelConsDatecModify
            // 
            this.labelConsDatecModify.AutoSize = true;
            this.labelConsDatecModify.Location = new System.Drawing.Point(22, 121);
            this.labelConsDatecModify.Name = "labelConsDatecModify";
            this.labelConsDatecModify.Size = new System.Drawing.Size(110, 17);
            this.labelConsDatecModify.TabIndex = 8;
            this.labelConsDatecModify.Text = "Data consultatie";
            // 
            // labelConsCnpModify
            // 
            this.labelConsCnpModify.AutoSize = true;
            this.labelConsCnpModify.Location = new System.Drawing.Point(45, 68);
            this.labelConsCnpModify.Name = "labelConsCnpModify";
            this.labelConsCnpModify.Size = new System.Drawing.Size(87, 17);
            this.labelConsCnpModify.TabIndex = 7;
            this.labelConsCnpModify.Text = "CNP Pacient";
            // 
            // labelConsCidModify
            // 
            this.labelConsCidModify.AutoSize = true;
            this.labelConsCidModify.Location = new System.Drawing.Point(29, 13);
            this.labelConsCidModify.Name = "labelConsCidModify";
            this.labelConsCidModify.Size = new System.Drawing.Size(103, 17);
            this.labelConsCidModify.TabIndex = 6;
            this.labelConsCidModify.Text = "Consultation ID";
            // 
            // tbMedicationModify
            // 
            this.tbMedicationModify.Location = new System.Drawing.Point(175, 218);
            this.tbMedicationModify.Name = "tbMedicationModify";
            this.tbMedicationModify.Size = new System.Drawing.Size(201, 22);
            this.tbMedicationModify.TabIndex = 5;
            // 
            // tbDiagnosticModify
            // 
            this.tbDiagnosticModify.Location = new System.Drawing.Point(175, 168);
            this.tbDiagnosticModify.Name = "tbDiagnosticModify";
            this.tbDiagnosticModify.Size = new System.Drawing.Size(201, 22);
            this.tbDiagnosticModify.TabIndex = 4;
            // 
            // tbConsCnpModify
            // 
            this.tbConsCnpModify.Location = new System.Drawing.Point(175, 65);
            this.tbConsCnpModify.Name = "tbConsCnpModify";
            this.tbConsCnpModify.ReadOnly = true;
            this.tbConsCnpModify.Size = new System.Drawing.Size(201, 22);
            this.tbConsCnpModify.TabIndex = 2;
            // 
            // tbConsCidModify
            // 
            this.tbConsCidModify.Location = new System.Drawing.Point(175, 10);
            this.tbConsCidModify.Name = "tbConsCidModify";
            this.tbConsCidModify.ReadOnly = true;
            this.tbConsCidModify.Size = new System.Drawing.Size(201, 22);
            this.tbConsCidModify.TabIndex = 1;
            // 
            // btnModifyConsultation
            // 
            this.btnModifyConsultation.Location = new System.Drawing.Point(221, 296);
            this.btnModifyConsultation.Name = "btnModifyConsultation";
            this.btnModifyConsultation.Size = new System.Drawing.Size(80, 29);
            this.btnModifyConsultation.TabIndex = 12;
            this.btnModifyConsultation.Text = "Modifica";
            this.btnModifyConsultation.UseVisualStyleBackColor = true;
            this.btnModifyConsultation.Click += new System.EventHandler(this.btnModifyConsultation_Click);
            // 
            // tpCoDelete
            // 
            this.tpCoDelete.Controls.Add(this.groupBox4);
            this.tpCoDelete.Controls.Add(this.labelConsSearchDelete);
            this.tpCoDelete.Controls.Add(this.tbSearchDiagnosticDelete);
            this.tpCoDelete.Controls.Add(this.btnDeleteConsultation);
            this.tpCoDelete.Location = new System.Drawing.Point(4, 25);
            this.tpCoDelete.Name = "tpCoDelete";
            this.tpCoDelete.Size = new System.Drawing.Size(492, 331);
            this.tpCoDelete.TabIndex = 3;
            this.tpCoDelete.Text = "Stergere";
            this.tpCoDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelShowDiagnosticForDelete);
            this.groupBox4.Controls.Add(this.labelShowCidForDelete);
            this.groupBox4.Controls.Add(this.labelShowMedicationForDelete);
            this.groupBox4.Controls.Add(this.labelShowCnpForDelete);
            this.groupBox4.Controls.Add(this.labelShowDatecForDelete);
            this.groupBox4.Location = new System.Drawing.Point(66, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 166);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // labelShowDiagnosticForDelete
            // 
            this.labelShowDiagnosticForDelete.AutoSize = true;
            this.labelShowDiagnosticForDelete.Location = new System.Drawing.Point(6, 107);
            this.labelShowDiagnosticForDelete.Name = "labelShowDiagnosticForDelete";
            this.labelShowDiagnosticForDelete.Size = new System.Drawing.Size(104, 17);
            this.labelShowDiagnosticForDelete.TabIndex = 18;
            this.labelShowDiagnosticForDelete.Text = "labelDiagnostic";
            // 
            // labelShowCidForDelete
            // 
            this.labelShowCidForDelete.AutoSize = true;
            this.labelShowCidForDelete.Location = new System.Drawing.Point(6, 17);
            this.labelShowCidForDelete.Name = "labelShowCidForDelete";
            this.labelShowCidForDelete.Size = new System.Drawing.Size(58, 17);
            this.labelShowCidForDelete.TabIndex = 14;
            this.labelShowCidForDelete.Text = "labelCid";
            // 
            // labelShowMedicationForDelete
            // 
            this.labelShowMedicationForDelete.AutoSize = true;
            this.labelShowMedicationForDelete.Location = new System.Drawing.Point(6, 137);
            this.labelShowMedicationForDelete.Name = "labelShowMedicationForDelete";
            this.labelShowMedicationForDelete.Size = new System.Drawing.Size(106, 17);
            this.labelShowMedicationForDelete.TabIndex = 17;
            this.labelShowMedicationForDelete.Text = "labelMedication";
            // 
            // labelShowCnpForDelete
            // 
            this.labelShowCnpForDelete.AutoSize = true;
            this.labelShowCnpForDelete.Location = new System.Drawing.Point(6, 47);
            this.labelShowCnpForDelete.Name = "labelShowCnpForDelete";
            this.labelShowCnpForDelete.Size = new System.Drawing.Size(63, 17);
            this.labelShowCnpForDelete.TabIndex = 15;
            this.labelShowCnpForDelete.Text = "labelCnp";
            // 
            // labelShowDatecForDelete
            // 
            this.labelShowDatecForDelete.AutoSize = true;
            this.labelShowDatecForDelete.Location = new System.Drawing.Point(6, 77);
            this.labelShowDatecForDelete.Name = "labelShowDatecForDelete";
            this.labelShowDatecForDelete.Size = new System.Drawing.Size(75, 17);
            this.labelShowDatecForDelete.TabIndex = 16;
            this.labelShowDatecForDelete.Text = "labelDatec";
            // 
            // labelConsSearchDelete
            // 
            this.labelConsSearchDelete.AutoSize = true;
            this.labelConsSearchDelete.Location = new System.Drawing.Point(66, 60);
            this.labelConsSearchDelete.Name = "labelConsSearchDelete";
            this.labelConsSearchDelete.Size = new System.Drawing.Size(149, 17);
            this.labelConsSearchDelete.TabIndex = 1;
            this.labelConsSearchDelete.Text = "Cauta dupa diagnostic";
            // 
            // tbSearchDiagnosticDelete
            // 
            this.tbSearchDiagnosticDelete.Location = new System.Drawing.Point(233, 57);
            this.tbSearchDiagnosticDelete.Name = "tbSearchDiagnosticDelete";
            this.tbSearchDiagnosticDelete.Size = new System.Drawing.Size(197, 22);
            this.tbSearchDiagnosticDelete.TabIndex = 0;
            this.tbSearchDiagnosticDelete.TextChanged += new System.EventHandler(this.tbFindByDiagnostic_TextChanged);
            // 
            // btnDeleteConsultation
            // 
            this.btnDeleteConsultation.Location = new System.Drawing.Point(221, 296);
            this.btnDeleteConsultation.Name = "btnDeleteConsultation";
            this.btnDeleteConsultation.Size = new System.Drawing.Size(80, 29);
            this.btnDeleteConsultation.TabIndex = 13;
            this.btnDeleteConsultation.Text = "Sterge";
            this.btnDeleteConsultation.UseVisualStyleBackColor = true;
            this.btnDeleteConsultation.Click += new System.EventHandler(this.btnDeleteConsultation_Click);
            // 
            // labelConsultationErrorPrevent
            // 
            this.labelConsultationErrorPrevent.AutoSize = true;
            this.labelConsultationErrorPrevent.Location = new System.Drawing.Point(628, 26);
            this.labelConsultationErrorPrevent.Name = "labelConsultationErrorPrevent";
            this.labelConsultationErrorPrevent.Size = new System.Drawing.Size(209, 17);
            this.labelConsultationErrorPrevent.TabIndex = 15;
            this.labelConsultationErrorPrevent.Text = "Trebuie sa selectezi un pacient.";
            this.labelConsultationErrorPrevent.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn1,
            this.dATECDataGridViewTextBoxColumn,
            this.dIAGNOSTICDataGridViewTextBoxColumn,
            this.mEDICATIONDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cONSULTATIONBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(402, 365);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2Level_CellClick);
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // cNPDataGridViewTextBoxColumn1
            // 
            this.cNPDataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn1.Name = "cNPDataGridViewTextBoxColumn1";
            // 
            // dATECDataGridViewTextBoxColumn
            // 
            this.dATECDataGridViewTextBoxColumn.DataPropertyName = "DATEC";
            this.dATECDataGridViewTextBoxColumn.HeaderText = "DATEC";
            this.dATECDataGridViewTextBoxColumn.Name = "dATECDataGridViewTextBoxColumn";
            // 
            // dIAGNOSTICDataGridViewTextBoxColumn
            // 
            this.dIAGNOSTICDataGridViewTextBoxColumn.DataPropertyName = "DIAGNOSTIC";
            this.dIAGNOSTICDataGridViewTextBoxColumn.HeaderText = "DIAGNOSTIC";
            this.dIAGNOSTICDataGridViewTextBoxColumn.Name = "dIAGNOSTICDataGridViewTextBoxColumn";
            // 
            // mEDICATIONDataGridViewTextBoxColumn
            // 
            this.mEDICATIONDataGridViewTextBoxColumn.DataPropertyName = "MEDICATION";
            this.mEDICATIONDataGridViewTextBoxColumn.HeaderText = "MEDICATION";
            this.mEDICATIONDataGridViewTextBoxColumn.Name = "mEDICATIONDataGridViewTextBoxColumn";
            // 
            // cONSULTATIONBindingSource
            // 
            this.cONSULTATIONBindingSource.DataMember = "CONSULTATION";
            this.cONSULTATIONBindingSource.DataSource = this.dataSetConsultation;
            // 
            // dataSetConsultation
            // 
            this.dataSetConsultation.DataSetName = "DataSetConsultation";
            this.dataSetConsultation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 25);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(989, 469);
            this.tabReports.TabIndex = 2;
            this.tabReports.Text = "Rapoarte";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // pERSONTableAdapter
            // 
            this.pERSONTableAdapter.ClearBeforeFill = true;
            // 
            // cONSULTATIONTableAdapter
            // 
            this.cONSULTATIONTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPatient.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabAddDelete.ResumeLayout(false);
            this.tabAddDelete.PerformLayout();
            this.tabModify.ResumeLayout(false);
            this.tabModify.PerformLayout();
            this.tabFind.ResumeLayout(false);
            this.tabFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPerson)).EndInit();
            this.tabConsultations.ResumeLayout(false);
            this.tabConsultations.PerformLayout();
            this.tabControlConsultation.ResumeLayout(false);
            this.tpCoView.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpCoAdd.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpCoModify.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tpCoDelete.ResumeLayout(false);
            this.tpCoDelete.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONSULTATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConsultation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPatient;
        private System.Windows.Forms.TabPage tabConsultations;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPerson dataSetPerson;
        private System.Windows.Forms.BindingSource pERSONBindingSource;
        private DataSetPersonTableAdapters.PERSONTableAdapter pERSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabAddDelete;
        private System.Windows.Forms.TabPage tabModify;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdd;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.DateTimePicker dateTimePickerModify;
        private System.Windows.Forms.TextBox tbAgeModify;
        private System.Windows.Forms.TextBox tbAddressModify;
        private System.Windows.Forms.TextBox tbLastNameModify;
        private System.Windows.Forms.TextBox tbFirstNameModify;
        private System.Windows.Forms.TextBox tbCNPModify;
        private System.Windows.Forms.Label labelAgeModify;
        private System.Windows.Forms.Label labelBirthDateModify;
        private System.Windows.Forms.Label labelAddressModify;
        private System.Windows.Forms.Label labelLastNameModify;
        private System.Windows.Forms.Label labelFirstNameModify;
        private System.Windows.Forms.Label labelCNPModify;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.Label labelFind1;
        private System.Windows.Forms.Label labelFind3;
        private System.Windows.Forms.Label labelFind2;
        private System.Windows.Forms.TextBox tbFind3;
        private System.Windows.Forms.TextBox tbFind2;
        private System.Windows.Forms.TextBox tbFind1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSetConsultation dataSetConsultation;
        private System.Windows.Forms.BindingSource cONSULTATIONBindingSource;
        private DataSetConsultationTableAdapters.CONSULTATIONTableAdapter cONSULTATIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIAGNOSTICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mEDICATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelMedication;
        private System.Windows.Forms.Label labelDiagnostic;
        private System.Windows.Forms.Label labelDateConsultation;
        private System.Windows.Forms.Label labelConsultationCNP;
        private System.Windows.Forms.Label labelCID;
        private System.Windows.Forms.TextBox tbMedication;
        private System.Windows.Forms.TextBox tbDiagnostic;
        private System.Windows.Forms.TextBox tbConsultationCNP;
        private System.Windows.Forms.TextBox tbCID;
        private System.Windows.Forms.Button btnModifyConsultation;
        private System.Windows.Forms.Button btnAddConsultation;
        private System.Windows.Forms.Button btnDeleteConsultation;
        private System.Windows.Forms.DateTimePicker dateTimePickerConsultation;
        private System.Windows.Forms.Label labelConsultationErrorPrevent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControlConsultation;
        private System.Windows.Forms.TabPage tpCoView;
        private System.Windows.Forms.TabPage tpCoAdd;
        private System.Windows.Forms.TabPage tpCoModify;
        private System.Windows.Forms.TabPage tpCoDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatecAdd;
        private System.Windows.Forms.Label labelConsMedicationAdd;
        private System.Windows.Forms.Label labelConsDiagnosticAdd;
        private System.Windows.Forms.Label labelConsDatecAdd;
        private System.Windows.Forms.Label labelConsCnpAdd;
        private System.Windows.Forms.Label labelConsCidAdd;
        private System.Windows.Forms.TextBox tbMedicationAdd;
        private System.Windows.Forms.TextBox tbDiagnosticAdd;
        private System.Windows.Forms.TextBox tbConsCnpAdd;
        private System.Windows.Forms.TextBox tbConsCidAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatecModify;
        private System.Windows.Forms.Label labelConsMedicationModify;
        private System.Windows.Forms.Label labelConsDiagnosticModify;
        private System.Windows.Forms.Label labelConsDatecModify;
        private System.Windows.Forms.Label labelConsCnpModify;
        private System.Windows.Forms.Label labelConsCidModify;
        private System.Windows.Forms.TextBox tbMedicationModify;
        private System.Windows.Forms.TextBox tbDiagnosticModify;
        private System.Windows.Forms.TextBox tbConsCnpModify;
        private System.Windows.Forms.TextBox tbConsCidModify;
        private System.Windows.Forms.Label labelConsSearchDelete;
        private System.Windows.Forms.TextBox tbSearchDiagnosticDelete;
        private System.Windows.Forms.Label labelShowDiagnosticForDelete;
        private System.Windows.Forms.Label labelShowMedicationForDelete;
        private System.Windows.Forms.Label labelShowDatecForDelete;
        private System.Windows.Forms.Label labelShowCnpForDelete;
        private System.Windows.Forms.Label labelShowCidForDelete;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

