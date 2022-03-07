namespace Alluvion_Moon_Base_Alpha
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Titlebox = new System.Windows.Forms.TextBox();
            this.CrewCalendar = new System.Windows.Forms.MonthCalendar();
            this.DroneOperatorSchedule = new System.Windows.Forms.CheckedListBox();
            this.TextBoxScheduleDescrption = new System.Windows.Forms.TextBox();
            this.GroupBoxAreaInformation = new System.Windows.Forms.GroupBox();
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.TextBox_Area_Description = new System.Windows.Forms.TextBox();
            this.TextBoxAreaName = new System.Windows.Forms.TextBox();
            this.AreaDescription_label = new System.Windows.Forms.Label();
            this.AreaName_label = new System.Windows.Forms.Label();
            this.GroupBoxSchedule = new System.Windows.Forms.GroupBox();
            this.TextBoxProgressBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonNorth = new System.Windows.Forms.Button();
            this.ButtonEast = new System.Windows.Forms.Button();
            this.ButtonSouth = new System.Windows.Forms.Button();
            this.ButtonWest = new System.Windows.Forms.Button();
            this.GroupBoxNav = new System.Windows.Forms.GroupBox();
            this.ButtonLQ = new System.Windows.Forms.Button();
            this.radioButtonTaskComplete = new System.Windows.Forms.RadioButton();
            this.GroupBoxAreaInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            this.GroupBoxSchedule.SuspendLayout();
            this.GroupBoxNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titlebox
            // 
            this.Titlebox.BackColor = System.Drawing.Color.Purple;
            this.Titlebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlebox.ForeColor = System.Drawing.Color.LightCyan;
            this.Titlebox.Location = new System.Drawing.Point(28, 173);
            this.Titlebox.Name = "Titlebox";
            this.Titlebox.Size = new System.Drawing.Size(326, 22);
            this.Titlebox.TabIndex = 21;
            this.Titlebox.Text = "AI Drone Operator schedule week of 2.20.2180";
            // 
            // CrewCalendar
            // 
            this.CrewCalendar.BackColor = System.Drawing.Color.LightGray;
            this.CrewCalendar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CrewCalendar.Font = new System.Drawing.Font("MingLiU-ExtB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrewCalendar.ForeColor = System.Drawing.Color.LightGray;
            this.CrewCalendar.Location = new System.Drawing.Point(437, 173);
            this.CrewCalendar.Name = "CrewCalendar";
            this.CrewCalendar.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2180, 2, 20, 0, 0, 0, 0), new System.DateTime(2180, 2, 26, 0, 0, 0, 0));
            this.CrewCalendar.ShowToday = false;
            this.CrewCalendar.ShowTodayCircle = false;
            this.CrewCalendar.TabIndex = 13;
            this.CrewCalendar.TitleBackColor = System.Drawing.Color.LightCyan;
            this.CrewCalendar.TitleForeColor = System.Drawing.Color.AliceBlue;
            this.CrewCalendar.TodayDate = new System.DateTime(2180, 2, 20, 0, 0, 0, 0);
            this.CrewCalendar.TrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CrewCalendar.UseWaitCursor = true;
            // 
            // DroneOperatorSchedule
            // 
            this.DroneOperatorSchedule.AllowDrop = true;
            this.DroneOperatorSchedule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DroneOperatorSchedule.BackColor = System.Drawing.Color.LightCyan;
            this.DroneOperatorSchedule.CheckOnClick = true;
            this.DroneOperatorSchedule.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DroneOperatorSchedule.Font = new System.Drawing.Font("MingLiU-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DroneOperatorSchedule.ForeColor = System.Drawing.Color.Purple;
            this.DroneOperatorSchedule.FormattingEnabled = true;
            this.DroneOperatorSchedule.Items.AddRange(new object[] {
            "Sunday- Arrive at Alluvion Moonbase Alpha",
            "Monday- Introduction to Alluvion Moonbase",
            "Tuesday-  Drone Launch area training",
            "Wednesday- AI Drone system configuration",
            "Thursday- Emergency protocol simulations",
            "Friday- Cargo launch area training",
            "Saturday- Alluvion maintenance procedures"});
            this.DroneOperatorSchedule.Location = new System.Drawing.Point(12, 204);
            this.DroneOperatorSchedule.Name = "DroneOperatorSchedule";
            this.DroneOperatorSchedule.Size = new System.Drawing.Size(377, 130);
            this.DroneOperatorSchedule.TabIndex = 12;
            // 
            // TextBoxScheduleDescrption
            // 
            this.TextBoxScheduleDescrption.BackColor = System.Drawing.Color.LightCyan;
            this.TextBoxScheduleDescrption.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TextBoxScheduleDescrption.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxScheduleDescrption.ForeColor = System.Drawing.Color.Purple;
            this.TextBoxScheduleDescrption.Location = new System.Drawing.Point(12, 26);
            this.TextBoxScheduleDescrption.Multiline = true;
            this.TextBoxScheduleDescrption.Name = "TextBoxScheduleDescrption";
            this.TextBoxScheduleDescrption.ReadOnly = true;
            this.TextBoxScheduleDescrption.Size = new System.Drawing.Size(420, 135);
            this.TextBoxScheduleDescrption.TabIndex = 22;
            this.TextBoxScheduleDescrption.Text = resources.GetString("TextBoxScheduleDescrption.Text");
            this.TextBoxScheduleDescrption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBoxAreaInformation
            // 
            this.GroupBoxAreaInformation.BackColor = System.Drawing.Color.LightGray;
            this.GroupBoxAreaInformation.Controls.Add(this.PictureBoxMain);
            this.GroupBoxAreaInformation.Controls.Add(this.TextBox_Area_Description);
            this.GroupBoxAreaInformation.Controls.Add(this.TextBoxAreaName);
            this.GroupBoxAreaInformation.Controls.Add(this.AreaDescription_label);
            this.GroupBoxAreaInformation.Controls.Add(this.AreaName_label);
            this.GroupBoxAreaInformation.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GroupBoxAreaInformation.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxAreaInformation.ForeColor = System.Drawing.Color.Purple;
            this.GroupBoxAreaInformation.Location = new System.Drawing.Point(673, 12);
            this.GroupBoxAreaInformation.Name = "GroupBoxAreaInformation";
            this.GroupBoxAreaInformation.Size = new System.Drawing.Size(950, 283);
            this.GroupBoxAreaInformation.TabIndex = 23;
            this.GroupBoxAreaInformation.TabStop = false;
            this.GroupBoxAreaInformation.Text = "Area Information";
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.BackColor = System.Drawing.Color.Purple;
            this.PictureBoxMain.BackgroundImage = global::Alluvion_Moon_Base_Alpha.Properties.Resources.mainIntro;
            this.PictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxMain.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxMain.ErrorImage")));
            this.PictureBoxMain.Image = global::Alluvion_Moon_Base_Alpha.Properties.Resources.mainIntro;
            this.PictureBoxMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxMain.InitialImage")));
            this.PictureBoxMain.Location = new System.Drawing.Point(6, 73);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(357, 203);
            this.PictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxMain.TabIndex = 4;
            this.PictureBoxMain.TabStop = false;
            this.PictureBoxMain.WaitOnLoad = true;
            // 
            // TextBox_Area_Description
            // 
            this.TextBox_Area_Description.BackColor = System.Drawing.Color.LightCyan;
            this.TextBox_Area_Description.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Area_Description.ForeColor = System.Drawing.Color.Purple;
            this.TextBox_Area_Description.Location = new System.Drawing.Point(369, 38);
            this.TextBox_Area_Description.Multiline = true;
            this.TextBox_Area_Description.Name = "TextBox_Area_Description";
            this.TextBox_Area_Description.ReadOnly = true;
            this.TextBox_Area_Description.Size = new System.Drawing.Size(575, 238);
            this.TextBox_Area_Description.TabIndex = 3;
            this.TextBox_Area_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAreaName
            // 
            this.TextBoxAreaName.BackColor = System.Drawing.Color.LightCyan;
            this.TextBoxAreaName.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TextBoxAreaName.Font = new System.Drawing.Font("MingLiU-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAreaName.ForeColor = System.Drawing.Color.Purple;
            this.TextBoxAreaName.Location = new System.Drawing.Point(79, 38);
            this.TextBoxAreaName.Multiline = true;
            this.TextBoxAreaName.Name = "TextBoxAreaName";
            this.TextBoxAreaName.ReadOnly = true;
            this.TextBoxAreaName.Size = new System.Drawing.Size(284, 29);
            this.TextBoxAreaName.TabIndex = 2;
            this.TextBoxAreaName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AreaDescription_label
            // 
            this.AreaDescription_label.AutoSize = true;
            this.AreaDescription_label.BackColor = System.Drawing.Color.Purple;
            this.AreaDescription_label.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaDescription_label.ForeColor = System.Drawing.Color.LightCyan;
            this.AreaDescription_label.Location = new System.Drawing.Point(541, 5);
            this.AreaDescription_label.Name = "AreaDescription_label";
            this.AreaDescription_label.Size = new System.Drawing.Size(236, 27);
            this.AreaDescription_label.TabIndex = 1;
            this.AreaDescription_label.Text = "Area Description";
            this.AreaDescription_label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AreaName_label
            // 
            this.AreaName_label.AutoSize = true;
            this.AreaName_label.BackColor = System.Drawing.Color.Purple;
            this.AreaName_label.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaName_label.ForeColor = System.Drawing.Color.LightCyan;
            this.AreaName_label.Location = new System.Drawing.Point(150, 5);
            this.AreaName_label.Name = "AreaName_label";
            this.AreaName_label.Size = new System.Drawing.Size(138, 27);
            this.AreaName_label.TabIndex = 0;
            this.AreaName_label.Text = "Area Name";
            // 
            // GroupBoxSchedule
            // 
            this.GroupBoxSchedule.BackColor = System.Drawing.Color.LightGray;
            this.GroupBoxSchedule.Controls.Add(this.radioButtonTaskComplete);
            this.GroupBoxSchedule.Controls.Add(this.TextBoxProgressBar);
            this.GroupBoxSchedule.Controls.Add(this.TextBoxScheduleDescrption);
            this.GroupBoxSchedule.Controls.Add(this.DroneOperatorSchedule);
            this.GroupBoxSchedule.Controls.Add(this.Titlebox);
            this.GroupBoxSchedule.Controls.Add(this.CrewCalendar);
            this.GroupBoxSchedule.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GroupBoxSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBoxSchedule.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSchedule.ForeColor = System.Drawing.Color.Purple;
            this.GroupBoxSchedule.Location = new System.Drawing.Point(1775, 630);
            this.GroupBoxSchedule.Name = "GroupBoxSchedule";
            this.GroupBoxSchedule.Size = new System.Drawing.Size(677, 343);
            this.GroupBoxSchedule.TabIndex = 25;
            this.GroupBoxSchedule.TabStop = false;
            this.GroupBoxSchedule.Text = "Schedule";
            // 
            // TextBoxProgressBar
            // 
            this.TextBoxProgressBar.BackColor = System.Drawing.Color.LightCyan;
            this.TextBoxProgressBar.ForeColor = System.Drawing.Color.Purple;
            this.TextBoxProgressBar.Location = new System.Drawing.Point(438, 58);
            this.TextBoxProgressBar.Name = "TextBoxProgressBar";
            this.TextBoxProgressBar.Size = new System.Drawing.Size(226, 27);
            this.TextBoxProgressBar.TabIndex = 24;
            this.TextBoxProgressBar.Text = "Task Completion Status";
            this.TextBoxProgressBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // ButtonNorth
            // 
            this.ButtonNorth.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonNorth.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.ButtonNorth.FlatAppearance.BorderSize = 3;
            this.ButtonNorth.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNorth.ForeColor = System.Drawing.Color.Purple;
            this.ButtonNorth.Location = new System.Drawing.Point(155, 19);
            this.ButtonNorth.Name = "ButtonNorth";
            this.ButtonNorth.Size = new System.Drawing.Size(221, 23);
            this.ButtonNorth.TabIndex = 1;
            this.ButtonNorth.Text = "NORTH";
            this.ButtonNorth.UseVisualStyleBackColor = false;
            this.ButtonNorth.Click += new System.EventHandler(this.ButtonNorth_Click);
            // 
            // ButtonEast
            // 
            this.ButtonEast.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonEast.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.ButtonEast.FlatAppearance.BorderSize = 3;
            this.ButtonEast.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEast.ForeColor = System.Drawing.Color.Purple;
            this.ButtonEast.Location = new System.Drawing.Point(309, 48);
            this.ButtonEast.Name = "ButtonEast";
            this.ButtonEast.Size = new System.Drawing.Size(221, 23);
            this.ButtonEast.TabIndex = 2;
            this.ButtonEast.Text = "EAST";
            this.ButtonEast.UseVisualStyleBackColor = false;
            this.ButtonEast.Click += new System.EventHandler(this.ButtonEast_Click);
            // 
            // ButtonSouth
            // 
            this.ButtonSouth.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonSouth.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.ButtonSouth.FlatAppearance.BorderSize = 3;
            this.ButtonSouth.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSouth.ForeColor = System.Drawing.Color.Purple;
            this.ButtonSouth.Location = new System.Drawing.Point(155, 77);
            this.ButtonSouth.Name = "ButtonSouth";
            this.ButtonSouth.Size = new System.Drawing.Size(221, 23);
            this.ButtonSouth.TabIndex = 3;
            this.ButtonSouth.Text = "SOUTH";
            this.ButtonSouth.UseVisualStyleBackColor = false;
            this.ButtonSouth.Click += new System.EventHandler(this.ButtonSouth_Click);
            // 
            // ButtonWest
            // 
            this.ButtonWest.BackColor = System.Drawing.Color.LightCyan;
            this.ButtonWest.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.ButtonWest.FlatAppearance.BorderSize = 3;
            this.ButtonWest.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWest.ForeColor = System.Drawing.Color.Purple;
            this.ButtonWest.Location = new System.Drawing.Point(6, 48);
            this.ButtonWest.Name = "ButtonWest";
            this.ButtonWest.Size = new System.Drawing.Size(221, 23);
            this.ButtonWest.TabIndex = 4;
            this.ButtonWest.Text = "WEST";
            this.ButtonWest.UseVisualStyleBackColor = false;
            this.ButtonWest.Click += new System.EventHandler(this.ButtonWest_Click);
            // 
            // GroupBoxNav
            // 
            this.GroupBoxNav.BackColor = System.Drawing.Color.LightGray;
            this.GroupBoxNav.Controls.Add(this.ButtonLQ);
            this.GroupBoxNav.Controls.Add(this.ButtonWest);
            this.GroupBoxNav.Controls.Add(this.ButtonSouth);
            this.GroupBoxNav.Controls.Add(this.ButtonEast);
            this.GroupBoxNav.Controls.Add(this.ButtonNorth);
            this.GroupBoxNav.Controls.Add(this.label1);
            this.GroupBoxNav.Cursor = System.Windows.Forms.Cursors.Cross;
            this.GroupBoxNav.ForeColor = System.Drawing.Color.Purple;
            this.GroupBoxNav.Location = new System.Drawing.Point(12, 34);
            this.GroupBoxNav.Name = "GroupBoxNav";
            this.GroupBoxNav.Size = new System.Drawing.Size(536, 144);
            this.GroupBoxNav.TabIndex = 24;
            this.GroupBoxNav.TabStop = false;
            this.GroupBoxNav.Text = "Alluvion Personal Navigation";
            // 
            // ButtonLQ
            // 
            this.ButtonLQ.BackColor = System.Drawing.Color.Purple;
            this.ButtonLQ.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.ButtonLQ.FlatAppearance.BorderSize = 3;
            this.ButtonLQ.Font = new System.Drawing.Font("MingLiU-ExtB", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLQ.ForeColor = System.Drawing.Color.LightCyan;
            this.ButtonLQ.Location = new System.Drawing.Point(155, 115);
            this.ButtonLQ.Name = "ButtonLQ";
            this.ButtonLQ.Size = new System.Drawing.Size(221, 23);
            this.ButtonLQ.TabIndex = 5;
            this.ButtonLQ.Text = "LIVING QUARTERS";
            this.ButtonLQ.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtonLQ.UseVisualStyleBackColor = false;
            this.ButtonLQ.Click += new System.EventHandler(this.ButtonLQ_Click);
            // 
            // radioButtonTaskComplete
            // 
            this.radioButtonTaskComplete.AutoSize = true;
            this.radioButtonTaskComplete.BackColor = System.Drawing.Color.Purple;
            this.radioButtonTaskComplete.ForeColor = System.Drawing.Color.LightCyan;
            this.radioButtonTaskComplete.Location = new System.Drawing.Point(482, 109);
            this.radioButtonTaskComplete.Name = "radioButtonTaskComplete";
            this.radioButtonTaskComplete.Size = new System.Drawing.Size(129, 20);
            this.radioButtonTaskComplete.TabIndex = 25;
            this.radioButtonTaskComplete.TabStop = true;
            this.radioButtonTaskComplete.Text = "Task Complete";
            this.radioButtonTaskComplete.UseVisualStyleBackColor = false;
            this.radioButtonTaskComplete.CheckedChanged += new System.EventHandler(this.radioButtonTaskComplete_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Alluvion_Moon_Base_Alpha.Properties.Resources.living_quarters;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2464, 985);
            this.Controls.Add(this.GroupBoxSchedule);
            this.Controls.Add(this.GroupBoxNav);
            this.Controls.Add(this.GroupBoxAreaInformation);
            this.Name = "FormMain";
            this.Text = "Alluvion Moonbase Alpha";
            this.GroupBoxAreaInformation.ResumeLayout(false);
            this.GroupBoxAreaInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            this.GroupBoxSchedule.ResumeLayout(false);
            this.GroupBoxSchedule.PerformLayout();
            this.GroupBoxNav.ResumeLayout(false);
            this.GroupBoxNav.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Titlebox;
        private System.Windows.Forms.MonthCalendar CrewCalendar;
        private System.Windows.Forms.CheckedListBox DroneOperatorSchedule;
        private System.Windows.Forms.TextBox TextBoxScheduleDescrption;
        private System.Windows.Forms.GroupBox GroupBoxAreaInformation;
        private System.Windows.Forms.TextBox TextBox_Area_Description;
        private System.Windows.Forms.TextBox TextBoxAreaName;
        private System.Windows.Forms.Label AreaDescription_label;
        private System.Windows.Forms.Label AreaName_label;
        private System.Windows.Forms.PictureBox PictureBoxMain;
        private System.Windows.Forms.GroupBox GroupBoxSchedule;
        private System.Windows.Forms.TextBox TextBoxProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonNorth;
        private System.Windows.Forms.Button ButtonEast;
        private System.Windows.Forms.Button ButtonSouth;
        private System.Windows.Forms.Button ButtonWest;
        private System.Windows.Forms.GroupBox GroupBoxNav;
        private System.Windows.Forms.Button ButtonLQ;
        private System.Windows.Forms.RadioButton radioButtonTaskComplete;
    }
}

