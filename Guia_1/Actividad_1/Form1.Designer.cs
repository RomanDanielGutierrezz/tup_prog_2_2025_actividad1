namespace Actividad_1
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
            tbDescripcion = new TextBox();
            btnDescribir = new Button();
            SuspendLayout();
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(12, 12);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(392, 429);
            tbDescripcion.TabIndex = 0;
            // 
            // btnDescribir
            // 
            btnDescribir.Location = new Point(410, 162);
            btnDescribir.Name = "btnDescribir";
            btnDescribir.Size = new Size(156, 115);
            btnDescribir.TabIndex = 1;
            btnDescribir.Text = "Construir y Describir objetos";
            btnDescribir.UseVisualStyleBackColor = true;
            btnDescribir.Click += btnDescribir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 453);
            Controls.Add(btnDescribir);
            Controls.Add(tbDescripcion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDescripcion;
        private Button btnDescribir;
    }
}
