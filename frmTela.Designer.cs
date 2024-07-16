namespace PingPong
{
    partial class frmTela
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTela));
            timer1 = new System.Windows.Forms.Timer(components);
            picRaquete = new Panel();
            picBola = new PictureBox();
            picFundo = new PictureBox();
            pnlBotoes = new Panel();
            button2 = new Button();
            button1 = new Button();
            lblPontos = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picBola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFundo).BeginInit();
            pnlBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // picRaquete
            // 
            picRaquete.BackColor = SystemColors.ActiveCaptionText;
            picRaquete.Location = new Point(896, 123);
            picRaquete.Margin = new Padding(3, 4, 3, 4);
            picRaquete.Name = "picRaquete";
            picRaquete.Size = new Size(11, 284);
            picRaquete.TabIndex = 0;
            // 
            // picBola
            // 
            picBola.BackColor = Color.RoyalBlue;
            picBola.BackgroundImageLayout = ImageLayout.None;
            picBola.Image = (Image)resources.GetObject("picBola.Image");
            picBola.Location = new Point(238, 183);
            picBola.Margin = new Padding(3, 4, 3, 4);
            picBola.Name = "picBola";
            picBola.Size = new Size(19, 19);
            picBola.SizeMode = PictureBoxSizeMode.StretchImage;
            picBola.TabIndex = 1;
            picBola.TabStop = false;
            // 
            // picFundo
            // 
            picFundo.Image = (Image)resources.GetObject("picFundo.Image");
            picFundo.Location = new Point(0, -1);
            picFundo.Margin = new Padding(3, 4, 3, 4);
            picFundo.Name = "picFundo";
            picFundo.Size = new Size(914, 504);
            picFundo.SizeMode = PictureBoxSizeMode.StretchImage;
            picFundo.TabIndex = 2;
            picFundo.TabStop = false;
            picFundo.MouseMove += Form1_MouseMove;
            // 
            // pnlBotoes
            // 
            pnlBotoes.BackColor = SystemColors.ControlDarkDark;
            pnlBotoes.BackgroundImage = (Image)resources.GetObject("pnlBotoes.BackgroundImage");
            pnlBotoes.Controls.Add(button2);
            pnlBotoes.Controls.Add(button1);
            pnlBotoes.Controls.Add(lblPontos);
            pnlBotoes.Controls.Add(label1);
            pnlBotoes.Dock = DockStyle.Bottom;
            pnlBotoes.Location = new Point(0, 504);
            pnlBotoes.Margin = new Padding(3, 4, 3, 4);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(914, 66);
            pnlBotoes.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(741, 13);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(160, 43);
            button2.TabIndex = 3;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(394, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 43);
            button1.TabIndex = 2;
            button1.Text = "Alterar Dificuldade";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblPontos
            // 
            lblPontos.AutoSize = true;
            lblPontos.BackColor = Color.Transparent;
            lblPontos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPontos.ForeColor = SystemColors.ControlLightLight;
            lblPontos.Location = new Point(135, 16);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(34, 40);
            lblPontos.TabIndex = 1;
            lblPontos.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 40);
            label1.TabIndex = 0;
            label1.Text = "PONTOS:";
            // 
            // frmTela
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(914, 570);
            Controls.Add(pnlBotoes);
            Controls.Add(picBola);
            Controls.Add(picRaquete);
            Controls.Add(picFundo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTela";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBola).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFundo).EndInit();
            pnlBotoes.ResumeLayout(false);
            pnlBotoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel picRaquete;
        private PictureBox picBola;
        private PictureBox picFundo;
        private Panel pnlBotoes;
        private Label label1;
        private Label lblPontos;
        private Button button1;
        private Button button2;
    }
}