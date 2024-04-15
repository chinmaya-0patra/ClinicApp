using System.Data;

namespace ClinicApp
{
    public partial class Form1 : Form
    {


        DataTable dt = new DataTable();
        DataTable dtDoc = new DataTable();
        DataTable dtspecificClinicDoc = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillClinicTable();
            fillDoctorData();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Cname";

            
            
        }

        private void fillClinicTable()
        {

            // Clinic Details

            dt.Columns.Add("CID", typeof(int));
            dt.Columns.Add("Cname");
            dt.Columns.Add("Caddr");
            dt.Columns.Add("Ccontact");
            dt.Columns.Add("Crating");

            dt.Rows.Add(1, "Dentist Pro Clinic", "Street no. 123, Block 1, California", 1010101, "7/10");
            dt.Rows.Add(2, "Doctor 24/7", "Palm beach, Florida", 1009999, "9/10");
            dt.Rows.Add(3, "HeartiHealth care", "Cupertino, Block 3C, LA", 1990000, "6/10");
            dt.Rows.Add(4, "Medicare Health", "New Town, Sector 12B, London", 3333333, "8/10");

            



        }

        private void fillDoctorData()
        {
            // Doctors Details
            dtDoc.Columns.Add("CID", typeof(int));
            dtDoc.Columns.Add("Dname");
            dtDoc.Columns.Add("Dspec");
            dtDoc.Columns.Add("Dexp");

            dtDoc.Rows.Add(1, "Rony Sefron", "MBBS, Sergion", "5yrs");
            dtDoc.Rows.Add(1, "Ryan stall", "Cardiologist", "6yrs");
            dtDoc.Rows.Add(1, "Thomas shelby", "Heart Specialist", "2yrs");
            dtDoc.Rows.Add(1, "Rony Sefron", "ENT", "4yrs");
            dtDoc.Rows.Add(2, "Emma heart", "Dentist", "10yrs");
            dtDoc.Rows.Add(2, "Tracy decker", "Teeth cleaning", "2yrs");
            dtDoc.Rows.Add(3, "Rodrigo Gonzial", "Eye Specialist", "9yrs");
            dtDoc.Rows.Add(4, "Trixy scott", "Cardiologist", "1yrs");
            dtDoc.Rows.Add(4, "Emi Martinez", "Skin Specialist", "7yrs");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblclinicName.Text = dt.Rows[comboBox1.SelectedIndex]["Cname"].ToString();
            lblclinicAddr.Text = dt.Rows[comboBox1.SelectedIndex]["Caddr"].ToString();
            lblclinicContact.Text = dt.Rows[comboBox1.SelectedIndex]["Ccontact"].ToString();
            lblclinicRating.Text = dt.Rows[comboBox1.SelectedIndex]["Crating"].ToString();

            // for lets say 1. Dentist Pro Clinic, it will show all the doctors work on that same clinic thro their id.
            dtspecificClinicDoc = dtDoc.Select("CID = " + dt.Rows[comboBox1.SelectedIndex]["CID"]).CopyToDataTable();

            comboBox2.DataSource = dtspecificClinicDoc;
            comboBox2.DisplayMember = "Dname";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDocname.Text = dtspecificClinicDoc.Rows[comboBox2.SelectedIndex]["Dname"].ToString();
            lblSpecialities.Text = dtspecificClinicDoc.Rows[comboBox2.SelectedIndex]["Dspec"].ToString();
            lblDocExp.Text = dtspecificClinicDoc.Rows[comboBox2.SelectedIndex]["Dexp"].ToString();

        }
    }
}
