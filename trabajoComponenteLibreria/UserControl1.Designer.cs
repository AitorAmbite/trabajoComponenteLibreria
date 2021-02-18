namespace trabajoComponenteLibreria
{
    partial class UserControl1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.vueltaButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 10);
            this.label1.MinimumSize = new System.Drawing.Size(300, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vueltaButton
            // 
            this.vueltaButton.Enabled = false;
            this.vueltaButton.Location = new System.Drawing.Point(170, 113);
            this.vueltaButton.Name = "vueltaButton";
            this.vueltaButton.Size = new System.Drawing.Size(75, 40);
            this.vueltaButton.TabIndex = 1;
            this.vueltaButton.Text = "Vuelta";
            this.vueltaButton.UseVisualStyleBackColor = true;
            this.vueltaButton.Click += new System.EventHandler(this.vueltaButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(251, 113);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 40);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Parar";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(332, 113);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 40);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Iniciar";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Enabled = false;
            this.restartButton.Location = new System.Drawing.Point(89, 113);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 40);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "Reiniciar";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(89, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 95);
            this.listBox1.TabIndex = 5;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.vueltaButton);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(500, 327);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vueltaButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
