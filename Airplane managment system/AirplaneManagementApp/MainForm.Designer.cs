
namespace AirplaneManagementApp
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Map = new System.Windows.Forms.PictureBox();
            this.LoadMap_Button = new System.Windows.Forms.Button();
            this.SaveMap_Button = new System.Windows.Forms.Button();
            this.EditPlane_Button = new System.Windows.Forms.Button();
            this.DeletePlane_Button = new System.Windows.Forms.Button();
            this.AircraftType_Combobox = new System.Windows.Forms.ComboBox();
            this.AirplaneList = new System.Windows.Forms.ListBox();
            this.Aircraft_Type = new System.Windows.Forms.Label();
            this.Start_Position = new System.Windows.Forms.Label();
            this.Destination_X = new System.Windows.Forms.TextBox();
            this.Destination = new System.Windows.Forms.Label();
            this.Height_Textbox = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.Velocity_Textbox = new System.Windows.Forms.TextBox();
            this.Velocity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroundObjects_comboBox = new System.Windows.Forms.ComboBox();
            this.AddPlane_Button = new System.Windows.Forms.Button();
            this.AddObject_button = new System.Windows.Forms.Button();
            this.Destination_Y = new System.Windows.Forms.TextBox();
            this.StartPosition_Y = new System.Windows.Forms.TextBox();
            this.StartPosition_X = new System.Windows.Forms.TextBox();
            this.GroundObj_Y = new System.Windows.Forms.TextBox();
            this.GroundObj_X = new System.Windows.Forms.TextBox();
            this.GroundObjList = new System.Windows.Forms.ListBox();
            this.DeleteGrdObj_button = new System.Windows.Forms.Button();
            this.EditGrdObj_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.Map.Image = global::AirplaneManagementApp.Properties.Resources.Clarkson;
<<<<<<< HEAD
            this.Map.Location = new System.Drawing.Point(16, 15);
            this.Map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(544, 502);
=======
            this.Map.Location = new System.Drawing.Point(12, 12);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(408, 408);
>>>>>>> parent of 6082c50 (Placeholder for saving List to file)
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            this.Map.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoadMap_Button
            // 
            this.LoadMap_Button.Location = new System.Drawing.Point(568, 452);
            this.LoadMap_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadMap_Button.Name = "LoadMap_Button";
            this.LoadMap_Button.Size = new System.Drawing.Size(100, 28);
            this.LoadMap_Button.TabIndex = 1;
            this.LoadMap_Button.Text = "Load map";
            this.LoadMap_Button.UseVisualStyleBackColor = true;
            // 
            // SaveMap_Button
            // 
            this.SaveMap_Button.Location = new System.Drawing.Point(568, 487);
            this.SaveMap_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveMap_Button.Name = "SaveMap_Button";
            this.SaveMap_Button.Size = new System.Drawing.Size(100, 28);
            this.SaveMap_Button.TabIndex = 3;
            this.SaveMap_Button.Text = "Save map";
            this.SaveMap_Button.UseVisualStyleBackColor = true;
            // 
            // EditPlane_Button
            // 
            this.EditPlane_Button.Location = new System.Drawing.Point(875, 231);
            this.EditPlane_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditPlane_Button.Name = "EditPlane_Button";
            this.EditPlane_Button.Size = new System.Drawing.Size(100, 28);
            this.EditPlane_Button.TabIndex = 4;
            this.EditPlane_Button.Text = "Edit plane";
            this.EditPlane_Button.UseVisualStyleBackColor = true;
            this.EditPlane_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeletePlane_Button
            // 
            this.DeletePlane_Button.Location = new System.Drawing.Point(983, 231);
            this.DeletePlane_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeletePlane_Button.Name = "DeletePlane_Button";
            this.DeletePlane_Button.Size = new System.Drawing.Size(100, 28);
            this.DeletePlane_Button.TabIndex = 5;
            this.DeletePlane_Button.Text = "Delete plane";
            this.DeletePlane_Button.UseVisualStyleBackColor = true;
            this.DeletePlane_Button.Click += new System.EventHandler(this.button4_Click);
            // 
            // AircraftType_Combobox
            // 
            this.AircraftType_Combobox.FormattingEnabled = true;
            this.AircraftType_Combobox.Items.AddRange(new object[] {
            "Airplane",
            "Baloon",
            "Glider",
            "Helicopter"});
            this.AircraftType_Combobox.Location = new System.Drawing.Point(568, 50);
            this.AircraftType_Combobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AircraftType_Combobox.Name = "AircraftType_Combobox";
            this.AircraftType_Combobox.Size = new System.Drawing.Size(160, 24);
            this.AircraftType_Combobox.TabIndex = 6;
            this.AircraftType_Combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // AirplaneList
            // 
            this.AirplaneList.FormattingEnabled = true;
            this.AirplaneList.ItemHeight = 16;
            this.AirplaneList.Location = new System.Drawing.Point(875, 15);
            this.AirplaneList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AirplaneList.Name = "AirplaneList";
            this.AirplaneList.Size = new System.Drawing.Size(544, 212);
            this.AirplaneList.TabIndex = 7;
            this.AirplaneList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // Aircraft_Type
            // 
            this.Aircraft_Type.AutoSize = true;
            this.Aircraft_Type.Location = new System.Drawing.Point(737, 54);
            this.Aircraft_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aircraft_Type.Name = "Aircraft_Type";
            this.Aircraft_Type.Size = new System.Drawing.Size(84, 17);
            this.Aircraft_Type.TabIndex = 8;
            this.Aircraft_Type.Text = "Aircraft type";
            this.Aircraft_Type.Click += new System.EventHandler(this.label1_Click);
            // 
            // Start_Position
            // 
            this.Start_Position.AutoSize = true;
            this.Start_Position.Location = new System.Drawing.Point(737, 87);
            this.Start_Position.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Start_Position.Name = "Start_Position";
            this.Start_Position.Size = new System.Drawing.Size(130, 17);
            this.Start_Position.TabIndex = 10;
            this.Start_Position.Text = "Start position  (x, y)";
            this.Start_Position.Click += new System.EventHandler(this.label2_Click);
            // 
            // Destination_X
            // 
            this.Destination_X.Location = new System.Drawing.Point(568, 116);
            this.Destination_X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Destination_X.Name = "Destination_X";
            this.Destination_X.Size = new System.Drawing.Size(79, 22);
            this.Destination_X.TabIndex = 11;
            this.Destination_X.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Destination
            // 
            this.Destination.AutoSize = true;
            this.Destination.Location = new System.Drawing.Point(737, 119);
            this.Destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Destination.Name = "Destination";
            this.Destination.Size = new System.Drawing.Size(114, 17);
            this.Destination.TabIndex = 12;
            this.Destination.Text = "Destination (x, y)";
            this.Destination.Click += new System.EventHandler(this.label3_Click);
            // 
            // Height_Textbox
            // 
            this.Height_Textbox.Location = new System.Drawing.Point(568, 148);
            this.Height_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Height_Textbox.Name = "Height_Textbox";
            this.Height_Textbox.Size = new System.Drawing.Size(160, 22);
            this.Height_Textbox.TabIndex = 13;
            this.Height_Textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(737, 151);
            this.Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(49, 17);
            this.Height.TabIndex = 14;
            this.Height.Text = "Height";
            this.Height.Click += new System.EventHandler(this.label4_Click);
            // 
            // Velocity_Textbox
            // 
            this.Velocity_Textbox.Location = new System.Drawing.Point(568, 180);
            this.Velocity_Textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Velocity_Textbox.Name = "Velocity_Textbox";
            this.Velocity_Textbox.Size = new System.Drawing.Size(160, 22);
            this.Velocity_Textbox.TabIndex = 15;
            this.Velocity_Textbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Velocity
            // 
            this.Velocity.AutoSize = true;
            this.Velocity.Location = new System.Drawing.Point(737, 183);
            this.Velocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Velocity.Name = "Velocity";
            this.Velocity.Size = new System.Drawing.Size(57, 17);
            this.Velocity.TabIndex = 16;
            this.Velocity.Text = "Velocity";
            this.Velocity.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Aircrafts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ground Objects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Position  (x, y)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ground object type";
            // 
            // GroundObjects_comboBox
            // 
            this.GroundObjects_comboBox.FormattingEnabled = true;
            this.GroundObjects_comboBox.Items.AddRange(new object[] {
            "City",
            "Military Base",
            "Airfield"});
            this.GroundObjects_comboBox.Location = new System.Drawing.Point(568, 303);
            this.GroundObjects_comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroundObjects_comboBox.Name = "GroundObjects_comboBox";
            this.GroundObjects_comboBox.Size = new System.Drawing.Size(160, 24);
            this.GroundObjects_comboBox.TabIndex = 21;
            this.GroundObjects_comboBox.SelectedIndexChanged += new System.EventHandler(this.GroundObjects_comboBox_SelectedIndexChanged);
            // 
            // AddPlane_Button
            // 
            this.AddPlane_Button.Location = new System.Drawing.Point(568, 212);
            this.AddPlane_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPlane_Button.Name = "AddPlane_Button";
            this.AddPlane_Button.Size = new System.Drawing.Size(100, 28);
            this.AddPlane_Button.TabIndex = 23;
            this.AddPlane_Button.Text = "Add plane";
            this.AddPlane_Button.UseVisualStyleBackColor = true;
            this.AddPlane_Button.Click += new System.EventHandler(this.AddPlane_Button_Click);
            // 
            // AddObject_button
            // 
            this.AddObject_button.Location = new System.Drawing.Point(568, 368);
            this.AddObject_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddObject_button.Name = "AddObject_button";
            this.AddObject_button.Size = new System.Drawing.Size(100, 28);
            this.AddObject_button.TabIndex = 24;
            this.AddObject_button.Text = "Add object";
            this.AddObject_button.UseVisualStyleBackColor = true;
            this.AddObject_button.Click += new System.EventHandler(this.AddObject_button_Click);
            // 
            // Destination_Y
            // 
            this.Destination_Y.Location = new System.Drawing.Point(649, 116);
            this.Destination_Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Destination_Y.Name = "Destination_Y";
            this.Destination_Y.Size = new System.Drawing.Size(79, 22);
            this.Destination_Y.TabIndex = 25;
            // 
            // StartPosition_Y
            // 
            this.StartPosition_Y.Location = new System.Drawing.Point(649, 84);
            this.StartPosition_Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPosition_Y.Name = "StartPosition_Y";
            this.StartPosition_Y.Size = new System.Drawing.Size(79, 22);
            this.StartPosition_Y.TabIndex = 27;
            this.StartPosition_Y.TextChanged += new System.EventHandler(this.StartPosition_Y_TextChanged);
            // 
            // StartPosition_X
            // 
            this.StartPosition_X.Location = new System.Drawing.Point(568, 84);
            this.StartPosition_X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartPosition_X.Name = "StartPosition_X";
            this.StartPosition_X.Size = new System.Drawing.Size(79, 22);
            this.StartPosition_X.TabIndex = 26;
            // 
            // GroundObj_Y
            // 
            this.GroundObj_Y.Location = new System.Drawing.Point(649, 336);
            this.GroundObj_Y.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroundObj_Y.Name = "GroundObj_Y";
            this.GroundObj_Y.Size = new System.Drawing.Size(79, 22);
            this.GroundObj_Y.TabIndex = 29;
            // 
            // GroundObj_X
            // 
            this.GroundObj_X.Location = new System.Drawing.Point(568, 336);
            this.GroundObj_X.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroundObj_X.Name = "GroundObj_X";
            this.GroundObj_X.Size = new System.Drawing.Size(79, 22);
            this.GroundObj_X.TabIndex = 28;
            this.GroundObj_X.TextChanged += new System.EventHandler(this.GroundObj_X_TextChanged);
            // 
            // GroundObjList
            // 
            this.GroundObjList.FormattingEnabled = true;
            this.GroundObjList.ItemHeight = 16;
            this.GroundObjList.Location = new System.Drawing.Point(875, 267);
            this.GroundObjList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroundObjList.Name = "GroundObjList";
            this.GroundObjList.Size = new System.Drawing.Size(544, 212);
            this.GroundObjList.TabIndex = 30;
            this.GroundObjList.SelectedIndexChanged += new System.EventHandler(this.GroundObjList_SelectedIndexChanged);
            // 
            // DeleteGrdObj_button
            // 
            this.DeleteGrdObj_button.Location = new System.Drawing.Point(1039, 487);
            this.DeleteGrdObj_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteGrdObj_button.Name = "DeleteGrdObj_button";
            this.DeleteGrdObj_button.Size = new System.Drawing.Size(156, 28);
            this.DeleteGrdObj_button.TabIndex = 32;
            this.DeleteGrdObj_button.Text = "Delete ground object";
            this.DeleteGrdObj_button.UseVisualStyleBackColor = true;
            this.DeleteGrdObj_button.Click += new System.EventHandler(this.DeleteGrdObj_button_Click);
            // 
            // EditGrdObj_Button
            // 
            this.EditGrdObj_Button.Location = new System.Drawing.Point(875, 487);
            this.EditGrdObj_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditGrdObj_Button.Name = "EditGrdObj_Button";
            this.EditGrdObj_Button.Size = new System.Drawing.Size(156, 28);
            this.EditGrdObj_Button.TabIndex = 33;
            this.EditGrdObj_Button.Text = "Edit ground object";
            this.EditGrdObj_Button.UseVisualStyleBackColor = true;
            this.EditGrdObj_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1431, 533);
=======
            this.ClientSize = new System.Drawing.Size(1073, 433);
>>>>>>> parent of 6082c50 (Placeholder for saving List to file)
            this.Controls.Add(this.EditGrdObj_Button);
            this.Controls.Add(this.DeleteGrdObj_button);
            this.Controls.Add(this.GroundObjList);
            this.Controls.Add(this.GroundObj_Y);
            this.Controls.Add(this.GroundObj_X);
            this.Controls.Add(this.StartPosition_Y);
            this.Controls.Add(this.StartPosition_X);
            this.Controls.Add(this.Destination_Y);
            this.Controls.Add(this.AddObject_button);
            this.Controls.Add(this.AddPlane_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GroundObjects_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Velocity);
            this.Controls.Add(this.Velocity_Textbox);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Height_Textbox);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.Destination_X);
            this.Controls.Add(this.Start_Position);
            this.Controls.Add(this.Aircraft_Type);
            this.Controls.Add(this.AirplaneList);
            this.Controls.Add(this.AircraftType_Combobox);
            this.Controls.Add(this.DeletePlane_Button);
            this.Controls.Add(this.EditPlane_Button);
            this.Controls.Add(this.SaveMap_Button);
            this.Controls.Add(this.LoadMap_Button);
            this.Controls.Add(this.Map);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
>>>>>>> parent of 6082c50 (Placeholder for saving List to file)
            this.Name = "MainForm";
            this.Text = "Radar";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Map;
        private System.Windows.Forms.Button LoadMap_Button;
        private System.Windows.Forms.Button SaveMap_Button;
        private System.Windows.Forms.Button EditPlane_Button;
        private System.Windows.Forms.Button DeletePlane_Button;
        private System.Windows.Forms.ListBox AirplaneList;
        public System.Windows.Forms.ComboBox AircraftType_Combobox;
        private System.Windows.Forms.Label Aircraft_Type;
        private System.Windows.Forms.Label Start_Position;
        private System.Windows.Forms.TextBox Destination_X;
        private System.Windows.Forms.Label Destination;
        private System.Windows.Forms.TextBox Height_Textbox;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox Velocity_Textbox;
        private System.Windows.Forms.Label Velocity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox GroundObjects_comboBox;
        private System.Windows.Forms.Button AddPlane_Button;
        private System.Windows.Forms.Button AddObject_button;
        private System.Windows.Forms.TextBox Destination_Y;
        private System.Windows.Forms.TextBox StartPosition_Y;
        private System.Windows.Forms.TextBox StartPosition_X;
        private System.Windows.Forms.TextBox GroundObj_Y;
        private System.Windows.Forms.TextBox GroundObj_X;
        private System.Windows.Forms.ListBox GroundObjList;
        private System.Windows.Forms.Button DeleteGrdObj_button;
        private System.Windows.Forms.Button EditGrdObj_Button;
    }
}

