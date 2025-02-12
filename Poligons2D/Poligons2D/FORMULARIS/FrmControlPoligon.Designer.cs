namespace Poligons2D.FORMULARIS
{
    partial class FrmControlPoligon
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
            this.gbGrup = new System.Windows.Forms.GroupBox();
            this.rdOctogons = new System.Windows.Forms.RadioButton();
            this.rdHexagons = new System.Windows.Forms.RadioButton();
            this.rdPentagons = new System.Windows.Forms.RadioButton();
            this.rdRombes = new System.Windows.Forms.RadioButton();
            this.rdNanTrianglesIsosceles = new System.Windows.Forms.RadioButton();
            this.rdTrianglesRectangles = new System.Windows.Forms.RadioButton();
            this.rdElipses = new System.Windows.Forms.RadioButton();
            this.rdCercles = new System.Windows.Forms.RadioButton();
            this.rdRectangles = new System.Windows.Forms.RadioButton();
            this.rdQuadrats = new System.Windows.Forms.RadioButton();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.nupRadi = new System.Windows.Forms.NumericUpDown();
            this.lbRadi = new System.Windows.Forms.Label();
            this.lbRadiA = new System.Windows.Forms.Label();
            this.nupRadiA = new System.Windows.Forms.NumericUpDown();
            this.lbRadiB = new System.Windows.Forms.Label();
            this.nupRadiB = new System.Windows.Forms.NumericUpDown();
            this.lbCostat = new System.Windows.Forms.Label();
            this.nupCostat = new System.Windows.Forms.NumericUpDown();
            this.lbMida = new System.Windows.Forms.Label();
            this.nupMida = new System.Windows.Forms.NumericUpDown();
            this.lbBase = new System.Windows.Forms.Label();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.lbAlçada = new System.Windows.Forms.Label();
            this.nupAlçada = new System.Windows.Forms.NumericUpDown();
            this.lbDiagonalA = new System.Windows.Forms.Label();
            this.nupDiagonalA = new System.Windows.Forms.NumericUpDown();
            this.lbDiagonalB = new System.Windows.Forms.Label();
            this.nupDiagonalB = new System.Windows.Forms.NumericUpDown();
            this.lbDireccio = new System.Windows.Forms.Label();
            this.nupDireccio = new System.Windows.Forms.NumericUpDown();
            this.btNo = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.chkInterior = new System.Windows.Forms.CheckBox();
            this.pnlColorInterior = new System.Windows.Forms.Panel();
            this.lbColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.gbGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRadi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRadiA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRadiB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCostat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAlçada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiagonalA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiagonalB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDireccio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGrup
            // 
            this.gbGrup.Controls.Add(this.rdOctogons);
            this.gbGrup.Controls.Add(this.rdHexagons);
            this.gbGrup.Controls.Add(this.rdPentagons);
            this.gbGrup.Controls.Add(this.rdRombes);
            this.gbGrup.Controls.Add(this.rdNanTrianglesIsosceles);
            this.gbGrup.Controls.Add(this.rdTrianglesRectangles);
            this.gbGrup.Controls.Add(this.rdElipses);
            this.gbGrup.Controls.Add(this.rdCercles);
            this.gbGrup.Controls.Add(this.rdRectangles);
            this.gbGrup.Controls.Add(this.rdQuadrats);
            this.gbGrup.Location = new System.Drawing.Point(13, 13);
            this.gbGrup.Margin = new System.Windows.Forms.Padding(4);
            this.gbGrup.Name = "gbGrup";
            this.gbGrup.Padding = new System.Windows.Forms.Padding(4);
            this.gbGrup.Size = new System.Drawing.Size(326, 237);
            this.gbGrup.TabIndex = 1;
            this.gbGrup.TabStop = false;
            this.gbGrup.Text = " Grup de poligon";
            // 
            // rdOctogons
            // 
            this.rdOctogons.AutoSize = true;
            this.rdOctogons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdOctogons.Location = new System.Drawing.Point(195, 196);
            this.rdOctogons.Margin = new System.Windows.Forms.Padding(4);
            this.rdOctogons.Name = "rdOctogons";
            this.rdOctogons.Size = new System.Drawing.Size(66, 17);
            this.rdOctogons.TabIndex = 9;
            this.rdOctogons.Text = "Octogon";
            this.rdOctogons.UseVisualStyleBackColor = true;
            this.rdOctogons.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdHexagons
            // 
            this.rdHexagons.AutoSize = true;
            this.rdHexagons.Location = new System.Drawing.Point(195, 156);
            this.rdHexagons.Margin = new System.Windows.Forms.Padding(4);
            this.rdHexagons.Name = "rdHexagons";
            this.rdHexagons.Size = new System.Drawing.Size(68, 17);
            this.rdHexagons.TabIndex = 8;
            this.rdHexagons.Text = "Hexagon";
            this.rdHexagons.UseVisualStyleBackColor = true;
            this.rdHexagons.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdPentagons
            // 
            this.rdPentagons.AutoSize = true;
            this.rdPentagons.Location = new System.Drawing.Point(195, 117);
            this.rdPentagons.Margin = new System.Windows.Forms.Padding(4);
            this.rdPentagons.Name = "rdPentagons";
            this.rdPentagons.Size = new System.Drawing.Size(71, 17);
            this.rdPentagons.TabIndex = 7;
            this.rdPentagons.Text = "Pentagon";
            this.rdPentagons.UseVisualStyleBackColor = true;
            this.rdPentagons.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdRombes
            // 
            this.rdRombes.AutoSize = true;
            this.rdRombes.Location = new System.Drawing.Point(195, 79);
            this.rdRombes.Margin = new System.Windows.Forms.Padding(4);
            this.rdRombes.Name = "rdRombes";
            this.rdRombes.Size = new System.Drawing.Size(59, 17);
            this.rdRombes.TabIndex = 6;
            this.rdRombes.Text = "Rombe";
            this.rdRombes.UseVisualStyleBackColor = true;
            this.rdRombes.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdNanTrianglesIsosceles
            // 
            this.rdNanTrianglesIsosceles.AutoSize = true;
            this.rdNanTrianglesIsosceles.Location = new System.Drawing.Point(195, 42);
            this.rdNanTrianglesIsosceles.Margin = new System.Windows.Forms.Padding(4);
            this.rdNanTrianglesIsosceles.Name = "rdNanTrianglesIsosceles";
            this.rdNanTrianglesIsosceles.Size = new System.Drawing.Size(109, 17);
            this.rdNanTrianglesIsosceles.TabIndex = 5;
            this.rdNanTrianglesIsosceles.Text = "Triangles isòscele";
            this.rdNanTrianglesIsosceles.UseVisualStyleBackColor = true;
            this.rdNanTrianglesIsosceles.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdTrianglesRectangles
            // 
            this.rdTrianglesRectangles.AutoSize = true;
            this.rdTrianglesRectangles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdTrianglesRectangles.Location = new System.Drawing.Point(29, 196);
            this.rdTrianglesRectangles.Margin = new System.Windows.Forms.Padding(4);
            this.rdTrianglesRectangles.Name = "rdTrianglesRectangles";
            this.rdTrianglesRectangles.Size = new System.Drawing.Size(115, 17);
            this.rdTrianglesRectangles.TabIndex = 4;
            this.rdTrianglesRectangles.Text = "Triangles rectangle";
            this.rdTrianglesRectangles.UseVisualStyleBackColor = true;
            this.rdTrianglesRectangles.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdElipses
            // 
            this.rdElipses.AutoSize = true;
            this.rdElipses.Location = new System.Drawing.Point(29, 156);
            this.rdElipses.Margin = new System.Windows.Forms.Padding(4);
            this.rdElipses.Name = "rdElipses";
            this.rdElipses.Size = new System.Drawing.Size(53, 17);
            this.rdElipses.TabIndex = 3;
            this.rdElipses.Text = "Elipse";
            this.rdElipses.UseVisualStyleBackColor = true;
            this.rdElipses.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdCercles
            // 
            this.rdCercles.AutoSize = true;
            this.rdCercles.Location = new System.Drawing.Point(29, 117);
            this.rdCercles.Margin = new System.Windows.Forms.Padding(4);
            this.rdCercles.Name = "rdCercles";
            this.rdCercles.Size = new System.Drawing.Size(55, 17);
            this.rdCercles.TabIndex = 2;
            this.rdCercles.Tag = "";
            this.rdCercles.Text = "Cercle";
            this.rdCercles.UseVisualStyleBackColor = true;
            this.rdCercles.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdRectangles
            // 
            this.rdRectangles.AutoSize = true;
            this.rdRectangles.Location = new System.Drawing.Point(29, 79);
            this.rdRectangles.Margin = new System.Windows.Forms.Padding(4);
            this.rdRectangles.Name = "rdRectangles";
            this.rdRectangles.Size = new System.Drawing.Size(74, 17);
            this.rdRectangles.TabIndex = 1;
            this.rdRectangles.Tag = "";
            this.rdRectangles.Text = "Rectangle";
            this.rdRectangles.UseVisualStyleBackColor = true;
            this.rdRectangles.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // rdQuadrats
            // 
            this.rdQuadrats.AutoSize = true;
            this.rdQuadrats.Checked = true;
            this.rdQuadrats.Location = new System.Drawing.Point(29, 42);
            this.rdQuadrats.Margin = new System.Windows.Forms.Padding(4);
            this.rdQuadrats.Name = "rdQuadrats";
            this.rdQuadrats.Size = new System.Drawing.Size(63, 17);
            this.rdQuadrats.TabIndex = 0;
            this.rdQuadrats.TabStop = true;
            this.rdQuadrats.Tag = "";
            this.rdQuadrats.Text = "Quadrat";
            this.rdQuadrats.UseVisualStyleBackColor = true;
            this.rdQuadrats.CheckedChanged += new System.EventHandler(this.rdQuadrat_CheckedChanged);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(119, 266);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(219, 20);
            this.tbNom.TabIndex = 18;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.BackColor = System.Drawing.Color.DarkOrange;
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(12, 266);
            this.lbNom.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Padding = new System.Windows.Forms.Padding(3);
            this.lbNom.Size = new System.Drawing.Size(100, 19);
            this.lbNom.TabIndex = 17;
            this.lbNom.Text = "Nom";
            // 
            // nupRadi
            // 
            this.nupRadi.Location = new System.Drawing.Point(119, 292);
            this.nupRadi.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupRadi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupRadi.Name = "nupRadi";
            this.nupRadi.Size = new System.Drawing.Size(219, 20);
            this.nupRadi.TabIndex = 19;
            this.nupRadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupRadi.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbRadi
            // 
            this.lbRadi.AutoSize = true;
            this.lbRadi.BackColor = System.Drawing.Color.DarkOrange;
            this.lbRadi.ForeColor = System.Drawing.Color.White;
            this.lbRadi.Location = new System.Drawing.Point(13, 292);
            this.lbRadi.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbRadi.Name = "lbRadi";
            this.lbRadi.Padding = new System.Windows.Forms.Padding(3);
            this.lbRadi.Size = new System.Drawing.Size(100, 19);
            this.lbRadi.TabIndex = 20;
            this.lbRadi.Text = "Radi";
            // 
            // lbRadiA
            // 
            this.lbRadiA.AutoSize = true;
            this.lbRadiA.BackColor = System.Drawing.Color.DarkOrange;
            this.lbRadiA.ForeColor = System.Drawing.Color.White;
            this.lbRadiA.Location = new System.Drawing.Point(13, 318);
            this.lbRadiA.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbRadiA.Name = "lbRadiA";
            this.lbRadiA.Padding = new System.Windows.Forms.Padding(3);
            this.lbRadiA.Size = new System.Drawing.Size(100, 19);
            this.lbRadiA.TabIndex = 22;
            this.lbRadiA.Text = "Radi A";
            // 
            // nupRadiA
            // 
            this.nupRadiA.Location = new System.Drawing.Point(119, 318);
            this.nupRadiA.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupRadiA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupRadiA.Name = "nupRadiA";
            this.nupRadiA.Size = new System.Drawing.Size(219, 20);
            this.nupRadiA.TabIndex = 21;
            this.nupRadiA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupRadiA.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbRadiB
            // 
            this.lbRadiB.AutoSize = true;
            this.lbRadiB.BackColor = System.Drawing.Color.DarkOrange;
            this.lbRadiB.ForeColor = System.Drawing.Color.White;
            this.lbRadiB.Location = new System.Drawing.Point(13, 344);
            this.lbRadiB.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbRadiB.Name = "lbRadiB";
            this.lbRadiB.Padding = new System.Windows.Forms.Padding(3);
            this.lbRadiB.Size = new System.Drawing.Size(100, 19);
            this.lbRadiB.TabIndex = 24;
            this.lbRadiB.Text = "Radi B";
            // 
            // nupRadiB
            // 
            this.nupRadiB.Location = new System.Drawing.Point(119, 344);
            this.nupRadiB.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupRadiB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupRadiB.Name = "nupRadiB";
            this.nupRadiB.Size = new System.Drawing.Size(219, 20);
            this.nupRadiB.TabIndex = 23;
            this.nupRadiB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupRadiB.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbCostat
            // 
            this.lbCostat.AutoSize = true;
            this.lbCostat.BackColor = System.Drawing.Color.DarkOrange;
            this.lbCostat.ForeColor = System.Drawing.Color.White;
            this.lbCostat.Location = new System.Drawing.Point(13, 370);
            this.lbCostat.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbCostat.Name = "lbCostat";
            this.lbCostat.Padding = new System.Windows.Forms.Padding(3);
            this.lbCostat.Size = new System.Drawing.Size(100, 19);
            this.lbCostat.TabIndex = 26;
            this.lbCostat.Text = "Costat";
            // 
            // nupCostat
            // 
            this.nupCostat.Location = new System.Drawing.Point(119, 370);
            this.nupCostat.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupCostat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCostat.Name = "nupCostat";
            this.nupCostat.Size = new System.Drawing.Size(219, 20);
            this.nupCostat.TabIndex = 25;
            this.nupCostat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupCostat.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbMida
            // 
            this.lbMida.AutoSize = true;
            this.lbMida.BackColor = System.Drawing.Color.DarkOrange;
            this.lbMida.ForeColor = System.Drawing.Color.White;
            this.lbMida.Location = new System.Drawing.Point(13, 396);
            this.lbMida.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbMida.Name = "lbMida";
            this.lbMida.Padding = new System.Windows.Forms.Padding(3);
            this.lbMida.Size = new System.Drawing.Size(100, 19);
            this.lbMida.TabIndex = 28;
            this.lbMida.Text = "Mida";
            // 
            // nupMida
            // 
            this.nupMida.Location = new System.Drawing.Point(119, 396);
            this.nupMida.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupMida.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMida.Name = "nupMida";
            this.nupMida.Size = new System.Drawing.Size(219, 20);
            this.nupMida.TabIndex = 27;
            this.nupMida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupMida.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.BackColor = System.Drawing.Color.DarkOrange;
            this.lbBase.ForeColor = System.Drawing.Color.White;
            this.lbBase.Location = new System.Drawing.Point(13, 422);
            this.lbBase.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbBase.Name = "lbBase";
            this.lbBase.Padding = new System.Windows.Forms.Padding(3);
            this.lbBase.Size = new System.Drawing.Size(100, 19);
            this.lbBase.TabIndex = 30;
            this.lbBase.Text = "Base";
            // 
            // nupBase
            // 
            this.nupBase.Location = new System.Drawing.Point(119, 422);
            this.nupBase.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupBase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupBase.Name = "nupBase";
            this.nupBase.Size = new System.Drawing.Size(219, 20);
            this.nupBase.TabIndex = 29;
            this.nupBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupBase.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbAlçada
            // 
            this.lbAlçada.AutoSize = true;
            this.lbAlçada.BackColor = System.Drawing.Color.DarkOrange;
            this.lbAlçada.ForeColor = System.Drawing.Color.White;
            this.lbAlçada.Location = new System.Drawing.Point(13, 448);
            this.lbAlçada.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbAlçada.Name = "lbAlçada";
            this.lbAlçada.Padding = new System.Windows.Forms.Padding(3);
            this.lbAlçada.Size = new System.Drawing.Size(100, 19);
            this.lbAlçada.TabIndex = 32;
            this.lbAlçada.Text = "Alçada";
            // 
            // nupAlçada
            // 
            this.nupAlçada.Location = new System.Drawing.Point(119, 448);
            this.nupAlçada.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupAlçada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupAlçada.Name = "nupAlçada";
            this.nupAlçada.Size = new System.Drawing.Size(219, 20);
            this.nupAlçada.TabIndex = 31;
            this.nupAlçada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupAlçada.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbDiagonalA
            // 
            this.lbDiagonalA.AutoSize = true;
            this.lbDiagonalA.BackColor = System.Drawing.Color.DarkOrange;
            this.lbDiagonalA.ForeColor = System.Drawing.Color.White;
            this.lbDiagonalA.Location = new System.Drawing.Point(14, 500);
            this.lbDiagonalA.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbDiagonalA.Name = "lbDiagonalA";
            this.lbDiagonalA.Padding = new System.Windows.Forms.Padding(3);
            this.lbDiagonalA.Size = new System.Drawing.Size(100, 19);
            this.lbDiagonalA.TabIndex = 34;
            this.lbDiagonalA.Text = "Diagonal A";
            // 
            // nupDiagonalA
            // 
            this.nupDiagonalA.Location = new System.Drawing.Point(120, 500);
            this.nupDiagonalA.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupDiagonalA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDiagonalA.Name = "nupDiagonalA";
            this.nupDiagonalA.Size = new System.Drawing.Size(219, 20);
            this.nupDiagonalA.TabIndex = 33;
            this.nupDiagonalA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupDiagonalA.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbDiagonalB
            // 
            this.lbDiagonalB.AutoSize = true;
            this.lbDiagonalB.BackColor = System.Drawing.Color.DarkOrange;
            this.lbDiagonalB.ForeColor = System.Drawing.Color.White;
            this.lbDiagonalB.Location = new System.Drawing.Point(14, 528);
            this.lbDiagonalB.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbDiagonalB.Name = "lbDiagonalB";
            this.lbDiagonalB.Padding = new System.Windows.Forms.Padding(3);
            this.lbDiagonalB.Size = new System.Drawing.Size(100, 19);
            this.lbDiagonalB.TabIndex = 36;
            this.lbDiagonalB.Text = "Diagonal B";
            // 
            // nupDiagonalB
            // 
            this.nupDiagonalB.Location = new System.Drawing.Point(120, 528);
            this.nupDiagonalB.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupDiagonalB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDiagonalB.Name = "nupDiagonalB";
            this.nupDiagonalB.Size = new System.Drawing.Size(219, 20);
            this.nupDiagonalB.TabIndex = 35;
            this.nupDiagonalB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupDiagonalB.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbDireccio
            // 
            this.lbDireccio.AutoSize = true;
            this.lbDireccio.BackColor = System.Drawing.Color.DarkOrange;
            this.lbDireccio.ForeColor = System.Drawing.Color.White;
            this.lbDireccio.Location = new System.Drawing.Point(14, 474);
            this.lbDireccio.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbDireccio.Name = "lbDireccio";
            this.lbDireccio.Padding = new System.Windows.Forms.Padding(3);
            this.lbDireccio.Size = new System.Drawing.Size(100, 19);
            this.lbDireccio.TabIndex = 38;
            this.lbDireccio.Text = "Direccio";
            // 
            // nupDireccio
            // 
            this.nupDireccio.Location = new System.Drawing.Point(120, 474);
            this.nupDireccio.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nupDireccio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupDireccio.Name = "nupDireccio";
            this.nupDireccio.Size = new System.Drawing.Size(219, 20);
            this.nupDireccio.TabIndex = 37;
            this.nupDireccio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupDireccio.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btNo
            // 
            this.btNo.BackColor = System.Drawing.Color.Red;
            this.btNo.ForeColor = System.Drawing.Color.White;
            this.btNo.Location = new System.Drawing.Point(185, 637);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(114, 42);
            this.btNo.TabIndex = 40;
            this.btNo.Text = "&Cancel·lar";
            this.btNo.UseVisualStyleBackColor = false;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.Green;
            this.btOK.ForeColor = System.Drawing.Color.White;
            this.btOK.Location = new System.Drawing.Point(49, 637);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(114, 42);
            this.btOK.TabIndex = 39;
            this.btOK.Text = "&Acceptar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // chkInterior
            // 
            this.chkInterior.BackColor = System.Drawing.Color.DarkOrange;
            this.chkInterior.Checked = true;
            this.chkInterior.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInterior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkInterior.Location = new System.Drawing.Point(119, 581);
            this.chkInterior.Name = "chkInterior";
            this.chkInterior.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.chkInterior.Size = new System.Drawing.Size(219, 36);
            this.chkInterior.TabIndex = 42;
            this.chkInterior.Text = "Interior";
            this.chkInterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkInterior.UseVisualStyleBackColor = false;
            // 
            // pnlColorInterior
            // 
            this.pnlColorInterior.BackColor = System.Drawing.Color.Orange;
            this.pnlColorInterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorInterior.Location = new System.Drawing.Point(15, 581);
            this.pnlColorInterior.Name = "pnlColorInterior";
            this.pnlColorInterior.Size = new System.Drawing.Size(96, 36);
            this.pnlColorInterior.TabIndex = 41;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.DarkOrange;
            this.lbColor.ForeColor = System.Drawing.Color.White;
            this.lbColor.Location = new System.Drawing.Point(13, 556);
            this.lbColor.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Padding = new System.Windows.Forms.Padding(3);
            this.lbColor.Size = new System.Drawing.Size(100, 19);
            this.lbColor.TabIndex = 44;
            this.lbColor.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Orange",
            "Purple",
            "Pink",
            "Brown",
            "Black",
            "White",
            "Gray",
            "Cyan",
            "Magenta",
            "Lime",
            "Teal",
            "Navy",
            "Olive",
            "Maroon",
            "Beige",
            "Silver",
            "Gold",
            "Ivory",
            "Violet",
            "Indigo",
            "Crimson",
            "Turquoise",
            "Salmon",
            "Orchid  ",
            "Chocolate  ",
            "Lavender  ",
            "Periwinkle  ",
            "Peach  ",
            "Mint  ",
            "Amber",
            "Mustard",
            "LightPink",
            "LightBlue",
            "LightGreen",
            "LightYellow",
            "LightCoral",
            "LightCyan",
            "LightGray",
            "DarkRed",
            "DarkBlue",
            "DarkGreen",
            "DarkCyan",
            "DarkGray",
            "DarkMagenta",
            "DarkOrange",
            "DarkViolet"});
            this.cbColor.Location = new System.Drawing.Point(120, 554);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(219, 21);
            this.cbColor.TabIndex = 43;
            // 
            // FrmControlPoligon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 689);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.chkInterior);
            this.Controls.Add(this.pnlColorInterior);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbDireccio);
            this.Controls.Add(this.nupDireccio);
            this.Controls.Add(this.lbDiagonalB);
            this.Controls.Add(this.nupDiagonalB);
            this.Controls.Add(this.lbDiagonalA);
            this.Controls.Add(this.nupDiagonalA);
            this.Controls.Add(this.lbAlçada);
            this.Controls.Add(this.nupAlçada);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.lbMida);
            this.Controls.Add(this.nupMida);
            this.Controls.Add(this.lbCostat);
            this.Controls.Add(this.nupCostat);
            this.Controls.Add(this.lbRadiB);
            this.Controls.Add(this.nupRadiB);
            this.Controls.Add(this.lbRadiA);
            this.Controls.Add(this.nupRadiA);
            this.Controls.Add(this.lbRadi);
            this.Controls.Add(this.nupRadi);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.gbGrup);
            this.Name = "FrmControlPoligon";
            this.Text = "FrmControlPoligon";
            this.Load += new System.EventHandler(this.FrmControlPoligon_Load);
            this.gbGrup.ResumeLayout(false);
            this.gbGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRadi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRadiA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRadiB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCostat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAlçada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiagonalA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDiagonalB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDireccio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGrup;
        private System.Windows.Forms.RadioButton rdOctogons;
        private System.Windows.Forms.RadioButton rdHexagons;
        private System.Windows.Forms.RadioButton rdPentagons;
        private System.Windows.Forms.RadioButton rdRombes;
        private System.Windows.Forms.RadioButton rdNanTrianglesIsosceles;
        private System.Windows.Forms.RadioButton rdTrianglesRectangles;
        private System.Windows.Forms.RadioButton rdElipses;
        private System.Windows.Forms.RadioButton rdCercles;
        private System.Windows.Forms.RadioButton rdRectangles;
        private System.Windows.Forms.RadioButton rdQuadrats;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.NumericUpDown nupRadi;
        private System.Windows.Forms.Label lbRadi;
        private System.Windows.Forms.Label lbRadiA;
        private System.Windows.Forms.NumericUpDown nupRadiA;
        private System.Windows.Forms.Label lbRadiB;
        private System.Windows.Forms.NumericUpDown nupRadiB;
        private System.Windows.Forms.Label lbCostat;
        private System.Windows.Forms.NumericUpDown nupCostat;
        private System.Windows.Forms.Label lbMida;
        private System.Windows.Forms.NumericUpDown nupMida;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.NumericUpDown nupBase;
        private System.Windows.Forms.Label lbAlçada;
        private System.Windows.Forms.NumericUpDown nupAlçada;
        private System.Windows.Forms.Label lbDiagonalA;
        private System.Windows.Forms.NumericUpDown nupDiagonalA;
        private System.Windows.Forms.Label lbDiagonalB;
        private System.Windows.Forms.NumericUpDown nupDiagonalB;
        private System.Windows.Forms.Label lbDireccio;
        private System.Windows.Forms.NumericUpDown nupDireccio;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.CheckBox chkInterior;
        private System.Windows.Forms.Panel pnlColorInterior;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cbColor;
    }
}