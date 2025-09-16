namespace Ejercicio1
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
            gbAltaRegistro = new GroupBox();
            tbPatente = new TextBox();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRegistrar = new Button();
            btnVerRegistros = new Button();
            gbAltaRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // gbAltaRegistro
            // 
            gbAltaRegistro.Controls.Add(tbPatente);
            gbAltaRegistro.Controls.Add(tbNombre);
            gbAltaRegistro.Controls.Add(tbDNI);
            gbAltaRegistro.Controls.Add(label3);
            gbAltaRegistro.Controls.Add(label2);
            gbAltaRegistro.Controls.Add(label1);
            gbAltaRegistro.Controls.Add(btnRegistrar);
            gbAltaRegistro.Location = new Point(12, 12);
            gbAltaRegistro.Name = "gbAltaRegistro";
            gbAltaRegistro.Size = new Size(364, 157);
            gbAltaRegistro.TabIndex = 0;
            gbAltaRegistro.TabStop = false;
            gbAltaRegistro.Text = "Alta de Registro";
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(97, 95);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(146, 23);
            tbPatente.TabIndex = 6;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(97, 62);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(146, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(97, 26);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(146, 23);
            tbDNI.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 98);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Patente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 62);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(272, 49);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 40);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerRegistros
            // 
            btnVerRegistros.Location = new Point(155, 175);
            btnVerRegistros.Name = "btnVerRegistros";
            btnVerRegistros.Size = new Size(91, 40);
            btnVerRegistros.TabIndex = 4;
            btnVerRegistros.Text = "Ver Registros";
            btnVerRegistros.UseVisualStyleBackColor = true;
            btnVerRegistros.Click += btnVerRegistros_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 227);
            Controls.Add(btnVerRegistros);
            Controls.Add(gbAltaRegistro);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            gbAltaRegistro.ResumeLayout(false);
            gbAltaRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAltaRegistro;
        private TextBox tbPatente;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRegistrar;
        private Button btnVerRegistros;
    }
}
