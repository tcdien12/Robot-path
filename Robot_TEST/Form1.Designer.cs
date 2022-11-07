namespace Robot_TEST
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCOLUMN = new System.Windows.Forms.NumericUpDown();
            this.numROW = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DataFromFlie = new System.Windows.Forms.RadioButton();
            this.datarandom = new System.Windows.Forms.RadioButton();
            this.CreatMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.flpMap = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.LBstep = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbscore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pathofrobot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCOLUMN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numROW)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numCOLUMN);
            this.panel1.Controls.Add(this.numROW);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CreatMap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.start);
            this.panel1.Location = new System.Drawing.Point(618, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 200);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(198, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "COLUMN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(198, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "ROW";
            // 
            // numCOLUMN
            // 
            this.numCOLUMN.BackColor = System.Drawing.SystemColors.Info;
            this.numCOLUMN.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numCOLUMN.Location = new System.Drawing.Point(150, 158);
            this.numCOLUMN.Name = "numCOLUMN";
            this.numCOLUMN.Size = new System.Drawing.Size(42, 23);
            this.numCOLUMN.TabIndex = 9;
            this.numCOLUMN.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numROW
            // 
            this.numROW.BackColor = System.Drawing.SystemColors.Info;
            this.numROW.Location = new System.Drawing.Point(150, 129);
            this.numROW.Name = "numROW";
            this.numROW.Size = new System.Drawing.Size(42, 23);
            this.numROW.TabIndex = 8;
            this.numROW.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DataFromFlie);
            this.panel3.Controls.Add(this.datarandom);
            this.panel3.Location = new System.Drawing.Point(28, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 56);
            this.panel3.TabIndex = 7;
            // 
            // DataFromFlie
            // 
            this.DataFromFlie.AutoSize = true;
            this.DataFromFlie.Checked = true;
            this.DataFromFlie.Location = new System.Drawing.Point(6, 32);
            this.DataFromFlie.Name = "DataFromFlie";
            this.DataFromFlie.Size = new System.Drawing.Size(101, 19);
            this.DataFromFlie.TabIndex = 1;
            this.DataFromFlie.TabStop = true;
            this.DataFromFlie.Text = "Data From File";
            this.DataFromFlie.UseVisualStyleBackColor = true;
            // 
            // datarandom
            // 
            this.datarandom.AutoSize = true;
            this.datarandom.Location = new System.Drawing.Point(6, 7);
            this.datarandom.Name = "datarandom";
            this.datarandom.Size = new System.Drawing.Size(97, 19);
            this.datarandom.TabIndex = 0;
            this.datarandom.Text = "Data Random";
            this.datarandom.UseVisualStyleBackColor = true;
            // 
            // CreatMap
            // 
            this.CreatMap.BackColor = System.Drawing.Color.Azure;
            this.CreatMap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreatMap.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.CreatMap.Location = new System.Drawing.Point(28, 79);
            this.CreatMap.Name = "CreatMap";
            this.CreatMap.Size = new System.Drawing.Size(116, 45);
            this.CreatMap.TabIndex = 4;
            this.CreatMap.Text = "Tạo mới";
            this.CreatMap.UseVisualStyleBackColor = false;
            this.CreatMap.Click += new System.EventHandler(this.CreatMap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Control";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Azure;
            this.reset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(150, 28);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(116, 45);
            this.reset.TabIndex = 2;
            this.reset.Text = "Làm mới";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.AliceBlue;
            this.stop.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stop.Location = new System.Drawing.Point(150, 79);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(116, 45);
            this.stop.TabIndex = 1;
            this.stop.Text = "Dừng lại";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Honeydew;
            this.start.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start.ForeColor = System.Drawing.Color.RoyalBlue;
            this.start.Location = new System.Drawing.Point(28, 28);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(116, 45);
            this.start.TabIndex = 0;
            this.start.Text = "Bắt đầu";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // flpMap
            // 
            this.flpMap.AutoScroll = true;
            this.flpMap.BackColor = System.Drawing.Color.DodgerBlue;
            this.flpMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMap.Location = new System.Drawing.Point(12, 12);
            this.flpMap.Margin = new System.Windows.Forms.Padding(0);
            this.flpMap.Name = "flpMap";
            this.flpMap.Size = new System.Drawing.Size(593, 600);
            this.flpMap.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.LBstep);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Lbscore);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Pathofrobot);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(618, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 394);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Path";
            // 
            // LBstep
            // 
            this.LBstep.AutoSize = true;
            this.LBstep.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBstep.Location = new System.Drawing.Point(167, 74);
            this.LBstep.Name = "LBstep";
            this.LBstep.Size = new System.Drawing.Size(25, 30);
            this.LBstep.TabIndex = 5;
            this.LBstep.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(24, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Step :";
            // 
            // Lbscore
            // 
            this.Lbscore.AutoSize = true;
            this.Lbscore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbscore.Location = new System.Drawing.Point(167, 34);
            this.Lbscore.Name = "Lbscore";
            this.Lbscore.Size = new System.Drawing.Size(25, 30);
            this.Lbscore.TabIndex = 3;
            this.Lbscore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "TOTAL :";
            // 
            // Pathofrobot
            // 
            this.Pathofrobot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pathofrobot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pathofrobot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pathofrobot.ForeColor = System.Drawing.Color.Teal;
            this.Pathofrobot.Location = new System.Drawing.Point(3, 145);
            this.Pathofrobot.Name = "Pathofrobot";
            this.Pathofrobot.Size = new System.Drawing.Size(393, 135);
            this.Pathofrobot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1024, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flpMap);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCOLUMN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numROW)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button reset;
        private Button stop;
        private Button start;
        private FlowLayoutPanel flpMap;
        private Panel panel2;
        private Label label2;
        private Button CreatMap;
        private Label Pathofrobot;
        private Label label3;
        private Label Lbscore;
        private Label LBstep;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private RadioButton DataFromFlie;
        private RadioButton datarandom;
        private Label label7;
        private Label label6;
        private NumericUpDown numCOLUMN;
        private NumericUpDown numROW;
    }
}