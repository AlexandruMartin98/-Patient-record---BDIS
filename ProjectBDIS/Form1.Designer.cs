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
            this.btnRejectModify = new System.Windows.Forms.Button();
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
            this.tabReports = new System.Windows.Forms.TabPage();
            this.pERSONTableAdapter = new ProjectBDIS.DataSetPersonTableAdapters.PERSONTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPatient.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabAddDelete.SuspendLayout();
            this.tabModify.SuspendLayout();
            this.tabFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPerson)).BeginInit();
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
            this.tabAddDelete.Controls.Add(this.btnDelete);
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
            this.tabAddDelete.Text = "Adaugare/Stergere";
            this.tabAddDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(188, 301);
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
            this.tabModify.Controls.Add(this.btnRejectModify);
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
            this.tabModify.Text = "Modificare";
            this.tabModify.UseVisualStyleBackColor = true;
            // 
            // btnRejectModify
            // 
            this.btnRejectModify.Location = new System.Drawing.Point(190, 349);
            this.btnRejectModify.Name = "btnRejectModify";
            this.btnRejectModify.Size = new System.Drawing.Size(129, 35);
            this.btnRejectModify.TabIndex = 27;
            this.btnRejectModify.Text = "Sterge Modificare";
            this.btnRejectModify.UseVisualStyleBackColor = true;
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
            this.tabConsultations.Location = new System.Drawing.Point(4, 25);
            this.tabConsultations.Name = "tabConsultations";
            this.tabConsultations.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultations.Size = new System.Drawing.Size(989, 469);
            this.tabConsultations.TabIndex = 1;
            this.tabConsultations.Text = "Consultatii";
            this.tabConsultations.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnRejectModify;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TabPage tabFind;
        private System.Windows.Forms.Label labelFind1;
        private System.Windows.Forms.Label labelFind3;
        private System.Windows.Forms.Label labelFind2;
        private System.Windows.Forms.TextBox tbFind3;
        private System.Windows.Forms.TextBox tbFind2;
        private System.Windows.Forms.TextBox tbFind1;
    }
}

