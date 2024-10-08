namespace TrafficLightSimulationGUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel PanelRed;
        private System.Windows.Forms.Panel PanelYellow;
        private System.Windows.Forms.Panel PanelGreen;
        private System.Windows.Forms.Button ButtonPedestrian;
        private System.Windows.Forms.Label LabelCountdown;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.PanelRed = new System.Windows.Forms.Panel();
            this.PanelYellow = new System.Windows.Forms.Panel();
            this.PanelGreen = new System.Windows.Forms.Panel();
            this.ButtonPedestrian = new System.Windows.Forms.Button();
            this.LabelCountdown = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 260); // Tamanho ajustado do formulário
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; // Centraliza o formulário na tela
            this.Controls.Add(this.PanelRed);
            this.Controls.Add(this.PanelYellow);
            this.Controls.Add(this.PanelGreen);
            this.Controls.Add(this.ButtonPedestrian);
            this.Controls.Add(this.LabelCountdown);
            this.Name = "Form1";
            this.Text = "Simulador de Semáforo";
            this.ResumeLayout(false);

            // 
            // PanelRed
            // 
            this.PanelRed.BackColor = System.Drawing.Color.Gray;
            this.PanelRed.Location = new System.Drawing.Point((this.ClientSize.Width - 50) / 2, 30);
            this.PanelRed.Name = "PanelRed";
            this.PanelRed.Size = new System.Drawing.Size(50, 50);

            // 
            // PanelYellow
            // 
            this.PanelYellow.BackColor = System.Drawing.Color.Gray;
            this.PanelYellow.Location = new System.Drawing.Point((this.ClientSize.Width - 50) / 2, 90);
            this.PanelYellow.Name = "PanelYellow";
            this.PanelYellow.Size = new System.Drawing.Size(50, 50);

            // 
            // PanelGreen
            // 
            this.PanelGreen.BackColor = System.Drawing.Color.Gray;
            this.PanelGreen.Location = new System.Drawing.Point((this.ClientSize.Width - 50) / 2, 150);
            this.PanelGreen.Name = "PanelGreen";
            this.PanelGreen.Size = new System.Drawing.Size(50, 50);

            // 
            // ButtonPedestrian
            // 
            this.ButtonPedestrian.Location = new System.Drawing.Point((this.ClientSize.Width - 90) / 2, 220);
            this.ButtonPedestrian.Name = "ButtonPedestrian";
            this.ButtonPedestrian.Size = new System.Drawing.Size(90, 30);
            this.ButtonPedestrian.Text = "Pedestre";
            this.ButtonPedestrian.UseVisualStyleBackColor = true;
            this.ButtonPedestrian.Click += new System.EventHandler(this.ButtonPedestrian_Click);

            // 
            // LabelCountdown
            // 
            this.LabelCountdown.Location = new System.Drawing.Point((this.ClientSize.Width - 90) / 2, 270);
            this.LabelCountdown.Name = "LabelCountdown";
            this.LabelCountdown.Size = new System.Drawing.Size(90, 20);
            this.LabelCountdown.Text = "";
            this.LabelCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        #endregion
    }
}
