namespace DDDCalculator
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
            this.lblPackages = new System.Windows.Forms.Label();
            this.numNumberOfPackages = new System.Windows.Forms.NumericUpDown();
            this.lblDoseInOnePiece = new System.Windows.Forms.Label();
            this.lblDDDInOneDose = new System.Windows.Forms.Label();
            this.numDoseInOnePackage = new System.Windows.Forms.NumericUpDown();
            this.lblDoseInPackage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbDose = new System.Windows.Forms.TextBox();
            this.tbDDDInDose = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDoseInOnePackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPackages.Location = new System.Drawing.Point(119, 202);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(280, 25);
            this.lblPackages.TabIndex = 0;
            this.lblPackages.Text = "ILOŚĆ ZUŻYTYCH OPAKOWAŃ";
            // 
            // numNumberOfPackages
            // 
            this.numNumberOfPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numNumberOfPackages.Location = new System.Drawing.Point(426, 202);
            this.numNumberOfPackages.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numNumberOfPackages.Name = "numNumberOfPackages";
            this.numNumberOfPackages.Size = new System.Drawing.Size(120, 29);
            this.numNumberOfPackages.TabIndex = 1;
            // 
            // lblDoseInOnePiece
            // 
            this.lblDoseInOnePiece.AutoSize = true;
            this.lblDoseInOnePiece.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDoseInOnePiece.Location = new System.Drawing.Point(27, 30);
            this.lblDoseInOnePiece.Name = "lblDoseInOnePiece";
            this.lblDoseInOnePiece.Size = new System.Drawing.Size(372, 25);
            this.lblDoseInOnePiece.TabIndex = 2;
            this.lblDoseInOnePiece.Text = "ILOŚĆ LEKU W 1 TABL./ AMPUŁCE (g)";
            // 
            // lblDDDInOneDose
            // 
            this.lblDDDInOneDose.AutoSize = true;
            this.lblDDDInOneDose.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDDDInOneDose.Location = new System.Drawing.Point(141, 294);
            this.lblDDDInOneDose.Name = "lblDDDInOneDose";
            this.lblDDDInOneDose.Size = new System.Drawing.Size(258, 25);
            this.lblDDDInOneDose.TabIndex = 4;
            this.lblDDDInOneDose.Text = "DDD DLA 1 TABL./ AMPUŁKI";
            // 
            // numDoseInOnePackage
            // 
            this.numDoseInOnePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numDoseInOnePackage.Location = new System.Drawing.Point(426, 118);
            this.numDoseInOnePackage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numDoseInOnePackage.Name = "numDoseInOnePackage";
            this.numDoseInOnePackage.Size = new System.Drawing.Size(120, 29);
            this.numDoseInOnePackage.TabIndex = 7;
            // 
            // lblDoseInPackage
            // 
            this.lblDoseInPackage.AutoSize = true;
            this.lblDoseInPackage.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDoseInPackage.Location = new System.Drawing.Point(9, 118);
            this.lblDoseInPackage.Name = "lblDoseInPackage";
            this.lblDoseInPackage.Size = new System.Drawing.Size(390, 25);
            this.lblDoseInPackage.TabIndex = 6;
            this.lblDoseInPackage.Text = "ILOŚĆ TABL./ AMPUŁEK W 1 OPAKOWANIU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(577, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 453);
            this.panel1.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(426, 388);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 47);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Przelicz";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(778, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "SUMA DDD";
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResult.ForeColor = System.Drawing.Color.Blue;
            this.lblResult.Location = new System.Drawing.Point(818, 96);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(90, 37);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "label2";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::DDDCalculator.Properties.Resources.logo_wybrane_1;
            this.pictureBox1.Image = global::DDDCalculator.Properties.Resources.logo_wybrane_1;
            this.pictureBox1.InitialImage = global::DDDCalculator.Properties.Resources.logo_wybrane_1;
            this.pictureBox1.Location = new System.Drawing.Point(891, 416);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // tbDose
            // 
            this.tbDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDose.Location = new System.Drawing.Point(426, 30);
            this.tbDose.Name = "tbDose";
            this.tbDose.Size = new System.Drawing.Size(120, 29);
            this.tbDose.TabIndex = 14;
            // 
            // tbDDDInDose
            // 
            this.tbDDDInDose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDDDInDose.Location = new System.Drawing.Point(426, 292);
            this.tbDDDInDose.Name = "tbDDDInDose";
            this.tbDDDInDose.Size = new System.Drawing.Size(120, 29);
            this.tbDDDInDose.TabIndex = 15;
            this.tbDDDInDose.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 478);
            this.Controls.Add(this.tbDDDInDose);
            this.Controls.Add(this.tbDose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numDoseInOnePackage);
            this.Controls.Add(this.lblDoseInPackage);
            this.Controls.Add(this.lblDDDInOneDose);
            this.Controls.Add(this.lblDoseInOnePiece);
            this.Controls.Add(this.numNumberOfPackages);
            this.Controls.Add(this.lblPackages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "DDD Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDoseInOnePackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.NumericUpDown numNumberOfPackages;
        private System.Windows.Forms.Label lblDoseInOnePiece;
        private System.Windows.Forms.Label lblDDDInOneDose;
        private System.Windows.Forms.NumericUpDown numDoseInOnePackage;
        private System.Windows.Forms.Label lblDoseInPackage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbDose;
        private System.Windows.Forms.TextBox tbDDDInDose;
    }
}

