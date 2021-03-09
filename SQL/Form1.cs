using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SQL
{
    public partial class frmMain : Form
    {
        //Variablendeklaration
        String connectionString;
        MySqlConnection connection;
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //Connect to Databases
            try
            {
                connectionString = "server=localhost;database="+txtDatabseName.Text+";uid=root;password=";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connected");
                tmrUpdateTables.Enabled = true;
                lblConnectedTo.Text = connection.Database.ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to Connect: " + Environment.NewLine + ex);
            }
        }

        private void BtnCreateDatabase_Click(object sender, EventArgs e)
        {
            //Create Tables
            try
            {
                MySqlCommand createTables = new MySqlCommand(
                    "CREATE TABLE "+ txtCreateTable.Text +" (i int(1) PRIMARY KEY);", connection
                    );
                createTables.ExecuteNonQuery();
                MessageBox.Show("Table created");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to create Table: " + Environment.NewLine + ex);
            }
        }

        private void TmrUpdateTables_Tick(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand showTables = new MySqlCommand("show tables;", connection);
                rtxTables.Text = Convert.ToString(showTables.ExecuteNonQuery());
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to load tables: " + Environment.NewLine + ex);
            }
        }

        private void BtnDeleteTable_Click(object sender, EventArgs e)
        {
            //Delete Databases
            try
            {
                MySqlCommand deleteTables = new MySqlCommand("DROP TABLES " + txtDeleteTable.Text, connection);
                deleteTables.ExecuteNonQuery();
                MessageBox.Show("Table deleted");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to delete the Table:"+ Environment.NewLine + ex);
            } 
        }
    }
}
