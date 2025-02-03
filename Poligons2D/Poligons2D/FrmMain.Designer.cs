namespace Poligons2D
{
    partial class FrmMain
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbPersonatges = new System.Windows.Forms.Label();
            this.dgPersonatges = new System.Windows.Forms.DataGridView();
            this.cbGrup = new System.Windows.Forms.ComboBox();
            this.lbGrup = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonatges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPersonatges
            // 
            this.lbPersonatges.BackColor = System.Drawing.Color.LightGray;
            this.lbPersonatges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPersonatges.Location = new System.Drawing.Point(12, 53);
            this.lbPersonatges.Name = "lbPersonatges";
            this.lbPersonatges.Padding = new System.Windows.Forms.Padding(3);
            this.lbPersonatges.Size = new System.Drawing.Size(535, 25);
            this.lbPersonatges.TabIndex = 8;
            this.lbPersonatges.Text = "Personatges";
            this.lbPersonatges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPersonatges
            // 
            this.dgPersonatges.AllowUserToAddRows = false;
            this.dgPersonatges.AllowUserToDeleteRows = false;
            this.dgPersonatges.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgPersonatges.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPersonatges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgPersonatges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonatges.Location = new System.Drawing.Point(12, 81);
            this.dgPersonatges.MultiSelect = false;
            this.dgPersonatges.Name = "dgPersonatges";
            this.dgPersonatges.ReadOnly = true;
            this.dgPersonatges.RowHeadersVisible = false;
            this.dgPersonatges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPersonatges.Size = new System.Drawing.Size(535, 644);
            this.dgPersonatges.TabIndex = 9;
            // 
            // cbGrup
            // 
            this.cbGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrup.FormattingEnabled = true;
            this.cbGrup.Items.AddRange(new object[] {
            "Tots",
            "Balrogs",
            "Elfs",
            "Hobbits",
            "Humans",
            "Mags",
            "Nans",
            "Nazguls",
            "Orcs",
            "Trolls",
            "UrukHais"});
            this.cbGrup.Location = new System.Drawing.Point(142, 12);
            this.cbGrup.Name = "cbGrup";
            this.cbGrup.Size = new System.Drawing.Size(343, 21);
            this.cbGrup.TabIndex = 10;
            // 
            // lbGrup
            // 
            this.lbGrup.BackColor = System.Drawing.Color.LightGray;
            this.lbGrup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGrup.Location = new System.Drawing.Point(12, 12);
            this.lbGrup.Name = "lbGrup";
            this.lbGrup.Padding = new System.Windows.Forms.Padding(3);
            this.lbGrup.Size = new System.Drawing.Size(124, 25);
            this.lbGrup.TabIndex = 11;
            this.lbGrup.Text = "Tria un grup";
            this.lbGrup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(554, 620);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(513, 105);
            this.tbInfo.TabIndex = 12;
            // 
            // pbAdd
            // 
            this.pbAdd.Location = new System.Drawing.Point(12, 735);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(51, 52);
            this.pbAdd.TabIndex = 13;
            this.pbAdd.TabStop = false;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.LightGray;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo.Location = new System.Drawing.Point(554, 581);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Padding = new System.Windows.Forms.Padding(3);
            this.lbInfo.Size = new System.Drawing.Size(513, 25);
            this.lbInfo.TabIndex = 14;
            this.lbInfo.Text = "Informació del personatge";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(554, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 485);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(553, 53);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(514, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Personatges";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 799);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lbGrup);
            this.Controls.Add(this.cbGrup);
            this.Controls.Add(this.dgPersonatges);
            this.Controls.Add(this.lbPersonatges);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonatges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPersonatges;
        private System.Windows.Forms.DataGridView dgPersonatges;
        private System.Windows.Forms.ComboBox cbGrup;
        private System.Windows.Forms.Label lbGrup;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

