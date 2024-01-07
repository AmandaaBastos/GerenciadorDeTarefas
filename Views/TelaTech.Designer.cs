namespace GerenciadorDeTarefas.Views
{
    partial class TelaTech
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTodasTarefas = new System.Windows.Forms.TabPage();
            this.listTodasTarefas = new System.Windows.Forms.ListView();
            this.tabTarefasAtraso = new System.Windows.Forms.TabPage();
            this.listTarefasAtraso = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listTarefaAnalise = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listTarefaImpedimento = new System.Windows.Forms.ListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listTarefaAbandonada = new System.Windows.Forms.ListView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listTarefaConcluida = new System.Windows.Forms.ListView();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageTodasTarefas.SuspendLayout();
            this.tabTarefasAtraso.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1298, 87);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1048, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Criar Nova Tarefa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 2;            
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTodasTarefas);
            this.tabControl1.Controls.Add(this.tabTarefasAtraso);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.tabControl1.Location = new System.Drawing.Point(12, 109);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1250, 674);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageTodasTarefas
            // 
            this.tabPageTodasTarefas.Controls.Add(this.listTodasTarefas);
            this.tabPageTodasTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTodasTarefas.Location = new System.Drawing.Point(4, 44);
            this.tabPageTodasTarefas.Name = "tabPageTodasTarefas";
            this.tabPageTodasTarefas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTodasTarefas.Size = new System.Drawing.Size(1242, 626);
            this.tabPageTodasTarefas.TabIndex = 0;
            this.tabPageTodasTarefas.Text = "Todas";
            this.tabPageTodasTarefas.UseVisualStyleBackColor = true;
            // 
            // listTodasTarefas
            // 
            this.listTodasTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTodasTarefas.GridLines = true;
            this.listTodasTarefas.HideSelection = false;
            this.listTodasTarefas.Location = new System.Drawing.Point(6, 6);
            this.listTodasTarefas.Name = "listTodasTarefas";
            this.listTodasTarefas.Size = new System.Drawing.Size(1230, 614);
            this.listTodasTarefas.TabIndex = 0;
            this.listTodasTarefas.UseCompatibleStateImageBehavior = false;
            // 
            // tabTarefasAtraso
            // 
            this.tabTarefasAtraso.Controls.Add(this.listTarefasAtraso);
            this.tabTarefasAtraso.Location = new System.Drawing.Point(4, 44);
            this.tabTarefasAtraso.Name = "tabTarefasAtraso";
            this.tabTarefasAtraso.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefasAtraso.Size = new System.Drawing.Size(1242, 626);
            this.tabTarefasAtraso.TabIndex = 1;
            this.tabTarefasAtraso.Text = "Em Atraso";
            this.tabTarefasAtraso.UseVisualStyleBackColor = true;
            // 
            // listTarefasAtraso
            // 
            this.listTarefasAtraso.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTarefasAtraso.GridLines = true;
            this.listTarefasAtraso.HideSelection = false;
            this.listTarefasAtraso.Location = new System.Drawing.Point(6, 6);
            this.listTarefasAtraso.Name = "listTarefasAtraso";
            this.listTarefasAtraso.Size = new System.Drawing.Size(1230, 614);
            this.listTarefasAtraso.TabIndex = 1;
            this.listTarefasAtraso.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listTarefaAnalise);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1242, 626);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Em Análise";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listTarefaAnalise
            // 
            this.listTarefaAnalise.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTarefaAnalise.GridLines = true;
            this.listTarefaAnalise.HideSelection = false;
            this.listTarefaAnalise.Location = new System.Drawing.Point(6, 6);
            this.listTarefaAnalise.Name = "listTarefaAnalise";
            this.listTarefaAnalise.Size = new System.Drawing.Size(1230, 614);
            this.listTarefaAnalise.TabIndex = 2;
            this.listTarefaAnalise.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listTarefaImpedimento);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1242, 626);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Com Impedimento";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listTarefaImpedimento
            // 
            this.listTarefaImpedimento.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTarefaImpedimento.GridLines = true;
            this.listTarefaImpedimento.HideSelection = false;
            this.listTarefaImpedimento.Location = new System.Drawing.Point(6, 6);
            this.listTarefaImpedimento.Name = "listTarefaImpedimento";
            this.listTarefaImpedimento.Size = new System.Drawing.Size(1230, 614);
            this.listTarefaImpedimento.TabIndex = 2;
            this.listTarefaImpedimento.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listTarefaAbandonada);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1242, 626);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Abandonadas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listTarefaAbandonada
            // 
            this.listTarefaAbandonada.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTarefaAbandonada.GridLines = true;
            this.listTarefaAbandonada.HideSelection = false;
            this.listTarefaAbandonada.Location = new System.Drawing.Point(6, 6);
            this.listTarefaAbandonada.Name = "listTarefaAbandonada";
            this.listTarefaAbandonada.Size = new System.Drawing.Size(1230, 614);
            this.listTarefaAbandonada.TabIndex = 2;
            this.listTarefaAbandonada.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listTarefaConcluida);
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1242, 626);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Concluídas";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listTarefaConcluida
            // 
            this.listTarefaConcluida.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTarefaConcluida.GridLines = true;
            this.listTarefaConcluida.HideSelection = false;
            this.listTarefaConcluida.Location = new System.Drawing.Point(6, 6);
            this.listTarefaConcluida.Name = "listTarefaConcluida";
            this.listTarefaConcluida.Size = new System.Drawing.Size(1230, 614);
            this.listTarefaConcluida.TabIndex = 2;
            this.listTarefaConcluida.UseCompatibleStateImageBehavior = false;
            // 
            // TelaTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 792);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Name = "TelaTech";
            this.Text = "TelaDev";
            this.Load += new System.EventHandler(this.TelaTech_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTodasTarefas.ResumeLayout(false);
            this.tabTarefasAtraso.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTodasTarefas;
        private System.Windows.Forms.TabPage tabTarefasAtraso;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListView listTodasTarefas;
        private System.Windows.Forms.ListView listTarefasAtraso;
        private System.Windows.Forms.ListView listTarefaAnalise;
        private System.Windows.Forms.ListView listTarefaImpedimento;
        private System.Windows.Forms.ListView listTarefaAbandonada;
        private System.Windows.Forms.ListView listTarefaConcluida;
    }
}