namespace CalculadoraBasica
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.cmboOpciones12 = new System.Windows.Forms.ComboBox();
            this.listBoxOpciones34 = new System.Windows.Forms.ListBox();
            this.rbtnOpciones12 = new System.Windows.Forms.RadioButton();
            this.rbtnOpciones34 = new System.Windows.Forms.RadioButton();
            this.lblNameApp = new System.Windows.Forms.Label();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcular.Location = new System.Drawing.Point(186, 213);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 39);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Info;
            this.btnSalir.Location = new System.Drawing.Point(662, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 53);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.BackColor = System.Drawing.Color.Transparent;
            this.lblNum1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNum1.Location = new System.Drawing.Point(117, 81);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(63, 15);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Número 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.BackColor = System.Drawing.Color.Transparent;
            this.lblNum2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNum2.Location = new System.Drawing.Point(117, 140);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(63, 15);
            this.lblNum2.TabIndex = 3;
            this.lblNum2.Text = "Número 2:";
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(186, 78);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNum1.TabIndex = 4;
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(186, 137);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNum2.TabIndex = 5;
            // 
            // cmboOpciones12
            // 
            this.cmboOpciones12.FormattingEnabled = true;
            this.cmboOpciones12.Location = new System.Drawing.Point(396, 153);
            this.cmboOpciones12.Name = "cmboOpciones12";
            this.cmboOpciones12.Size = new System.Drawing.Size(121, 23);
            this.cmboOpciones12.TabIndex = 6;
            // 
            // listBoxOpciones34
            // 
            this.listBoxOpciones34.FormattingEnabled = true;
            this.listBoxOpciones34.ItemHeight = 15;
            this.listBoxOpciones34.Location = new System.Drawing.Point(555, 153);
            this.listBoxOpciones34.Name = "listBoxOpciones34";
            this.listBoxOpciones34.Size = new System.Drawing.Size(129, 34);
            this.listBoxOpciones34.TabIndex = 7;
            // 
            // rbtnOpciones12
            // 
            this.rbtnOpciones12.AutoSize = true;
            this.rbtnOpciones12.BackColor = System.Drawing.Color.Transparent;
            this.rbtnOpciones12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnOpciones12.Location = new System.Drawing.Point(396, 107);
            this.rbtnOpciones12.Name = "rbtnOpciones12";
            this.rbtnOpciones12.Size = new System.Drawing.Size(63, 19);
            this.rbtnOpciones12.TabIndex = 8;
            this.rbtnOpciones12.TabStop = true;
            this.rbtnOpciones12.Text = "Básicas";
            this.rbtnOpciones12.UseVisualStyleBackColor = false;
            this.rbtnOpciones12.CheckedChanged += new System.EventHandler(this.rbtnOpciones12_CheckedChanged);
            // 
            // rbtnOpciones34
            // 
            this.rbtnOpciones34.AutoSize = true;
            this.rbtnOpciones34.BackColor = System.Drawing.Color.Transparent;
            this.rbtnOpciones34.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnOpciones34.Location = new System.Drawing.Point(555, 107);
            this.rbtnOpciones34.Name = "rbtnOpciones34";
            this.rbtnOpciones34.Size = new System.Drawing.Size(81, 19);
            this.rbtnOpciones34.TabIndex = 9;
            this.rbtnOpciones34.TabStop = true;
            this.rbtnOpciones34.Text = "Avanzadas";
            this.rbtnOpciones34.UseVisualStyleBackColor = false;
            this.rbtnOpciones34.CheckedChanged += new System.EventHandler(this.rbtnOpciones34_CheckedChanged);
            // 
            // lblNameApp
            // 
            this.lblNameApp.AutoSize = true;
            this.lblNameApp.BackColor = System.Drawing.Color.Teal;
            this.lblNameApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNameApp.Location = new System.Drawing.Point(286, 20);
            this.lblNameApp.Name = "lblNameApp";
            this.lblNameApp.Padding = new System.Windows.Forms.Padding(10);
            this.lblNameApp.Size = new System.Drawing.Size(211, 37);
            this.lblNameApp.TabIndex = 10;
            this.lblNameApp.Text = "BIENVENIDO A MI CALCULADORA";
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblOperaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOperaciones.Location = new System.Drawing.Point(415, 89);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(203, 15);
            this.lblOperaciones.TabIndex = 11;
            this.lblOperaciones.Text = "-> SELECCIONE UNA OPERACION <-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculadoraBasica.Properties.Resources.FondoAzul;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.lblNameApp);
            this.Controls.Add(this.rbtnOpciones34);
            this.Controls.Add(this.rbtnOpciones12);
            this.Controls.Add(this.listBoxOpciones34);
            this.Controls.Add(this.cmboOpciones12);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private Button btnSalir;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtBoxNum1;
        private TextBox txtBoxNum2;
        private ComboBox cmboOpciones12;
        private ListBox listBoxOpciones34;
        private RadioButton rbtnOpciones12;
        private RadioButton rbtnOpciones34;
        private Label lblNameApp;
        private Label lblOperaciones;
    }
}