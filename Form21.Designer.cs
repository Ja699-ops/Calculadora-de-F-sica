namespace PROYECTO_FINAL_FÍSICA
{
    partial class Form21
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
            btsalir = new Button();
            btAtras = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btsalir
            // 
            btsalir.BackColor = Color.Silver;
            btsalir.FlatStyle = FlatStyle.Flat;
            btsalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btsalir.Location = new Point(407, 409);
            btsalir.Name = "btsalir";
            btsalir.Size = new Size(111, 29);
            btsalir.TabIndex = 5;
            btsalir.Text = "Salir";
            btsalir.UseVisualStyleBackColor = false;
            btsalir.Click += btsalir_Click;
            // 
            // btAtras
            // 
            btAtras.BackColor = Color.Silver;
            btAtras.FlatStyle = FlatStyle.Flat;
            btAtras.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btAtras.Location = new Point(281, 409);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(120, 29);
            btAtras.TabIndex = 4;
            btAtras.Text = "Volver Atras";
            btAtras.UseVisualStyleBackColor = false;
            btAtras.Click += btAtras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 201);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(336, 47);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 7;
            label2.Text = "Ejemplos:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2024_05_11_012019;
            pictureBox1.Location = new Point(111, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form21
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Documento_A4_lista_de_tareas_ilustrado_beige2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btsalir);
            Controls.Add(btAtras);
            DoubleBuffered = true;
            Name = "Form21";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form21";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btsalir;
        private Button btAtras;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}