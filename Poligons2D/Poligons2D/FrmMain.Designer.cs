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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbPoligons = new System.Windows.Forms.Label();
            this.dgPoligons = new System.Windows.Forms.DataGridView();
            this.cbGrup = new System.Windows.Forms.ComboBox();
            this.lbGrup = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.pnlDibuixos = new System.Windows.Forms.Panel();
            this.lbDibuixos = new System.Windows.Forms.Label();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.chk_totes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPoligons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPoligons
            // 
            this.lbPoligons.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbPoligons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPoligons.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoligons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPoligons.Location = new System.Drawing.Point(16, 69);
            this.lbPoligons.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPoligons.Name = "lbPoligons";
            this.lbPoligons.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbPoligons.Size = new System.Drawing.Size(713, 32);
            this.lbPoligons.TabIndex = 8;
            this.lbPoligons.Text = "Poligons";
            this.lbPoligons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgPoligons
            // 
            this.dgPoligons.AllowUserToAddRows = false;
            this.dgPoligons.AllowUserToDeleteRows = false;
            this.dgPoligons.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgPoligons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPoligons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPoligons.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgPoligons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPoligons.Location = new System.Drawing.Point(16, 106);
            this.dgPoligons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgPoligons.MultiSelect = false;
            this.dgPoligons.Name = "dgPoligons";
            this.dgPoligons.ReadOnly = true;
            this.dgPoligons.RowHeadersVisible = false;
            this.dgPoligons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPoligons.Size = new System.Drawing.Size(713, 843);
            this.dgPoligons.TabIndex = 9;
            this.dgPoligons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPoligons_CellContentClick);
            // 
            // cbGrup
            // 
            this.cbGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrup.FormattingEnabled = true;
            this.cbGrup.Location = new System.Drawing.Point(190, 16);
            this.cbGrup.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbGrup.Name = "cbGrup";
            this.cbGrup.Size = new System.Drawing.Size(719, 25);
            this.cbGrup.TabIndex = 10;
            this.cbGrup.SelectedIndexChanged += new System.EventHandler(this.cbGrup_SelectedIndexChanged);
            // 
            // lbGrup
            // 
            this.lbGrup.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbGrup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGrup.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbGrup.Location = new System.Drawing.Point(16, 16);
            this.lbGrup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbGrup.Name = "lbGrup";
            this.lbGrup.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbGrup.Size = new System.Drawing.Size(164, 32);
            this.lbGrup.TabIndex = 11;
            this.lbGrup.Text = "Tria un grup";
            this.lbGrup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbInfo.Location = new System.Drawing.Point(738, 811);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(683, 137);
            this.tbInfo.TabIndex = 12;
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::Poligons2D.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(16, 962);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(67, 68);
            this.pbAdd.TabIndex = 13;
            this.pbAdd.TabStop = false;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbInfo.Location = new System.Drawing.Point(738, 760);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbInfo.Size = new System.Drawing.Size(683, 32);
            this.lbInfo.TabIndex = 14;
            this.lbInfo.Text = "Informació de poligon";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDibuixos
            // 
            this.pnlDibuixos.BackColor = System.Drawing.Color.White;
            this.pnlDibuixos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDibuixos.Location = new System.Drawing.Point(738, 106);
            this.pnlDibuixos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDibuixos.Name = "pnlDibuixos";
            this.pnlDibuixos.Size = new System.Drawing.Size(683, 633);
            this.pnlDibuixos.TabIndex = 15;
            // 
            // lbDibuixos
            // 
            this.lbDibuixos.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbDibuixos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDibuixos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDibuixos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDibuixos.Location = new System.Drawing.Point(737, 69);
            this.lbDibuixos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDibuixos.Name = "lbDibuixos";
            this.lbDibuixos.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbDibuixos.Size = new System.Drawing.Size(684, 32);
            this.lbDibuixos.TabIndex = 16;
            this.lbDibuixos.Text = "Dibuixar Poligons";
            this.lbDibuixos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::Poligons2D.Properties.Resources.cancel50;
            this.pbDelete.Location = new System.Drawing.Point(113, 962);
            this.pbDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(67, 68);
            this.pbDelete.TabIndex = 17;
            this.pbDelete.TabStop = false;
            // 
            // chk_totes
            // 
            this.chk_totes.AutoSize = true;
            this.chk_totes.Location = new System.Drawing.Point(927, 18);
            this.chk_totes.Name = "chk_totes";
            this.chk_totes.Size = new System.Drawing.Size(51, 21);
            this.chk_totes.TabIndex = 18;
            this.chk_totes.Text = "Tots";
            this.chk_totes.UseVisualStyleBackColor = true;
            this.chk_totes.CheckedChanged += new System.EventHandler(this.chk_totes_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1434, 1044);
            this.Controls.Add(this.chk_totes);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.lbDibuixos);
            this.Controls.Add(this.pnlDibuixos);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lbGrup);
            this.Controls.Add(this.cbGrup);
            this.Controls.Add(this.dgPoligons);
            this.Controls.Add(this.lbPoligons);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPoligons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgPoligons;
        private System.Windows.Forms.ComboBox cbGrup;
        private System.Windows.Forms.Label lbGrup;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Panel pnlDibuixos;
        private System.Windows.Forms.Label lbDibuixos;
        private System.Windows.Forms.PictureBox pbDelete;
        protected System.Windows.Forms.Label lbPoligons;
        private System.Windows.Forms.CheckBox chk_totes;
    }
}

