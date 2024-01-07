namespace GerenciadorDeTarefas.Views
{
    partial class TelaCriacaoTarefa
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
            this.button1 = new System.Windows.Forms.Button();
            this.panelCriarTarefa = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelCriarTarefa
            // 
            this.panelCriarTarefa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelCriarTarefa.Location = new System.Drawing.Point(653, -3);
            this.panelCriarTarefa.Name = "panelCriarTarefa";
            this.panelCriarTarefa.Size = new System.Drawing.Size(615, 797);
            this.panelCriarTarefa.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(281, 315);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // TelaCriacaoTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 792);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panelCriarTarefa);
            this.Controls.Add(this.button1);
            this.Name = "TelaCriacaoTarefa";
            this.Text = "TelaCriaçãoTarefa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelCriarTarefa;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}