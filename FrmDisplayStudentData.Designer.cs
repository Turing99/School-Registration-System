namespace SchoolRegistrationSystem
{
    partial class FrmDisplayStudentData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisplayStudentData));
            this.DGridView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btn_Excel_Students = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView
            // 
            this.DGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView.Location = new System.Drawing.Point(12, 155);
            this.DGridView.Name = "DGridView";
            this.DGridView.RowHeadersWidth = 51;
            this.DGridView.Size = new System.Drawing.Size(1078, 362);
            this.DGridView.TabIndex = 0;
            this.DGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridView_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 109);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(385, 31);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 79);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(129, 18);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search by name";
            // 
            // btn_Excel_Students
            // 
            this.btn_Excel_Students.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Excel_Students.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Excel_Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel_Students.ForeColor = System.Drawing.Color.White;
            this.btn_Excel_Students.Image = ((System.Drawing.Image)(resources.GetObject("btn_Excel_Students.Image")));
            this.btn_Excel_Students.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel_Students.Location = new System.Drawing.Point(725, 92);
            this.btn_Excel_Students.Name = "btn_Excel_Students";
            this.btn_Excel_Students.Size = new System.Drawing.Size(209, 48);
            this.btn_Excel_Students.TabIndex = 3;
            this.btn_Excel_Students.Text = "Export to Excel";
            this.btn_Excel_Students.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel_Students.UseVisualStyleBackColor = false;
            this.btn_Excel_Students.Click += new System.EventHandler(this.btn_Excel_Students_Click);
            // 
            // FrmDisplayStudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 540);
            this.Controls.Add(this.btn_Excel_Students);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.DGridView);
            this.Name = "FrmDisplayStudentData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Student Data";
            this.Load += new System.EventHandler(this.FrmDisplayStudentData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btn_Excel_Students;
    }
}