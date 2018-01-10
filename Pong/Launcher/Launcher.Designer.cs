namespace Pong.Launcher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.metrobutton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Fullscreen = new System.Windows.Forms.CheckBox();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.TrackbarLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metrobutton1
            // 
            this.metrobutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metrobutton1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.metrobutton1.Location = new System.Drawing.Point(106, 209);
            this.metrobutton1.Name = "metrobutton1";
            this.metrobutton1.Size = new System.Drawing.Size(75, 23);
            this.metrobutton1.TabIndex = 4;
            this.metrobutton1.Text = "Play!";
            this.metrobutton1.UseVisualStyleBackColor = true;
            this.metrobutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resolution :";
            // 
            // Fullscreen
            // 
            this.Fullscreen.AutoSize = true;
            this.Fullscreen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Fullscreen.Location = new System.Drawing.Point(5, 95);
            this.Fullscreen.Name = "Fullscreen";
            this.Fullscreen.Size = new System.Drawing.Size(80, 17);
            this.Fullscreen.TabIndex = 3;
            this.Fullscreen.Text = "Fullscreen :";
            this.Fullscreen.UseVisualStyleBackColor = true;
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(72, 25);
            this.metroTrackBar1.Minimum = 1;
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(121, 23);
            this.metroTrackBar1.TabIndex = 1;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sensitivity :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.TrackbarLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.metroTrackBar1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Fullscreen);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(15, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TrackbarLabel
            // 
            this.TrackbarLabel.AutoSize = true;
            this.TrackbarLabel.Location = new System.Drawing.Point(200, 28);
            this.TrackbarLabel.Name = "TrackbarLabel";
            this.TrackbarLabel.Size = new System.Drawing.Size(27, 13);
            this.TrackbarLabel.TabIndex = 7;
            this.TrackbarLabel.Text = "50%";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Items.AddRange(new object[] {
            "Native",
            "1920x1080",
            "1280x720"});
            this.comboBox1.Location = new System.Drawing.Point(72, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.UseSelectable = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metrobutton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Pong";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button metrobutton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Fullscreen;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label TrackbarLabel;
        private MetroFramework.Controls.MetroComboBox comboBox1;
    }
}