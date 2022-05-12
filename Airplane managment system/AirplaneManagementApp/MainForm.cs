using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manage;
using PointLine;
using Objects;

namespace AirplaneManagementApp
{
    public partial class MainForm : Form
    {
        private Management AirplaneManager;
        private GroundObject GroundObjectManager;
        public MainForm()
        {
            InitializeComponent();
            AirplaneManager = new Management();
            GroundObjectManager = new GroundObject();
    }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(AirplaneList);
            selectedItems = AirplaneList.SelectedItems;

            if (AirplaneList.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count-1;i >= 0; i--)
                {
                    AirplaneList.Items.Remove(selectedItems[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddPlane_Button_Click(object sender, EventArgs e)
        {
            try
            {
                AirplaneManager.AddAirplane(Convert.ToInt32(Height_Textbox.Text), Convert.ToInt32(Velocity_Textbox.Text), true, Convert.ToInt32(StartPosition_X.Text), Convert.ToInt32(StartPosition_Y.Text), Convert.ToInt32(Destination_X.Text), Convert.ToInt32(Destination_Y.Text), 'a');
                AirplaneList.Items.Add("H: " + Height_Textbox.Text + " V: " + Velocity_Textbox.Text + " SPos: " + StartPosition_X.Text + ";" + StartPosition_Y.Text + " Dest: " + Destination_X.Text + ";" + Destination_Y.Text + " Type: " + AircraftType_Combobox.Text);
            }
            catch (System.FormatException f)
            {
                string message = "Enter every vaules";
                string caption = "Invalid values";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Messedż box
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (EmptyValueException ev)
            {
                //komunikat
                string message = ev.Message;
                string caption = "Invalid values";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Messedż box
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (TooLowValueException tlv)
            {
                //komunikat
                string message = tlv.Message;
                string caption = "Invalid values";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Messedż box
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch (NegativeValueException nv)
            {
                string message = nv.Message;
                string caption = "Invalid Values";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Closes the parent form.
                    this.Close();
                }

            }
            
        }

        private void GroundObjList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteGrdObj_button_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(GroundObjList);
            selectedItems = GroundObjList.SelectedItems;

            if (GroundObjList.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    GroundObjList.Items.Remove(selectedItems[i]);
                }
            }
        }

        private void AddObject_button_Click(object sender, EventArgs e)
        {
            try
            {
                GroundObjectManager.AddGroundObj(Convert.ToInt32(GroundObj_X.Text), Convert.ToInt32(GroundObj_Y.Text), 1);
                GroundObjList.Items.Add(" Position: " + GroundObj_X.Text + ";" + GroundObj_Y.Text + " Type: " + GroundObjects_comboBox.Text);
            }
            catch (System.FormatException f)
            {
                string message = "Enter every vaules";
                string caption = "Invalid values";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Messedż box
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (NegativeValueException nv)
            {
                string message = nv.Message;
                string caption = "Invalid Values";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Closes the parent form.
                    this.Close();
                }
            }
            
        }

        private void GroundObjects_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroundObj_X_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
