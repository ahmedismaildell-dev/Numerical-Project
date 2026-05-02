namespace Logic_project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSolve = new Guna.UI2.WinForms.Guna2Button();
            this.cbMethodType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFunction = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblXl = new System.Windows.Forms.Label();
            this.lblXu = new System.Windows.Forms.Label();
            this.lblX0 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXl = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtXu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtX0 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtError = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRoot = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvIterationDetials = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIterationDetials)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.txtError);
            this.groupBox3.Controls.Add(this.txtX0);
            this.groupBox3.Controls.Add(this.txtXu);
            this.groupBox3.Controls.Add(this.txtXl);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblX0);
            this.groupBox3.Controls.Add(this.lblXu);
            this.groupBox3.Controls.Add(this.lblXl);
            this.groupBox3.Controls.Add(this.txtFunction);
            this.groupBox3.Controls.Add(this.cbMethodType);
            this.groupBox3.Controls.Add(this.btnSolve);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox3.Location = new System.Drawing.Point(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1182, 441);
            this.groupBox3.TabIndex = 174;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.Transparent;
            this.btnSolve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSolve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSolve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSolve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSolve.FillColor = System.Drawing.Color.Transparent;
            this.btnSolve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSolve.ForeColor = System.Drawing.Color.Yellow;
            this.btnSolve.Location = new System.Drawing.Point(505, 379);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(204, 37);
            this.btnSolve.TabIndex = 22;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // cbMethodType
            // 
            this.cbMethodType.BackColor = System.Drawing.Color.Transparent;
            this.cbMethodType.BorderRadius = 4;
            this.cbMethodType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMethodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethodType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMethodType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMethodType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMethodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMethodType.ItemHeight = 30;
            this.cbMethodType.Items.AddRange(new object[] {
            "___ Select Unit___ ",
            "Bisection",
            " False",
            " Position",
            " Simple",
            " fixed-point",
            " Newton",
            " Secant"});
            this.cbMethodType.Location = new System.Drawing.Point(24, 80);
            this.cbMethodType.Name = "cbMethodType";
            this.cbMethodType.Size = new System.Drawing.Size(280, 36);
            this.cbMethodType.TabIndex = 24;
            this.cbMethodType.SelectedIndexChanged += new System.EventHandler(this.cbMethodType_SelectedIndexChanged);
            // 
            // txtFunction
            // 
            this.txtFunction.Animated = true;
            this.txtFunction.BorderRadius = 4;
            this.txtFunction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFunction.DefaultText = "";
            this.txtFunction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFunction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFunction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFunction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFunction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFunction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFunction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFunction.Location = new System.Drawing.Point(24, 185);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFunction.PlaceholderText = "";
            this.txtFunction.SelectedText = "";
            this.txtFunction.Size = new System.Drawing.Size(367, 36);
            this.txtFunction.TabIndex = 193;
            this.txtFunction.TextChanged += new System.EventHandler(this.txtAreaName_TextChanged);
            // 
            // lblXl
            // 
            this.lblXl.AutoSize = true;
            this.lblXl.BackColor = System.Drawing.Color.Transparent;
            this.lblXl.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXl.Location = new System.Drawing.Point(30, 277);
            this.lblXl.Name = "lblXl";
            this.lblXl.Size = new System.Drawing.Size(149, 32);
            this.lblXl.TabIndex = 196;
            this.lblXl.Text = "Lower bound (xl)";
            // 
            // lblXu
            // 
            this.lblXu.AutoSize = true;
            this.lblXu.BackColor = System.Drawing.Color.Transparent;
            this.lblXu.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXu.Location = new System.Drawing.Point(310, 277);
            this.lblXu.Name = "lblXu";
            this.lblXu.Size = new System.Drawing.Size(155, 32);
            this.lblXu.TabIndex = 197;
            this.lblXu.Text = "Upper bound (xu)";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.BackColor = System.Drawing.Color.Transparent;
            this.lblX0.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX0.Location = new System.Drawing.Point(587, 277);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(145, 32);
            this.lblX0.TabIndex = 198;
            this.lblX0.Text = "initial Guess (x0)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(919, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 199;
            this.label5.Text = "Error(ε)";
            // 
            // txtXl
            // 
            this.txtXl.Animated = true;
            this.txtXl.BorderRadius = 4;
            this.txtXl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXl.DefaultText = "";
            this.txtXl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtXl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXl.Location = new System.Drawing.Point(24, 312);
            this.txtXl.Name = "txtXl";
            this.txtXl.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtXl.PlaceholderText = "";
            this.txtXl.SelectedText = "";
            this.txtXl.Size = new System.Drawing.Size(207, 36);
            this.txtXl.TabIndex = 200;
            // 
            // txtXu
            // 
            this.txtXu.Animated = true;
            this.txtXu.BorderRadius = 4;
            this.txtXu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXu.DefaultText = "";
            this.txtXu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtXu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXu.Location = new System.Drawing.Point(291, 312);
            this.txtXu.Name = "txtXu";
            this.txtXu.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtXu.PlaceholderText = "";
            this.txtXu.SelectedText = "";
            this.txtXu.Size = new System.Drawing.Size(207, 36);
            this.txtXu.TabIndex = 201;
            // 
            // txtX0
            // 
            this.txtX0.Animated = true;
            this.txtX0.BorderRadius = 4;
            this.txtX0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtX0.DefaultText = "";
            this.txtX0.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtX0.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtX0.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtX0.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtX0.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtX0.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtX0.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtX0.Location = new System.Drawing.Point(571, 312);
            this.txtX0.Name = "txtX0";
            this.txtX0.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtX0.PlaceholderText = "";
            this.txtX0.SelectedText = "";
            this.txtX0.Size = new System.Drawing.Size(207, 36);
            this.txtX0.TabIndex = 202;
            // 
            // txtError
            // 
            this.txtError.Animated = true;
            this.txtError.BorderRadius = 4;
            this.txtError.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtError.DefaultText = "";
            this.txtError.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtError.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtError.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtError.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtError.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtError.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtError.Location = new System.Drawing.Point(894, 312);
            this.txtError.Name = "txtError";
            this.txtError.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtError.PlaceholderText = "";
            this.txtError.SelectedText = "";
            this.txtError.Size = new System.Drawing.Size(207, 36);
            this.txtError.TabIndex = 203;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.lblRoot);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(1, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 154);
            this.groupBox1.TabIndex = 204;
            this.groupBox1.TabStop = false;
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.BackColor = System.Drawing.Color.Transparent;
            this.lblRoot.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoot.Location = new System.Drawing.Point(166, 93);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(41, 32);
            this.lblRoot.TabIndex = 204;
            this.lblRoot.Text = "???";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.dgvIterationDetials);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 600);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(949, 189);
            this.groupBox2.TabIndex = 205;
            this.groupBox2.TabStop = false;
            // 
            // dgvIterationDetials
            // 
            this.dgvIterationDetials.AllowUserToAddRows = false;
            this.dgvIterationDetials.AllowUserToDeleteRows = false;
            this.dgvIterationDetials.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvIterationDetials.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIterationDetials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIterationDetials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIterationDetials.ColumnHeadersHeight = 4;
            this.dgvIterationDetials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIterationDetials.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIterationDetials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIterationDetials.Location = new System.Drawing.Point(14, 38);
            this.dgvIterationDetials.Name = "dgvIterationDetials";
            this.dgvIterationDetials.ReadOnly = true;
            this.dgvIterationDetials.RowHeadersVisible = false;
            this.dgvIterationDetials.Size = new System.Drawing.Size(912, 141);
            this.dgvIterationDetials.TabIndex = 206;
            this.dgvIterationDetials.TabStop = false;
            this.dgvIterationDetials.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIterationDetials.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvIterationDetials.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvIterationDetials.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvIterationDetials.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvIterationDetials.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvIterationDetials.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIterationDetials.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvIterationDetials.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIterationDetials.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvIterationDetials.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvIterationDetials.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvIterationDetials.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvIterationDetials.ThemeStyle.ReadOnly = true;
            this.dgvIterationDetials.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvIterationDetials.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvIterationDetials.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvIterationDetials.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvIterationDetials.ThemeStyle.RowsStyle.Height = 22;
            this.dgvIterationDetials.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvIterationDetials.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1186, 791);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIterationDetials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cbMethodType;
        private Guna.UI2.WinForms.Guna2Button btnSolve;
        private Guna.UI2.WinForms.Guna2TextBox txtFunction;
        private System.Windows.Forms.Label lblXu;
        private System.Windows.Forms.Label lblXl;
        private Guna.UI2.WinForms.Guna2TextBox txtError;
        private Guna.UI2.WinForms.Guna2TextBox txtX0;
        private Guna.UI2.WinForms.Guna2TextBox txtXu;
        private Guna.UI2.WinForms.Guna2TextBox txtXl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvIterationDetials;
    }
}

