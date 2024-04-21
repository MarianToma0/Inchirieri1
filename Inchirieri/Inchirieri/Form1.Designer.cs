namespace Inchirieri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.nudAn = new System.Windows.Forms.NumericUpDown();
            this.nudPret = new System.Windows.Forms.NumericUpDown();
            this.chkInchiriata = new System.Windows.Forms.CheckBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.btnAdaugaMasina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(474, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(439, 225);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Lista masini pentru inchiriat";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(337, 48);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 2;
            // 
            // nudAn
            // 
            this.nudAn.Location = new System.Drawing.Point(337, 95);
            this.nudAn.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nudAn.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAn.Name = "nudAn";
            this.nudAn.Size = new System.Drawing.Size(100, 22);
            this.nudAn.TabIndex = 3;
            this.nudAn.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAn.ValueChanged += new System.EventHandler(this.nudAn_ValueChanged);
            // 
            // nudPret
            // 
            this.nudPret.Location = new System.Drawing.Point(337, 145);
            this.nudPret.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPret.Name = "nudPret";
            this.nudPret.Size = new System.Drawing.Size(100, 22);
            this.nudPret.TabIndex = 4;
            this.nudPret.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkInchiriata
            // 
            this.chkInchiriata.AutoSize = true;
            this.chkInchiriata.Location = new System.Drawing.Point(52, 205);
            this.chkInchiriata.Name = "chkInchiriata";
            this.chkInchiriata.Size = new System.Drawing.Size(82, 20);
            this.chkInchiriata.TabIndex = 5;
            this.chkInchiriata.Text = "Inchiriata";
            this.chkInchiriata.UseVisualStyleBackColor = true;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(49, 51);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(43, 16);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Nume";
            this.lblNume.Click += new System.EventHandler(this.lblNume_Click);
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(49, 101);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(23, 16);
            this.lblAn.TabIndex = 7;
            this.lblAn.Text = "An";
            this.lblAn.Click += new System.EventHandler(this.lblAn_Click);
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(49, 151);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(31, 16);
            this.lblPret.TabIndex = 8;
            this.lblPret.Text = "Pret";
            // 
            // btnAdaugaMasina
            // 
            this.btnAdaugaMasina.Location = new System.Drawing.Point(189, 253);
            this.btnAdaugaMasina.Name = "btnAdaugaMasina";
            this.btnAdaugaMasina.Size = new System.Drawing.Size(69, 23);
            this.btnAdaugaMasina.TabIndex = 9;
            this.btnAdaugaMasina.Text = "Adauga";
            this.btnAdaugaMasina.UseVisualStyleBackColor = true;
            this.btnAdaugaMasina.Click += new System.EventHandler(this.btnAdaugaMasina_Click_1);
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 567);
            this.Controls.Add(this.btnAdaugaMasina);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.chkInchiriata);
            this.Controls.Add(this.nudPret);
            this.Controls.Add(this.nudAn);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.NumericUpDown nudAn;
        private System.Windows.Forms.NumericUpDown nudPret;
        private System.Windows.Forms.CheckBox chkInchiriata;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Button btnAdaugaMasina;
    }
}

