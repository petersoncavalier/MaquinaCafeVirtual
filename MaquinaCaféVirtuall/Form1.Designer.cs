namespace MaquinaCaféVirtuall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelStatus = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTroco = new System.Windows.Forms.Label();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.buttonSaldo = new System.Windows.Forms.Button();
            this.buttonTroco = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIniciarP = new System.Windows.Forms.Button();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.buttonCima = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.White;
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatus.Location = new System.Drawing.Point(100, 46);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(338, 36);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(12, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 25);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Café com Leite R$3,00";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.Location = new System.Drawing.Point(11, 149);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(200, 25);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Cappuccino R$3,50";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox3.Location = new System.Drawing.Point(11, 180);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(200, 25);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Mocha R$4,00";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Maquina de Café Virtual";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(330, 319);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Inserir Moeda";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "R$ 00,01",
            "R$ 00,05",
            "R$ 00,10",
            "R$ 00,25",
            "R$ 00,50",
            "R$ 01,00"});
            this.comboBox1.Location = new System.Drawing.Point(332, 290);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTroco
            // 
            this.labelTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTroco.Location = new System.Drawing.Point(332, 218);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(106, 20);
            this.labelTroco.TabIndex = 8;
            this.labelTroco.Text = "R$ 00,00";
            // 
            // labelSaldo
            // 
            this.labelSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSaldo.Location = new System.Drawing.Point(330, 116);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(106, 20);
            this.labelSaldo.TabIndex = 9;
            this.labelSaldo.Text = "R$ 00,00";
            // 
            // buttonSaldo
            // 
            this.buttonSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.buttonSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaldo.ForeColor = System.Drawing.Color.White;
            this.buttonSaldo.Location = new System.Drawing.Point(330, 139);
            this.buttonSaldo.Name = "buttonSaldo";
            this.buttonSaldo.Size = new System.Drawing.Size(106, 23);
            this.buttonSaldo.TabIndex = 10;
            this.buttonSaldo.Text = "Devolver Saldo";
            this.buttonSaldo.UseVisualStyleBackColor = false;
            this.buttonSaldo.Click += new System.EventHandler(this.buttonSaldo_Click);
            // 
            // buttonTroco
            // 
            this.buttonTroco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.buttonTroco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTroco.ForeColor = System.Drawing.Color.White;
            this.buttonTroco.Location = new System.Drawing.Point(332, 241);
            this.buttonTroco.Name = "buttonTroco";
            this.buttonTroco.Size = new System.Drawing.Size(106, 23);
            this.buttonTroco.TabIndex = 11;
            this.buttonTroco.Text = "Retirar Troco";
            this.buttonTroco.UseVisualStyleBackColor = false;
            this.buttonTroco.Click += new System.EventHandler(this.buttonTroco_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaquinaCaféVirtuall.Properties.Resources.caféIcon;
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // buttonIniciarP
            // 
            this.buttonIniciarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.buttonIniciarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIniciarP.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarP.Location = new System.Drawing.Point(11, 319);
            this.buttonIniciarP.Name = "buttonIniciarP";
            this.buttonIniciarP.Size = new System.Drawing.Size(90, 23);
            this.buttonIniciarP.TabIndex = 13;
            this.buttonIniciarP.Text = "Iniciar Preparo";
            this.buttonIniciarP.UseVisualStyleBackColor = false;
            this.buttonIniciarP.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.buttonRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetirar.ForeColor = System.Drawing.Color.White;
            this.buttonRetirar.Location = new System.Drawing.Point(234, 319);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(90, 23);
            this.buttonRetirar.TabIndex = 14;
            this.buttonRetirar.Text = "Retirar Café";
            this.buttonRetirar.UseVisualStyleBackColor = false;
            this.buttonRetirar.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonCima
            // 
            this.buttonCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(97)))), ((int)(((byte)(55)))));
            this.buttonCima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCima.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCima.ForeColor = System.Drawing.Color.White;
            this.buttonCima.Location = new System.Drawing.Point(367, 175);
            this.buttonCima.Name = "buttonCima";
            this.buttonCima.Size = new System.Drawing.Size(25, 25);
            this.buttonCima.TabIndex = 15;
            this.buttonCima.Text = "^";
            this.buttonCima.UseVisualStyleBackColor = false;
            this.buttonCima.Click += new System.EventHandler(this.buttonCima_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 354);
            this.Controls.Add(this.buttonCima);
            this.Controls.Add(this.buttonRetirar);
            this.Controls.Add(this.buttonIniciarP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonTroco);
            this.Controls.Add(this.buttonSaldo);
            this.Controls.Add(this.labelSaldo);
            this.Controls.Add(this.labelTroco);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maquina de Café Virtual";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelStatus;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label1;
        private Button buttonAdd;
        private ComboBox comboBox1;
        private Label labelTroco;
        private Label labelSaldo;
        private Button buttonSaldo;
        private Button buttonTroco;
        private PictureBox pictureBox1;
        private Button buttonIniciarP;
        private Button buttonRetirar;
        private Button buttonCima;
    }
}