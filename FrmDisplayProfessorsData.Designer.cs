
namespace SistemScolarDeInregistrare_Proof_Elev_
{
    partial class FrmDisplayProfessorsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayProfessorsData));
            this.lblSearch_Pf = new System.Windows.Forms.Label();
            this.txtSearch_Pf = new System.Windows.Forms.TextBox();
            this.DGridView_Pf = new System.Windows.Forms.DataGridView();
            this.btn_Excel_Professors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_Pf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch_Pf
            // 
            this.lblSearch_Pf.AutoSize = true;
            this.lblSearch_Pf.BackColor = System.Drawing.Color.White;
            this.lblSearch_Pf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch_Pf.Location = new System.Drawing.Point(16, 97);
            this.lblSearch_Pf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch_Pf.Name = "lblSearch_Pf";
            this.lblSearch_Pf.Size = new System.Drawing.Size(162, 24);
            this.lblSearch_Pf.TabIndex = 3;
            this.lblSearch_Pf.Text = "Search by name";
            // 
            // txtSearch_Pf
            // 
            this.txtSearch_Pf.Location = new System.Drawing.Point(16, 134);
            this.txtSearch_Pf.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch_Pf.Multiline = true;
            this.txtSearch_Pf.Name = "txtSearch_Pf";
            this.txtSearch_Pf.Size = new System.Drawing.Size(512, 37);
            this.txtSearch_Pf.TabIndex = 4;
            this.txtSearch_Pf.TextChanged += new System.EventHandler(this.txtSearch_Pf_TextChanged);
            // 
            // DGridView_Pf
            // 
            this.DGridView_Pf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_Pf.Location = new System.Drawing.Point(16, 191);
            this.DGridView_Pf.Margin = new System.Windows.Forms.Padding(4);
            this.DGridView_Pf.Name = "DGridView_Pf";
            this.DGridView_Pf.RowHeadersWidth = 51;
            this.DGridView_Pf.Size = new System.Drawing.Size(1437, 446);
            this.DGridView_Pf.TabIndex = 5;
            this.DGridView_Pf.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_Pf_CellDoubleClick);
            // 
            // btn_Excel_Professors
            // 
            this.btn_Excel_Professors.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Excel_Professors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Excel_Professors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel_Professors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel_Professors.ForeColor = System.Drawing.Color.White;
            this.btn_Excel_Professors.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel_Professors.Image")));
            this.btn_Excel_Professors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel_Professors.Location = new System.Drawing.Point(974, 112);
            this.btn_Excel_Professors.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Excel_Professors.Name = "btn_Excel_Professors";
            this.btn_Excel_Professors.Size = new System.Drawing.Size(279, 59);
            this.btn_Excel_Professors.TabIndex = 6;
            this.btn_Excel_Professors.Text = "Export to Excel";
            this.btn_Excel_Professors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel_Professors.UseVisualStyleBackColor = false;
            this.btn_Excel_Professors.Click += new System.EventHandler(this.btn_Excel_Professors_Click);
            // 
            // FrmDisplayProfessorsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1469, 665);
            this.Controls.Add(this.btn_Excel_Professors);
            this.Controls.Add(this.DGridView_Pf);
            this.Controls.Add(this.txtSearch_Pf);
            this.Controls.Add(this.lblSearch_Pf);
            this.MaximizeBox = false;
            this.Name = "FrmDisplayProfessorsData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisplayProfessorstData";
            this.Load += new System.EventHandler(this.FrmDisplayProfessorsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_Pf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch_Pf;
        private System.Windows.Forms.TextBox txtSearch_Pf;
        private System.Windows.Forms.DataGridView DGridView_Pf;
        private System.Windows.Forms.Button btn_Excel_Professors;
    }
}