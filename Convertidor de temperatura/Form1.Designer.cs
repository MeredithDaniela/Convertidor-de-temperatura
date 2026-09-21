namespace Convertidor_de_temperatura
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
            label1 = new Label();
            label2 = new Label();
            txtCen = new TextBox();
            txtfah = new TextBox();
            btnAcep = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(176, 22);
            label1.TabIndex = 0;
            label1.Text = "Grados Centigrados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 171);
            label2.Name = "label2";
            label2.Size = new Size(174, 22);
            label2.TabIndex = 1;
            label2.Text = "Grados Faherenheit";
            // 
            // txtCen
            // 
            txtCen.Location = new Point(194, 53);
            txtCen.Name = "txtCen";
            txtCen.Size = new Size(170, 23);
            txtCen.TabIndex = 2;
            txtCen.TextChanged += txtCen_TextChanged;
            txtCen.KeyPress += txtCen_KeyPress;
            // 
            // txtfah
            // 
            txtfah.Location = new Point(194, 170);
            txtfah.Name = "txtfah";
            txtfah.Size = new Size(170, 23);
            txtfah.TabIndex = 3;
            txtfah.KeyPress += txtfah_KeyPress;
            // 
            // btnAcep
            // 
            btnAcep.Location = new Point(219, 265);
            btnAcep.Name = "btnAcep";
            btnAcep.Size = new Size(118, 45);
            btnAcep.TabIndex = 4;
            btnAcep.Text = "Aceptar";
            btnAcep.UseVisualStyleBackColor = true;
            btnAcep.Click += btnAcep_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 345);
            Controls.Add(btnAcep);
            Controls.Add(txtfah);
            Controls.Add(txtCen);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Convertidor de temperatura";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCen;
        private TextBox txtfah;
        private Button btnAcep;
    }
}
