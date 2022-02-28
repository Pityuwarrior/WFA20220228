
namespace WFA20220114
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vizsgákToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újVizsgázóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.sorszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizsgákToolStripMenuItem,
            this.újVizsgázóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vizsgákToolStripMenuItem
            // 
            this.vizsgákToolStripMenuItem.Name = "vizsgákToolStripMenuItem";
            this.vizsgákToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.vizsgákToolStripMenuItem.Text = "Vizsgák";
            this.vizsgákToolStripMenuItem.Click += new System.EventHandler(this.vizsgákToolStripMenuItem_Click);
            // 
            // újVizsgázóToolStripMenuItem
            // 
            this.újVizsgázóToolStripMenuItem.Name = "újVizsgázóToolStripMenuItem";
            this.újVizsgázóToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.újVizsgázóToolStripMenuItem.Text = "Új Vizsgázó";
            this.újVizsgázóToolStripMenuItem.Click += new System.EventHandler(this.újVizsgázóToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sorszam,
            this.nev,
            this.nyelv,
            this.szint});
            this.dgv.Location = new System.Drawing.Point(12, 27);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(597, 323);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // sorszam
            // 
            this.sorszam.HeaderText = "Szorszám";
            this.sorszam.Name = "sorszam";
            // 
            // nev
            // 
            this.nev.HeaderText = "Vizsgázó Neve";
            this.nev.Name = "nev";
            // 
            // nyelv
            // 
            this.nyelv.HeaderText = "Nyelv";
            this.nyelv.Name = "nyelv";
            // 
            // szint
            // 
            this.szint.HeaderText = "Szint";
            this.szint.Name = "szint";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 362);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizsgákToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újVizsgázóToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn sorszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn szint;
    }
}

