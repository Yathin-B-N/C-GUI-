namespace voltmeter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portcmb = new System.Windows.Forms.ComboBox();
            this.baudcmb = new System.Windows.Forms.ComboBox();
            this.volLbl = new System.Windows.Forms.Label();
            this.openbtn = new System.Windows.Forms.Button();
            this.closedbtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resval = new System.Windows.Forms.Label();
            this.currval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT NO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE";
            // 
            // portcmb
            // 
            this.portcmb.FormattingEnabled = true;
            this.portcmb.Items.AddRange(new object[] {
            "COM12",
            "COM6",
            "COM11",
            "COM5"});
            this.portcmb.Location = new System.Drawing.Point(199, 13);
            this.portcmb.Name = "portcmb";
            this.portcmb.Size = new System.Drawing.Size(121, 24);
            this.portcmb.TabIndex = 2;
            this.portcmb.SelectedIndexChanged += new System.EventHandler(this.portcmb_SelectedIndexChanged);
            // 
            // baudcmb
            // 
            this.baudcmb.FormattingEnabled = true;
            this.baudcmb.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "115200"});
            this.baudcmb.Location = new System.Drawing.Point(199, 85);
            this.baudcmb.Name = "baudcmb";
            this.baudcmb.Size = new System.Drawing.Size(121, 24);
            this.baudcmb.TabIndex = 3;
            this.baudcmb.SelectedIndexChanged += new System.EventHandler(this.baudcmb_SelectedIndexChanged);
            // 
            // volLbl
            // 
            this.volLbl.AutoSize = true;
            this.volLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volLbl.Location = new System.Drawing.Point(53, 261);
            this.volLbl.Name = "volLbl";
            this.volLbl.Size = new System.Drawing.Size(150, 58);
            this.volLbl.TabIndex = 4;
            this.volLbl.Text = "0.00V";
            this.volLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // openbtn
            // 
            this.openbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openbtn.Location = new System.Drawing.Point(358, 13);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(107, 27);
            this.openbtn.TabIndex = 5;
            this.openbtn.Text = "OPEN";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // closedbtn
            // 
            this.closedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedbtn.Location = new System.Drawing.Point(358, 82);
            this.closedbtn.Name = "closedbtn";
            this.closedbtn.Size = new System.Drawing.Size(107, 27);
            this.closedbtn.TabIndex = 6;
            this.closedbtn.Text = "Closed";
            this.closedbtn.UseVisualStyleBackColor = true;
            this.closedbtn.Click += new System.EventHandler(this.closedbtn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resval
            // 
            this.resval.AutoSize = true;
            this.resval.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resval.Location = new System.Drawing.Point(247, 261);
            this.resval.Name = "resval";
            this.resval.Size = new System.Drawing.Size(248, 58);
            this.resval.TabIndex = 7;
            this.resval.Text = "0.00Ohms";
            this.resval.Click += new System.EventHandler(this.resval_Click);
            // 
            // currval
            // 
            this.currval.AutoSize = true;
            this.currval.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currval.Location = new System.Drawing.Point(584, 261);
            this.currval.Name = "currval";
            this.currval.Size = new System.Drawing.Size(152, 58);
            this.currval.TabIndex = 8;
            this.currval.Text = "0.00A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currval);
            this.Controls.Add(this.resval);
            this.Controls.Add(this.closedbtn);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.volLbl);
            this.Controls.Add(this.baudcmb);
            this.Controls.Add(this.portcmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox portcmb;
        private System.Windows.Forms.ComboBox baudcmb;
        private System.Windows.Forms.Label volLbl;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.Button closedbtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label resval;
        private System.Windows.Forms.Label currval;
    }
}

