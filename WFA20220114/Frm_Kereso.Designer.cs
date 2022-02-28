
namespace WFA20220114
{
    partial class Frm_Kereso
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_keres = new System.Windows.Forms.DataGridView();
            this.cb_keres = new System.Windows.Forms.ComboBox();
            this.idopont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyelv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keresés:";
            // 
            // dgv_keres
            // 
            this.dgv_keres.AllowUserToAddRows = false;
            this.dgv_keres.AllowUserToDeleteRows = false;
            this.dgv_keres.AllowUserToResizeColumns = false;
            this.dgv_keres.AllowUserToResizeRows = false;
            this.dgv_keres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_keres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_keres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idopont,
            this.nyelv,
            this.szint});
            this.dgv_keres.Location = new System.Drawing.Point(12, 38);
            this.dgv_keres.Name = "dgv_keres";
            this.dgv_keres.RowHeadersVisible = false;
            this.dgv_keres.Size = new System.Drawing.Size(494, 265);
            this.dgv_keres.TabIndex = 2;
            // 
            // cb_keres
            // 
            this.cb_keres.FormattingEnabled = true;
            this.cb_keres.Location = new System.Drawing.Point(66, 12);
            this.cb_keres.Name = "cb_keres";
            this.cb_keres.Size = new System.Drawing.Size(161, 21);
            this.cb_keres.TabIndex = 3;
            this.cb_keres.SelectedIndexChanged += new System.EventHandler(this.cb_keres_SelectedIndexChanged);
            // 
            // idopont
            // 
            this.idopont.HeaderText = "Időpont";
            this.idopont.Name = "idopont";
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
            // Frm_Kereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 315);
            this.Controls.Add(this.cb_keres);
            this.Controls.Add(this.dgv_keres);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Kereso";
            this.Text = "Frm_Kereso";
            this.Load += new System.EventHandler(this.Frm_Kereso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_keres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_keres;
        private System.Windows.Forms.ComboBox cb_keres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopont;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyelv;
        private System.Windows.Forms.DataGridViewTextBoxColumn szint;
    }
}