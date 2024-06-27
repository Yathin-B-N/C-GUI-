namespace Ardiuno_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.Sendredval = new System.Windows.Forms.Button();
            this.redval = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Intensity = new System.Windows.Forms.GroupBox();
            this.yellowval = new System.Windows.Forms.TrackBar();
            this.sendyellowval = new System.Windows.Forms.Button();
            this.sendgreenval = new System.Windows.Forms.Button();
            this.greenval = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Intensity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yellowval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenval)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM12";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // onButton
            // 
            this.onButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.onButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Ivory;
            this.onButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Ivory;
            this.onButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onButton.Location = new System.Drawing.Point(6, 103);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(122, 48);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "Turn On";
            this.onButton.UseVisualStyleBackColor = false;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.BackColor = System.Drawing.Color.Red;
            this.offButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.offButton.Location = new System.Drawing.Point(206, 103);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(117, 48);
            this.offButton.TabIndex = 1;
            this.offButton.Text = "Trun Off";
            this.offButton.UseVisualStyleBackColor = false;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // Sendredval
            // 
            this.Sendredval.BackColor = System.Drawing.Color.Red;
            this.Sendredval.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sendredval.Location = new System.Drawing.Point(229, 51);
            this.Sendredval.Name = "Sendredval";
            this.Sendredval.Size = new System.Drawing.Size(118, 37);
            this.Sendredval.TabIndex = 3;
            this.Sendredval.Text = "send red value";
            this.Sendredval.UseVisualStyleBackColor = false;
            this.Sendredval.Click += new System.EventHandler(this.Sendredval_Click);
            // 
            // redval
            // 
            this.redval.BackColor = System.Drawing.Color.DarkGray;
            this.redval.Location = new System.Drawing.Point(6, 51);
            this.redval.Maximum = 255;
            this.redval.Name = "redval";
            this.redval.Size = new System.Drawing.Size(194, 56);
            this.redval.TabIndex = 4;
            this.redval.TickFrequency = 20;
            this.redval.Scroll += new System.EventHandler(this.redval_Scroll_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.offButton);
            this.groupBox1.Controls.Add(this.onButton);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pin 13 control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(139, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "PIN 13";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Intensity
            // 
            this.Intensity.BackColor = System.Drawing.Color.Maroon;
            this.Intensity.Controls.Add(this.yellowval);
            this.Intensity.Controls.Add(this.sendyellowval);
            this.Intensity.Controls.Add(this.sendgreenval);
            this.Intensity.Controls.Add(this.greenval);
            this.Intensity.Controls.Add(this.redval);
            this.Intensity.Controls.Add(this.Sendredval);
            this.Intensity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Intensity.Location = new System.Drawing.Point(395, 149);
            this.Intensity.Name = "Intensity";
            this.Intensity.Size = new System.Drawing.Size(393, 263);
            this.Intensity.TabIndex = 6;
            this.Intensity.TabStop = false;
            this.Intensity.Text = "LED INTENSITY CONTROLLER";
            // 
            // yellowval
            // 
            this.yellowval.Location = new System.Drawing.Point(6, 194);
            this.yellowval.Maximum = 255;
            this.yellowval.Name = "yellowval";
            this.yellowval.Size = new System.Drawing.Size(193, 56);
            this.yellowval.TabIndex = 9;
            this.yellowval.TickFrequency = 20;
            this.yellowval.Scroll += new System.EventHandler(this.yellowval_Scroll_1);
            // 
            // sendyellowval
            // 
            this.sendyellowval.BackColor = System.Drawing.Color.Yellow;
            this.sendyellowval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendyellowval.Location = new System.Drawing.Point(218, 194);
            this.sendyellowval.Name = "sendyellowval";
            this.sendyellowval.Size = new System.Drawing.Size(140, 32);
            this.sendyellowval.TabIndex = 8;
            this.sendyellowval.Text = "send yellow value";
            this.sendyellowval.UseVisualStyleBackColor = false;
            this.sendyellowval.Click += new System.EventHandler(this.sendyellowval_Click);
            // 
            // sendgreenval
            // 
            this.sendgreenval.BackColor = System.Drawing.Color.Green;
            this.sendgreenval.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendgreenval.Location = new System.Drawing.Point(218, 121);
            this.sendgreenval.Name = "sendgreenval";
            this.sendgreenval.Size = new System.Drawing.Size(135, 34);
            this.sendgreenval.TabIndex = 7;
            this.sendgreenval.Text = "send green value";
            this.sendgreenval.UseVisualStyleBackColor = false;
            this.sendgreenval.Click += new System.EventHandler(this.button1_Click);
            // 
            // greenval
            // 
            this.greenval.Location = new System.Drawing.Point(6, 121);
            this.greenval.Maximum = 255;
            this.greenval.Name = "greenval";
            this.greenval.Size = new System.Drawing.Size(193, 56);
            this.greenval.TabIndex = 5;
            this.greenval.TickFrequency = 20;
            this.greenval.Scroll += new System.EventHandler(this.greenval_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Controling Light with Gui";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Intensity);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Intensity.ResumeLayout(false);
            this.Intensity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yellowval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button offButton;
        public System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button Sendredval;
        private System.Windows.Forms.TrackBar redval;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Intensity;
        private System.Windows.Forms.TrackBar greenval;
        private System.Windows.Forms.Button sendyellowval;
        private System.Windows.Forms.Button sendgreenval;
        private System.Windows.Forms.TrackBar yellowval;
        private System.Windows.Forms.Label label2;
    }
}

