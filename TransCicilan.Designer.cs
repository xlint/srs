﻿namespace SRS.DeskApp
{
    partial class TransCicilan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransCicilan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbBerat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnFindPenerima = new MetroFramework.Controls.MetroButton();
            this.GridList = new MetroFramework.Controls.MetroGrid();
            this.tbKeterangan = new MetroFramework.Controls.MetroTextBox();
            this.tbJumlah = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbTglDisetujui = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.tbKodePetani = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btSimpan = new MetroFramework.Controls.MetroButton();
            this.errInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBerat
            // 
            this.tbBerat.Lines = new string[0];
            this.tbBerat.Location = new System.Drawing.Point(145, 110);
            this.tbBerat.MaxLength = 32767;
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.PasswordChar = '\0';
            this.tbBerat.ReadOnly = true;
            this.tbBerat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbBerat.SelectedText = "";
            this.tbBerat.Size = new System.Drawing.Size(116, 23);
            this.tbBerat.TabIndex = 203;
            this.tbBerat.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 110);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 202;
            this.metroLabel1.Text = "Berat Bersih";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 204);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 186;
            this.metroLabel2.Text = "Keterangan";
            // 
            // BtnFindPenerima
            // 
            this.BtnFindPenerima.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFindPenerima.BackgroundImage")));
            this.BtnFindPenerima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFindPenerima.Location = new System.Drawing.Point(351, 74);
            this.BtnFindPenerima.Name = "BtnFindPenerima";
            this.BtnFindPenerima.Size = new System.Drawing.Size(45, 42);
            this.BtnFindPenerima.TabIndex = 184;
            this.BtnFindPenerima.UseSelectable = true;
            // 
            // GridList
            // 
            this.GridList.AllowUserToAddRows = false;
            this.GridList.AllowUserToDeleteRows = false;
            this.GridList.AllowUserToResizeRows = false;
            this.GridList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridList.ColumnHeadersHeight = 20;
            this.GridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridList.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridList.EnableHeadersVisualStyles = false;
            this.GridList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridList.Location = new System.Drawing.Point(145, 103);
            this.GridList.Name = "GridList";
            this.GridList.ReadOnly = true;
            this.GridList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridList.RowHeadersWidth = 4;
            this.GridList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GridList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridList.RowTemplate.DividerHeight = 1;
            this.GridList.RowTemplate.Height = 20;
            this.GridList.RowTemplate.ReadOnly = true;
            this.GridList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GridList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridList.Size = new System.Drawing.Size(291, 120);
            this.GridList.Style = MetroFramework.MetroColorStyle.Teal;
            this.GridList.TabIndex = 188;
            this.GridList.UseCustomBackColor = true;
            this.GridList.UseCustomForeColor = true;
            this.GridList.UseStyleColors = true;
            this.GridList.Visible = false;
            this.GridList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridList_CellDoubleClick);
            this.GridList.Leave += new System.EventHandler(this.GridList_Leave);
            // 
            // tbKeterangan
            // 
            this.tbKeterangan.Lines = new string[0];
            this.tbKeterangan.Location = new System.Drawing.Point(145, 204);
            this.tbKeterangan.MaxLength = 32767;
            this.tbKeterangan.Multiline = true;
            this.tbKeterangan.Name = "tbKeterangan";
            this.tbKeterangan.PasswordChar = '\0';
            this.tbKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKeterangan.SelectedText = "";
            this.tbKeterangan.Size = new System.Drawing.Size(291, 101);
            this.tbKeterangan.TabIndex = 187;
            this.tbKeterangan.UseSelectable = true;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Lines = new string[0];
            this.tbJumlah.Location = new System.Drawing.Point(145, 175);
            this.tbJumlah.MaxLength = 32767;
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.PasswordChar = '\0';
            this.tbJumlah.ReadOnly = true;
            this.tbJumlah.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbJumlah.SelectedText = "";
            this.tbJumlah.Size = new System.Drawing.Size(200, 23);
            this.tbJumlah.TabIndex = 183;
            this.tbJumlah.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(35, 175);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(45, 19);
            this.metroLabel9.TabIndex = 182;
            this.metroLabel9.Text = "Harga";
            // 
            // tbTglDisetujui
            // 
            this.tbTglDisetujui.Location = new System.Drawing.Point(145, 140);
            this.tbTglDisetujui.MinimumSize = new System.Drawing.Size(4, 29);
            this.tbTglDisetujui.Name = "tbTglDisetujui";
            this.tbTglDisetujui.Size = new System.Drawing.Size(200, 29);
            this.tbTglDisetujui.TabIndex = 181;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(34, 140);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(79, 19);
            this.metroLabel21.TabIndex = 180;
            this.metroLabel21.Text = "Tgl Disetujui";
            // 
            // tbKodePetani
            // 
            this.tbKodePetani.Lines = new string[0];
            this.tbKodePetani.Location = new System.Drawing.Point(145, 80);
            this.tbKodePetani.MaxLength = 32767;
            this.tbKodePetani.Name = "tbKodePetani";
            this.tbKodePetani.PasswordChar = '\0';
            this.tbKodePetani.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbKodePetani.SelectedText = "";
            this.tbKodePetani.Size = new System.Drawing.Size(200, 23);
            this.tbKodePetani.TabIndex = 179;
            this.tbKodePetani.UseSelectable = true;
            this.tbKodePetani.TextChanged += new System.EventHandler(this.tbKodePetani_TextChanged);
            this.tbKodePetani.Enter += new System.EventHandler(this.tbKodePetani_Enter);
            this.tbKodePetani.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKodePetani_KeyDown);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(35, 80);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(79, 19);
            this.metroLabel12.TabIndex = 178;
            this.metroLabel12.Text = "Kode Petani";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(145, 319);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(191, 36);
            this.btSimpan.TabIndex = 177;
            this.btSimpan.Text = "Submit";
            this.btSimpan.UseSelectable = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // errInput
            // 
            this.errInput.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider3
            // 
            this.errorProvider3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // TransCicilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 390);
            this.Controls.Add(this.GridList);
            this.Controls.Add(this.tbBerat);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.BtnFindPenerima);
            this.Controls.Add(this.tbKeterangan);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tbTglDisetujui);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.tbKodePetani);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.btSimpan);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TransCicilan";
            this.Text = "Penjualan Tebu Petani Non KKPE";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.TransCicilan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnFindPenerima;
        private System.Windows.Forms.ErrorProvider errInput;
        private MetroFramework.Controls.MetroGrid GridList;
        private MetroFramework.Controls.MetroTextBox tbKeterangan;
        private MetroFramework.Controls.MetroTextBox tbJumlah;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroDateTime tbTglDisetujui;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroTextBox tbKodePetani;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton btSimpan;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private MetroFramework.Controls.MetroTextBox tbBerat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}