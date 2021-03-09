
namespace SistemScolarDeInregistrare_Proof_Elev_
{
    partial class StudentsReports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SchoolSystemDataSet1 = new SistemScolarDeInregistrare_Proof_Elev_.SchoolSystemDataSet1();
            this.StudentsReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentsReportsTableAdapter = new SistemScolarDeInregistrare_Proof_Elev_.SchoolSystemDataSet1TableAdapters.StudentsReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StudentsReportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemScolarDeInregistrare_Proof_Elev_.StudentsReports.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1497, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SchoolSystemDataSet1
            // 
            this.SchoolSystemDataSet1.DataSetName = "SchoolSystemDataSet1";
            this.SchoolSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StudentsReportsBindingSource
            // 
            this.StudentsReportsBindingSource.DataMember = "StudentsReports";
            this.StudentsReportsBindingSource.DataSource = this.SchoolSystemDataSet1;
            // 
            // StudentsReportsTableAdapter
            // 
            this.StudentsReportsTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StudentsReports";
            this.Text = "StudentsReports";
            this.Load += new System.EventHandler(this.StudentsReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentsReportsBindingSource;
        private SchoolSystemDataSet1 SchoolSystemDataSet1;
        private SchoolSystemDataSet1TableAdapters.StudentsReportsTableAdapter StudentsReportsTableAdapter;
    }
}