namespace PingPong
{
    partial class frmDificuldade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDificuldade));
            btnIniciante = new Button();
            btnMedio = new Button();
            btnAvancado = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIniciante
            // 
            btnIniciante.BackColor = Color.Lime;
            btnIniciante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciante.Location = new Point(50, 120);
            btnIniciante.Margin = new Padding(3, 4, 3, 4);
            btnIniciante.Name = "btnIniciante";
            btnIniciante.Size = new Size(286, 70);
            btnIniciante.TabIndex = 0;
            btnIniciante.Text = "Iniciante";
            btnIniciante.UseVisualStyleBackColor = false;
            btnIniciante.Click += btnIniciante_Click;
            // 
            // btnMedio
            // 
            btnMedio.BackColor = Color.Yellow;
            btnMedio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMedio.Location = new Point(50, 213);
            btnMedio.Margin = new Padding(3, 4, 3, 4);
            btnMedio.Name = "btnMedio";
            btnMedio.Size = new Size(286, 70);
            btnMedio.TabIndex = 1;
            btnMedio.Text = "Intermediário";
            btnMedio.UseVisualStyleBackColor = false;
            btnMedio.Click += btnMedio_Click;
            // 
            // btnAvancado
            // 
            btnAvancado.BackColor = Color.Red;
            btnAvancado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAvancado.Location = new Point(50, 309);
            btnAvancado.Margin = new Padding(3, 4, 3, 4);
            btnAvancado.Name = "btnAvancado";
            btnAvancado.Size = new Size(286, 70);
            btnAvancado.TabIndex = 2;
            btnAvancado.Text = "Avançado";
            btnAvancado.UseVisualStyleBackColor = false;
            btnAvancado.Click += btnAvancado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(94, 50);
            label1.Name = "label1";
            label1.Size = new Size(191, 45);
            label1.TabIndex = 3;
            label1.Text = "Dificuldade";
            // 
            // frmDificuldade
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(386, 428);
            Controls.Add(label1);
            Controls.Add(btnAvancado);
            Controls.Add(btnMedio);
            Controls.Add(btnIniciante);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDificuldade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ping Pong 2: O Inimigo agora é outro!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciante;
        private Button btnMedio;
        private Button btnAvancado;
        private Label label1;
    }
}