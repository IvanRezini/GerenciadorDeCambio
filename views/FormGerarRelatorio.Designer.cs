namespace GerenciadorDeCambio.views
{
    partial class FormGerarRelatorio
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
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.maskedTextBoxDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDatafim = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(63, 71);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(169, 24);
            this.comboBoxCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione um cliente";
            // 
            // buttonGerar
            // 
            this.buttonGerar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGerar.Location = new System.Drawing.Point(629, 371);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(130, 27);
            this.buttonGerar.TabIndex = 2;
            this.buttonGerar.Text = "Gerar relatorio";
            this.buttonGerar.UseVisualStyleBackColor = false;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // maskedTextBoxDataInicio
            // 
            this.maskedTextBoxDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataInicio.Location = new System.Drawing.Point(90, 168);
            this.maskedTextBoxDataInicio.Mask = "0000-00-00";
            this.maskedTextBoxDataInicio.Name = "maskedTextBoxDataInicio";
            this.maskedTextBoxDataInicio.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxDataInicio.TabIndex = 3;
            this.maskedTextBoxDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxDatafim
            // 
            this.maskedTextBoxDatafim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDatafim.Location = new System.Drawing.Point(270, 168);
            this.maskedTextBoxDatafim.Mask = "0000-00-00";
            this.maskedTextBoxDatafim.Name = "maskedTextBoxDatafim";
            this.maskedTextBoxDatafim.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxDatafim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DE ";
            // 
            // FormGerarRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxDatafim);
            this.Controls.Add(this.maskedTextBoxDataInicio);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCliente);
            this.Name = "FormGerarRelatorio";
            this.Text = "FormRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDatafim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}