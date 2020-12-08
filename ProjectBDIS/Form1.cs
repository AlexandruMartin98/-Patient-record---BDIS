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
using Oracle.DataAccess.Client;
using System.Globalization;

namespace ProjectBDIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OracleConnection oracleConnection;
        OracleDataAdapter dataAdapter;
        String strSQL;
        DataSet dataSet;
        BindingSource bind;
        OracleCommand cmd;
        BindingSource bs1;
        int Constants_dateTimePickerAdd = 0;
        int Constants_dateTimePickerModify = 0;
        String cnpConsultations = null;


        OracleDataAdapter dataAdapterConsultation;
        BindingSource bsConsultation;
        DataSet dataSetConsult;
        int tabConsultationPressed = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetConsultation.CONSULTATION' table. You can move, or remove it, as needed.
            this.cONSULTATIONTableAdapter.Fill(this.dataSetConsultation.CONSULTATION);
            // TODO: This line of code loads data into the 'dataSetPerson.PERSON' table. You can move, or remove it, as needed.
            this.pERSONTableAdapter.Fill(this.dataSetPerson.PERSON);

    
            //DATA SOURCE = DESKTOP - 2OMMMBI: 1521 / XE; PASSWORD = studentmartin; USER ID = STUDENTMARTIN
            oracleConnection = new OracleConnection("DATA SOURCE= DESKTOP-2OMMMBI:1521/XE;PASSWORD=studentmartin;PERSIST SECURITY INFO=True;USER ID=STUDENTMARTIN");

            strSQL = "SELECT * FROM PERSON";
            dataAdapter = new OracleDataAdapter(strSQL, oracleConnection);
            OracleCommandBuilder comanda = new OracleCommandBuilder(dataAdapter);

            dataSet = new DataSet();
            //dataSet.Tables.Add("test");

            try
            {
                oracleConnection.Open();
                bs1 = new BindingSource();
                MessageBox.Show("Conexiune cu baza de date: " + oracleConnection.DataSource);
                dataAdapter.Fill(dataSet, "test");
                bs1.DataSource = dataSet.Tables["test"];
                dataGridView1.DataSource = bs1;

                oracleConnection.Close();
            }
            catch
            {
                MessageBox.Show("Conexiunea nu se poate realiza.");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                oracleConnection.Open();

                String CNP = tbCNP.Text;
                String firstName = tbFirstName.Text;
                String lastName = tbLastName.Text;
                String address = tbAddress.Text;
                //String date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                //DateTime date = dateTimePickerAdd.Value;
                String date = dateTimePickerAdd.Value.ToString("MM/dd/yyyy");
                var parsedDate = DateTime.Parse(date);
                String age = tbAge.Text;

                if (checkUserData(CNP, firstName, lastName, address, parsedDate, age))
                {
                    cmd = new OracleCommand("INSERT INTO PERSON (CNP, LASTNAME, FIRSTNAME, ADDRESS, BIRTHDATE, AGE)" + "VALUES (:pID, :pFirstName, :pSecondName, :pAddress, :pBirthDate, :pAge)", oracleConnection);

                    cmd.Parameters.Add("@cnp", CNP);
                    cmd.Parameters.Add("@firstname", firstName);
                    cmd.Parameters.Add("@lastname", lastName);
                    cmd.Parameters.Add("@address", address);
                    cmd.Parameters.Add("@birthdate", parsedDate);
                    cmd.Parameters.Add("@age", age);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adaugat.");

                    ReloadGridView("personTable");

                    tbCNP.Clear();
                    tbFirstName.Clear();
                    tbLastName.Clear();
                    tbAddress.Clear();
                    dateTimePickerAdd.Value = DateTimePicker.MinimumDateTime;
                    tbAge.Clear();

                    oracleConnection.Close();
                }
                else
                {
                    oracleConnection.Close();
                    return;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Erroare adaugare = " + ex.Message.ToString());
                oracleConnection.Close();
            }

        }

        private bool checkUserData(String CNP, String firstName, String lastName, String address, DateTime date, String age)
        {
            bool k = true;

            string cnpString = CNP.ToString();
            if (String.IsNullOrEmpty(cnpString))
            {
                labelCNP.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelCNP.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(firstName))
            {
                labelFirstName.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelFirstName.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(lastName))
            {
                labelLastName.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelLastName.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(address))
            {
                labelAddress.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelAddress.ForeColor = Color.Black;
            }

            string dateString = date.ToString();
            if (String.IsNullOrEmpty(dateString))
            {
                labelBirthDate.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelBirthDate.ForeColor = Color.Black;
            }

            string ageString = age.ToString();
            if (string.IsNullOrEmpty(ageString))
            {
                labelAge.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelAge.ForeColor = Color.Black;
            }

            if (!k)
            {
                return false;
            }

            return true;
        }


        private void ReloadGridView(String gridviewName)
        {

            if (gridviewName.Equals("personTable"))
            {
                // first load your datatable/dt then set it as the datasource of your grid
                dataGridView1.DataSource = null;

                strSQL = "SELECT * FROM PERSON";
                dataAdapter = new OracleDataAdapter(strSQL, oracleConnection);
                OracleCommandBuilder comanda = new OracleCommandBuilder(dataAdapter);
                dataSet = new DataSet();

                bs1 = new BindingSource();
                dataAdapter.Fill(dataSet, "test");
                bs1.DataSource = dataSet.Tables["test"];
                dataGridView1.DataSource = bs1;
            }
            else
            {
                // first load your datatable/dt then set it as the datasource of your grid
                dataGridView2.DataSource = null;

                //strSQL = "SELECT * FROM CONSULTATION";
                strSQL = "SELECT * FROM CONSULTATION WHERE CNP = " + cnpConsultations;
                dataAdapterConsultation = new OracleDataAdapter(strSQL, oracleConnection);
                OracleCommandBuilder comanda = new OracleCommandBuilder(dataAdapterConsultation);
                dataSetConsult = new DataSet();

                bsConsultation = new BindingSource();
                dataAdapterConsultation.Fill(dataSetConsult, "testConsultation");
                bsConsultation.DataSource = dataSetConsult.Tables["testConsultation"];
                dataGridView2.DataSource = bsConsultation;
            }

       }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables["test"].Rows.Count > 0)
            {
                try
                {

                    oracleConnection.Open();
                    int rownum = (dataGridView1.CurrentCell.RowIndex);
                    var dataCell = dataGridView1.Rows[rownum].Cells[0].Value;

                    cmd = new OracleCommand("DELETE FROM PERSON WHERE cnp =" + dataCell, oracleConnection);

                    cmd.Parameters.Add("@cnp", rownum);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sters.");

                    DataRow line = dataSet.Tables["test"].Rows[rownum];
                    line.Delete();

                    ReloadGridView("personTable");
                    oracleConnection.Close();

                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Erroare stergere = " + ex.Message.ToString());
                    oracleConnection.Close();
                }

            }
        }

        private void tbCNP_keyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                ToolTip buttonToolTip = new ToolTip();
                buttonToolTip.ToolTipTitle = "Only number";
                buttonToolTip.UseFading = true;
                buttonToolTip.UseAnimation = true;
                buttonToolTip.IsBalloon = true;
                buttonToolTip.ShowAlways = true;
                buttonToolTip.AutoPopDelay = 5000;
                buttonToolTip.ReshowDelay = 500;
                buttonToolTip.SetToolTip(tbCNP, e.KeyChar + " nu este un numar.");
            }
        }

        private void tbAge_keyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                ToolTip buttonToolTip = new ToolTip();
                buttonToolTip.ToolTipTitle = "Only number";
                buttonToolTip.UseFading = true;
                buttonToolTip.UseAnimation = true;
                buttonToolTip.IsBalloon = true;
                buttonToolTip.ShowAlways = true;
                buttonToolTip.AutoPopDelay = 5000;
                buttonToolTip.ReshowDelay = 500;
                buttonToolTip.SetToolTip(tbAge, e.KeyChar + " nu este un numar.");
            }
        }

        private void tbFind1_TextChanged(object sender, EventArgs e)
        {
            string var = "firstname like" + "'" + tbFind1.Text + "*'";
            bs1.Filter = var;
        }

        private void tbFind2_TextChanged(object sender, EventArgs e)
        {
            string var = "lastname like" + "'" + tbFind2.Text + "*'";
            bs1.Filter = var;
        }

        private void tbFind3_TextChanged(object sender, EventArgs e)
        {
            string var = "cnp like" + "'" + tbFind3.Text + "*'";
            bs1.Filter = var;
        }

        private void dgvLevel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindTextFields(e.RowIndex);
            lineWasSelected();
        }

        private void lineWasSelected()
        {
            int rownum = (dataGridView1.CurrentCell.RowIndex);
            cnpConsultations = dataGridView1.Rows[rownum].Cells[0].Value.ToString();
            MessageBox.Show("line " + rownum + " was selected with cnp = " + cnpConsultations);

            tbConsultationCNP.Text = cnpConsultations.ToString();
            tbCNPModify.Text = cnpConsultations.ToString();
            tbConsCnpAdd.Text = cnpConsultations.ToString();

            Random rnd = new Random();
            tbConsCidAdd.Text = rnd.Next(5, 100).ToString();
        }

        private void BindTextFields(int theRow)
        {
            tbCNPModify.DataBindings.Clear();
            tbCNPModify.DataBindings.Add(new Binding("text", bs1, "cnp", true));

            tbFirstNameModify.DataBindings.Clear();
            tbFirstNameModify.DataBindings.Add(new Binding("text", bs1, "firstname", true));

            tbLastNameModify.DataBindings.Clear();
            tbLastNameModify.DataBindings.Add(new Binding("text", bs1, "lastname", true));

            tbAddressModify.DataBindings.Clear();
            tbAddressModify.DataBindings.Add(new Binding("text", bs1, "address", true));

            dateTimePickerModify.DataBindings.Clear();
            dateTimePickerModify.DataBindings.Add(new Binding("text", bs1, "birthdate", true));

            tbAgeModify.DataBindings.Clear();
            tbAgeModify.DataBindings.Add(new Binding("text", bs1, "age", true));
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            tbCNPModify.Enabled = false;
            String firstName = tbFirstNameModify.Text;
            String lastName = tbLastNameModify.Text;
            String address = tbAddressModify.Text;
            //String date = dateTimePicker2.Value.ToString("YYYY-MM-DD");
            DateTime date = dateTimePickerModify.Value;
            String dateString = date.ToString("MM/dd/yyyy");
            String age = tbAgeModify.Text;


            int rownum = (dataGridView1.CurrentCell.RowIndex);
            var cnp = dataGridView1.Rows[rownum].Cells[0].Value;

                                                                                                                                    //EndDate = CAST('2009-05-25' AS DATETIME)
                                                                                                                                    //Select TO_DATE('02/26/2010', 'DD/MM/YYYY') from dual;
            var sql = "UPDATE Person SET LASTNAME = '" + @lastName + "', FIRSTNAME = '" + @firstName + "', ADDRESS = '"+ @address + "', BIRTHDATE = TO_DATE('" + @dateString + "', 'MM/dd/yyyy'), AGE = '" + @age + "'" + "WHERE CNP = '" + @cnp + "'";
            using (OracleConnection conn = new OracleConnection("DATA SOURCE= DESKTOP-2OMMMBI:1521/XE;PASSWORD=studentmartin;PERSIST SECURITY INFO=True;USER ID=STUDENTMARTIN"))
            {
                using (OracleCommand comm = new OracleCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.Add("@firstname", OracleDbType.NVarchar2).Value = firstName;
                    comm.Parameters.Add("@lastname", OracleDbType.NVarchar2).Value = lastName;
                    comm.Parameters.Add("@address", OracleDbType.NVarchar2).Value = address;
                    comm.Parameters.Add("@address", OracleDbType.Date).Value = date;
                    comm.Parameters.Add("@age", OracleDbType.Int16).Value = age;

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReloadGridView("personTable");
                        MessageBox.Show("Modificat using.");
                        conn.Close();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        conn.Close();
                    }
                }
            }
        }

        private void dateTimePickerModify_ValueChanged(object sender, EventArgs e)
        {
            Constants_dateTimePickerAdd++;
            if (Constants_dateTimePickerAdd > 1)
            {
                DateTime date = Convert.ToDateTime(dateTimePickerModify.Text);

                var today = DateTime.Today;

                var todayDate = (today.Year * 100 + today.Month) * 100 + today.Day;
                var birthDate = (date.Year * 100 + date.Month) * 100 + date.Day;

                double doubleAge = (todayDate - birthDate) / 10000;
                int age = (int)doubleAge;

                tbAgeModify.Text = age.ToString();
            }
        }

        private void dateTimePickerAdd_ValueChanged(object sender, EventArgs e)
        {
            Constants_dateTimePickerModify++;
            if (Constants_dateTimePickerModify > 1)
            {
                DateTime date = Convert.ToDateTime(dateTimePickerAdd.Text);

                var today = DateTime.Today;

                var todayDate = (today.Year * 100 + today.Month) * 100 + today.Day;
                var birthDate = (date.Year * 100 + date.Month) * 100 + date.Day;

                double doubleAge = (todayDate - birthDate) / 10000;
                int age = (int)doubleAge;

                tbAge.Text = age.ToString();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabConsultations"])
            {
                if (String.IsNullOrEmpty(cnpConsultations))
                {
                    //show prevent error message
                    labelConsultationErrorPrevent.Visible = true;
                    labelConsultationErrorPrevent.ForeColor = Color.Red;
                    dataGridView2.DataSource = null;
                    //disable buttons
                    btnAddConsultation.Enabled = false;
                    btnModifyConsultation.Enabled = false;
                    btnDeleteConsultation.Enabled = false;
                }
                else
                {
                    // hide prevent error message
                    labelConsultationErrorPrevent.Visible = false;
                    labelConsultationErrorPrevent.ForeColor = Color.Black;
                    //enable buttons
                    btnAddConsultation.Enabled = true;
                    btnModifyConsultation.Enabled = true;
                    btnDeleteConsultation.Enabled = true;


                    strSQL = "SELECT * FROM CONSULTATION WHERE CNP = " + cnpConsultations;
                    dataAdapterConsultation = new OracleDataAdapter(strSQL, oracleConnection);
                    OracleCommandBuilder commandConsultation = new OracleCommandBuilder(dataAdapterConsultation);

                    dataSetConsult = new DataSet();
                    //dataSet.Tables.Add("testConsultation");
                    try
                    {
                        oracleConnection.Open();
                        cmd = new OracleCommand(strSQL, oracleConnection);
                        OracleDataReader dr = cmd.ExecuteReader();
                        dr.Read();

                        if (dr.Read())
                        {
                            //bind data in gridview
                            MessageBox.Show("Pacientul are consultatii");
                            bsConsultation = new BindingSource();
                            dataAdapterConsultation.Fill(dataSetConsult, "testConsultation");
                            bsConsultation.DataSource = dataSetConsult.Tables["testConsultation"];
                            dataGridView2.DataSource = bsConsultation;

                            //call cell click to handle binding textbox
                            dgv2Level_CellClick(this.dataGridView2, new DataGridViewCellEventArgs(this.dataGridView2.CurrentCell.ColumnIndex, this.dataGridView2.CurrentRow.Index));

                            //fill tb with cnp
                            tbConsCnpAdd.Text = cnpConsultations;
                        }
                        else
                        {
                            //set all to clear
                            dataGridView2.DataSource = null;
                            clearTextBoxConsultation();
                            MessageBox.Show("Pacientul nu are consultatii, adauga una!");
                            //and go to add tab
                            this.tabControlConsultation.SelectedTab = this.tpCoAdd;
                            clearTbCaseNoPacient();
                        }

                        oracleConnection.Close();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Conexiunea nu se poate realiza." + ex.Data);
                        oracleConnection.Close();
                    }
                }
            }
        }

        private void clearTextBoxConsultation()
        {
            tbCID.Clear();
            tbConsultationCNP.Clear();
            dateTimePickerConsultation.Value = DateTimePicker.MinimumDateTime;
            tbDiagnostic.Clear();
            tbMedication.Clear();
        }

        private void clearTbCaseNoPacient()
        {
            tbConsCidModify.Clear();
            tbConsCnpModify.Clear();
            dateTimePickerDatecModify.Value = DateTimePicker.MinimumDateTime;
            tbDiagnosticModify.Clear();
            tbMedicationModify.Clear();
            btnModifyConsultation.Enabled = false;

            labelShowCidForDelete.Text = "cid disable";
            labelShowCnpForDelete.Text = "cnp disalbe";
            labelShowDatecForDelete.Text = "date disalbe";
            labelShowDiagnosticForDelete.Text = "diagnostic disable";
            labelShowMedicationForDelete.Text = "medication disable";
            btnDeleteConsultation.Enabled = false;
        }

        private void dgv2Level_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BindTextFieldsConsultation(e.RowIndex);
            BindConsultationLabelForDelete(e.RowIndex);
        }

        private void BindTextFieldsConsultation(int rowIndex)
        {
            //bind both tab cid
            tbCID.DataBindings.Clear();
            tbCID.DataBindings.Add(new Binding("text", bsConsultation, "cid", true));

            tbConsCidModify.DataBindings.Clear();
            tbConsCidModify.DataBindings.Add(new Binding("text", bsConsultation, "cid", true));

            //bind both tab cnp
            tbConsultationCNP.DataBindings.Clear();
            tbConsultationCNP.DataBindings.Add(new Binding("text", bsConsultation, "cnp", true));

            tbConsCnpModify.DataBindings.Clear();
            tbConsCnpModify.DataBindings.Add(new Binding("text", bsConsultation, "cnp", true));

            //bind both tab datec
            dateTimePickerConsultation.DataBindings.Clear();
            dateTimePickerConsultation.DataBindings.Add(new Binding("text", bsConsultation, "datec", true));

            dateTimePickerDatecModify.DataBindings.Clear();
            dateTimePickerDatecModify.DataBindings.Add(new Binding("text", bsConsultation, "datec", true));

            //bind both tab diagnostic
            tbDiagnostic.DataBindings.Clear();
            tbDiagnostic.DataBindings.Add(new Binding("text", bsConsultation, "diagnostic", true));

            tbDiagnosticModify.DataBindings.Clear();
            tbDiagnosticModify.DataBindings.Add(new Binding("text", bsConsultation, "diagnostic", true));

            //bind both tab medication
            tbMedication.DataBindings.Clear();
            tbMedication.DataBindings.Add(new Binding("text", bsConsultation, "medication", true));

            tbMedicationModify.DataBindings.Clear();
            tbMedicationModify.DataBindings.Add(new Binding("text", bsConsultation, "medication", true));
        }

        private void btnAddConsultation_Click(object sender, EventArgs e)
        {
            try
            {
                oracleConnection.Open();
                String cid = tbConsCidAdd.Text;
                String CNP = tbConsCnpAdd.Text;
                String date = dateTimePickerDatecAdd.Value.ToString("MM/dd/yyyy");
                var parsedDate = DateTime.Parse(date);

                //DateTime date = dateTimePickerDatecAdd.Value;
                String diagnostic = tbDiagnosticAdd.Text;
                String medication = tbMedicationAdd.Text;


                if (checkUserConsultationData(cid, CNP, parsedDate, diagnostic, medication))
                {
                    cmd = new OracleCommand("INSERT INTO CONSULTATION (CID, CNP, DATEC, DIAGNOSTIC, MEDICATION)" + "VALUES (:pCid, :pCnp, :pDate, :pDiagnostic, :pMedication)", oracleConnection);

                    cmd.Parameters.Add("@cid", cid);
                    cmd.Parameters.Add("@cnp", CNP);
                    cmd.Parameters.Add("@date", parsedDate);
                    cmd.Parameters.Add("@diagnostic", diagnostic);
                    cmd.Parameters.Add("@medication", medication);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adaugat.");

                    ReloadGridView("consultationTable");

                    tbConsCidAdd.Clear();
                    tbConsCnpAdd.Clear();
                    dateTimePickerDatecAdd.Value = DateTimePicker.MinimumDateTime;
                    tbDiagnosticAdd.Clear();
                    tbMedicationAdd.Clear();

                    oracleConnection.Close();
                }
                else
                {
                    oracleConnection.Close();
                    return;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Erroare adaugare = " + ex.Message.ToString());
                oracleConnection.Close();
            }
        }

        private bool checkUserConsultationData(String cid, String CNP, DateTime date, String diagnostic, String medication)
        {
            bool k = true;

            string cnpString = CNP.ToString();
            if (String.IsNullOrEmpty(cnpString))
            {
                labelConsCnpAdd.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelConsCnpAdd.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(cid))
            {
                labelConsCidAdd.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelConsCidAdd.ForeColor = Color.Black;
            }

            string dateString = date.ToString();
            if (String.IsNullOrEmpty(dateString))
            {
                labelConsDatecAdd.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelConsDatecAdd.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(diagnostic))
            {
                labelConsDiagnosticAdd.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelConsDiagnosticAdd.ForeColor = Color.Black;
            }

            if (String.IsNullOrEmpty(medication))
            {
                labelConsMedicationAdd.ForeColor = Color.Red;
                k = false;
            }
            else
            {
                labelConsMedicationAdd.ForeColor = Color.Black;
            }

            if (!k)
            {
                return false;
            }

            return true;
        }

        private void btnModifyConsultation_Click(object sender, EventArgs e)
        {

            String cid = tbConsCidModify.Text;
            String CNP = tbConsCnpModify.Text;
            DateTime date = dateTimePickerDatecModify.Value;
            String dateString = date.ToString("MM/dd/yyyy");
            String diagnostic = tbDiagnosticModify.Text;
            String medication = tbMedicationModify.Text;

            int rownum = (dataGridView2.CurrentCell.RowIndex);
            var cnp = dataGridView2.Rows[rownum].Cells[1].Value;

            //EndDate = CAST('2009-05-25' AS DATETIME)
            //Select TO_DATE('02/26/2010', 'DD/MM/YYYY') from dual;
            //var sql = "UPDATE Person SET LASTNAME = '" + @lastName + "', FIRSTNAME = '" + @firstName + "', ADDRESS = '" + @address + "', BIRTHDATE = TO_DATE('" + @dateString + "', 'MM/dd/yyyy'), AGE = '" + @age + "'" + "WHERE CNP = '" + @cnp + "'";

            var sql = "UPDATE Consultation SET CID = '" + @cid + "', CNP = '" + @cnp + "', DATEC = TO_DATE('" + @dateString + "', 'MM/dd/yyyy'), DIAGNOSTIC = '" + @diagnostic + "', MEDICATION = '" + @medication + "'" + "WHERE CID = '" + @cid + "' AND CNP = '" + @cnp + "'";
            using (OracleConnection conn = new OracleConnection("DATA SOURCE= DESKTOP-2OMMMBI:1521/XE;PASSWORD=studentmartin;PERSIST SECURITY INFO=True;USER ID=STUDENTMARTIN"))
            {
                using (OracleCommand comm = new OracleCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = sql;
                    comm.CommandType = CommandType.Text;
                    comm.Parameters.Add("@cid", OracleDbType.Int16).Value = cid;
                    comm.Parameters.Add("@cnp", OracleDbType.NVarchar2).Value = cnp;
                    comm.Parameters.Add("@datec", OracleDbType.Date).Value = date;
                    comm.Parameters.Add("@diagnostic", OracleDbType.NVarchar2).Value = diagnostic;
                    comm.Parameters.Add("@medication", OracleDbType.NVarchar2).Value = medication;

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                        ReloadGridView("consultationTable");
                        MessageBox.Show("Modificat using.");
                        conn.Close();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        conn.Close();
                    }
                }
            }
        }

        private void tbFindByDiagnostic_TextChanged(object sender, EventArgs e)
        {
            string var = "diagnostic like" + "'" + tbSearchDiagnosticDelete.Text + "*'";
            bsConsultation.Filter = var;
        }

        private void BindConsultationLabelForDelete(int rowIndex)
        {
            labelShowCidForDelete.DataBindings.Clear();
            labelShowCidForDelete.DataBindings.Add(new Binding("text", bsConsultation, "cid", true));

            labelShowCnpForDelete.DataBindings.Clear();
            labelShowCnpForDelete.DataBindings.Add(new Binding("text", bsConsultation, "cnp", true));

            labelShowDatecForDelete.DataBindings.Clear();
            labelShowDatecForDelete.DataBindings.Add(new Binding("text", bsConsultation, "datec", true));

            labelShowDiagnosticForDelete.DataBindings.Clear();
            labelShowDiagnosticForDelete.DataBindings.Add(new Binding("text", bsConsultation, "diagnostic", true));

            labelShowMedicationForDelete.DataBindings.Clear();
            labelShowMedicationForDelete.DataBindings.Add(new Binding("text", bsConsultation, "medication", true));
        }

        private void btnDeleteConsultation_Click(object sender, EventArgs e)
        {
            if (dataSetConsult.Tables["testConsultation"].Rows.Count > 0)
            {
                try
                {

                    oracleConnection.Open();
                    int rownum = (dataGridView2.CurrentCell.RowIndex);
                    var dataCell = dataGridView2.Rows[rownum].Cells[0].Value;

                    cmd = new OracleCommand("DELETE FROM CONSULTATION WHERE CID =" + dataCell, oracleConnection);

                    cmd.Parameters.Add("@cid", dataCell);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sters.");

                    DataRow line = dataSetConsult.Tables["testConsultation"].Rows[rownum];
                    line.Delete();

                    ReloadGridView("consultationTable");
                    oracleConnection.Close();

                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Erroare stergere = " + ex.Message.ToString());
                    oracleConnection.Close();
                }

            }
        }
    }

}
