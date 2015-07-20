namespace OboronEnergoProject
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
         this.components = new System.ComponentModel.Container();
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
         this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.DataSet1 = new OboronEnergoProject.DataSet1();
         this.lblHost = new System.Windows.Forms.Label();
         this.txtHost = new System.Windows.Forms.TextBox();
         this.lblUsername = new System.Windows.Forms.Label();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.btnSignIn = new System.Windows.Forms.Button();
         this.lblSurname = new System.Windows.Forms.Label();
         this.txtSurname = new System.Windows.Forms.TextBox();
         this.lblName = new System.Windows.Forms.Label();
         this.txtName = new System.Windows.Forms.TextBox();
         this.lblMiddleName = new System.Windows.Forms.Label();
         this.txtMiddleName = new System.Windows.Forms.TextBox();
         this.lblIDNP = new System.Windows.Forms.Label();
         this.txtNPID = new System.Windows.Forms.TextBox();
         this.gbNP = new System.Windows.Forms.GroupBox();
         this.dtPickerNPTo = new System.Windows.Forms.DateTimePicker();
         this.dtPickerNPFrom = new System.Windows.Forms.DateTimePicker();
         this.lblToNP = new System.Windows.Forms.Label();
         this.lblFromNP = new System.Windows.Forms.Label();
         this.rbNP = new System.Windows.Forms.RadioButton();
         this.lblCompanyName = new System.Windows.Forms.Label();
         this.txtCompanyName = new System.Windows.Forms.TextBox();
         this.lblIDLP = new System.Windows.Forms.Label();
         this.txtLPID = new System.Windows.Forms.TextBox();
         this.rbLP = new System.Windows.Forms.RadioButton();
         this.gbLP = new System.Windows.Forms.GroupBox();
         this.dtPickerLPTo = new System.Windows.Forms.DateTimePicker();
         this.lblToLP = new System.Windows.Forms.Label();
         this.lblFromLP = new System.Windows.Forms.Label();
         this.dtPickerLPFrom = new System.Windows.Forms.DateTimePicker();
         this.lblPassword = new System.Windows.Forms.Label();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.btnCreateReport = new System.Windows.Forms.Button();
         this.btnShowAllRP = new System.Windows.Forms.Button();
         this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
         this.DataTable1TableAdapter = new OboronEnergoProject.DataSet1TableAdapters.DataTable1TableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
         this.gbNP.SuspendLayout();
         this.gbLP.SuspendLayout();
         this.SuspendLayout();
         // 
         // DataTable1BindingSource
         // 
         this.DataTable1BindingSource.DataMember = "DataTable1";
         this.DataTable1BindingSource.DataSource = this.DataSet1;
         // 
         // DataSet1
         // 
         this.DataSet1.DataSetName = "DataSet1";
         this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // lblHost
         // 
         this.lblHost.AutoSize = true;
         this.lblHost.Location = new System.Drawing.Point(191, 15);
         this.lblHost.Name = "lblHost";
         this.lblHost.Size = new System.Drawing.Size(32, 13);
         this.lblHost.TabIndex = 0;
         this.lblHost.Text = "Host:";
         // 
         // txtHost
         // 
         this.txtHost.Location = new System.Drawing.Point(229, 12);
         this.txtHost.Name = "txtHost";
         this.txtHost.Size = new System.Drawing.Size(100, 20);
         this.txtHost.TabIndex = 1;
         this.txtHost.Text = "localhost";
         // 
         // lblUsername
         // 
         this.lblUsername.AutoSize = true;
         this.lblUsername.Location = new System.Drawing.Point(15, 11);
         this.lblUsername.Name = "lblUsername";
         this.lblUsername.Size = new System.Drawing.Size(58, 13);
         this.lblUsername.TabIndex = 2;
         this.lblUsername.Text = "Username:";
         // 
         // txtUsername
         // 
         this.txtUsername.Location = new System.Drawing.Point(79, 8);
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(100, 20);
         this.txtUsername.TabIndex = 3;
         this.txtUsername.Text = "maxim";
         // 
         // btnSignIn
         // 
         this.btnSignIn.Location = new System.Drawing.Point(229, 38);
         this.btnSignIn.Name = "btnSignIn";
         this.btnSignIn.Size = new System.Drawing.Size(100, 21);
         this.btnSignIn.TabIndex = 4;
         this.btnSignIn.Text = "Sign In";
         this.btnSignIn.UseVisualStyleBackColor = true;
         this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
         // 
         // lblSurname
         // 
         this.lblSurname.AutoSize = true;
         this.lblSurname.Location = new System.Drawing.Point(6, 16);
         this.lblSurname.Name = "lblSurname";
         this.lblSurname.Size = new System.Drawing.Size(52, 13);
         this.lblSurname.TabIndex = 5;
         this.lblSurname.Text = "Surname:";
         // 
         // txtSurname
         // 
         this.txtSurname.Location = new System.Drawing.Point(67, 13);
         this.txtSurname.Name = "txtSurname";
         this.txtSurname.Size = new System.Drawing.Size(100, 20);
         this.txtSurname.TabIndex = 6;
         this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
         // 
         // lblName
         // 
         this.lblName.AutoSize = true;
         this.lblName.Location = new System.Drawing.Point(173, 16);
         this.lblName.Name = "lblName";
         this.lblName.Size = new System.Drawing.Size(38, 13);
         this.lblName.TabIndex = 7;
         this.lblName.Text = "Name:";
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(217, 13);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(100, 20);
         this.txtName.TabIndex = 8;
         this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
         // 
         // lblMiddleName
         // 
         this.lblMiddleName.AutoSize = true;
         this.lblMiddleName.Location = new System.Drawing.Point(323, 16);
         this.lblMiddleName.Name = "lblMiddleName";
         this.lblMiddleName.Size = new System.Drawing.Size(67, 13);
         this.lblMiddleName.TabIndex = 9;
         this.lblMiddleName.Text = "Middlename:";
         // 
         // txtMiddleName
         // 
         this.txtMiddleName.Location = new System.Drawing.Point(396, 13);
         this.txtMiddleName.Name = "txtMiddleName";
         this.txtMiddleName.Size = new System.Drawing.Size(100, 20);
         this.txtMiddleName.TabIndex = 10;
         this.txtMiddleName.TextChanged += new System.EventHandler(this.txtMiddleName_TextChanged);
         // 
         // lblIDNP
         // 
         this.lblIDNP.AutoSize = true;
         this.lblIDNP.Location = new System.Drawing.Point(6, 42);
         this.lblIDNP.Name = "lblIDNP";
         this.lblIDNP.Size = new System.Drawing.Size(21, 13);
         this.lblIDNP.TabIndex = 11;
         this.lblIDNP.Text = "ID:";
         // 
         // txtNPID
         // 
         this.txtNPID.Location = new System.Drawing.Point(67, 39);
         this.txtNPID.Name = "txtNPID";
         this.txtNPID.Size = new System.Drawing.Size(100, 20);
         this.txtNPID.TabIndex = 12;
         this.txtNPID.TextChanged += new System.EventHandler(this.txtNPID_TextChanged);
         // 
         // gbNP
         // 
         this.gbNP.Controls.Add(this.dtPickerNPTo);
         this.gbNP.Controls.Add(this.dtPickerNPFrom);
         this.gbNP.Controls.Add(this.lblToNP);
         this.gbNP.Controls.Add(this.lblSurname);
         this.gbNP.Controls.Add(this.lblFromNP);
         this.gbNP.Controls.Add(this.txtSurname);
         this.gbNP.Controls.Add(this.lblName);
         this.gbNP.Controls.Add(this.txtName);
         this.gbNP.Controls.Add(this.txtNPID);
         this.gbNP.Controls.Add(this.lblMiddleName);
         this.gbNP.Controls.Add(this.lblIDNP);
         this.gbNP.Controls.Add(this.txtMiddleName);
         this.gbNP.Enabled = false;
         this.gbNP.Location = new System.Drawing.Point(12, 65);
         this.gbNP.Name = "gbNP";
         this.gbNP.Size = new System.Drawing.Size(550, 72);
         this.gbNP.TabIndex = 16;
         this.gbNP.TabStop = false;
         // 
         // dtPickerNPTo
         // 
         this.dtPickerNPTo.CustomFormat = "yyyy-MM-dd";
         this.dtPickerNPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtPickerNPTo.Location = new System.Drawing.Point(462, 39);
         this.dtPickerNPTo.MaxDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
         this.dtPickerNPTo.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
         this.dtPickerNPTo.Name = "dtPickerNPTo";
         this.dtPickerNPTo.Size = new System.Drawing.Size(65, 20);
         this.dtPickerNPTo.TabIndex = 26;
         this.dtPickerNPTo.Value = new System.DateTime(2013, 1, 31, 0, 0, 0, 0);
         // 
         // dtPickerNPFrom
         // 
         this.dtPickerNPFrom.CustomFormat = "yyyy-MM-dd";
         this.dtPickerNPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtPickerNPFrom.Location = new System.Drawing.Point(362, 39);
         this.dtPickerNPFrom.MaxDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
         this.dtPickerNPFrom.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
         this.dtPickerNPFrom.Name = "dtPickerNPFrom";
         this.dtPickerNPFrom.Size = new System.Drawing.Size(65, 20);
         this.dtPickerNPFrom.TabIndex = 23;
         this.dtPickerNPFrom.Value = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
         // 
         // lblToNP
         // 
         this.lblToNP.AutoSize = true;
         this.lblToNP.Location = new System.Drawing.Point(433, 42);
         this.lblToNP.Name = "lblToNP";
         this.lblToNP.Size = new System.Drawing.Size(23, 13);
         this.lblToNP.TabIndex = 25;
         this.lblToNP.Text = "To:";
         // 
         // lblFromNP
         // 
         this.lblFromNP.AutoSize = true;
         this.lblFromNP.Location = new System.Drawing.Point(323, 42);
         this.lblFromNP.Name = "lblFromNP";
         this.lblFromNP.Size = new System.Drawing.Size(33, 13);
         this.lblFromNP.TabIndex = 23;
         this.lblFromNP.Text = "From:";
         // 
         // rbNP
         // 
         this.rbNP.AutoSize = true;
         this.rbNP.Enabled = false;
         this.rbNP.Location = new System.Drawing.Point(344, 13);
         this.rbNP.Name = "rbNP";
         this.rbNP.Size = new System.Drawing.Size(95, 17);
         this.rbNP.TabIndex = 16;
         this.rbNP.TabStop = true;
         this.rbNP.Text = "Natural Person";
         this.rbNP.UseVisualStyleBackColor = true;
         this.rbNP.CheckedChanged += new System.EventHandler(this.rbNP_CheckedChanged_1);
         // 
         // lblCompanyName
         // 
         this.lblCompanyName.AutoSize = true;
         this.lblCompanyName.Location = new System.Drawing.Point(6, 16);
         this.lblCompanyName.Name = "lblCompanyName";
         this.lblCompanyName.Size = new System.Drawing.Size(38, 13);
         this.lblCompanyName.TabIndex = 17;
         this.lblCompanyName.Text = "Name:";
         // 
         // txtCompanyName
         // 
         this.txtCompanyName.Location = new System.Drawing.Point(67, 13);
         this.txtCompanyName.Name = "txtCompanyName";
         this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
         this.txtCompanyName.TabIndex = 18;
         this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
         // 
         // lblIDLP
         // 
         this.lblIDLP.AutoSize = true;
         this.lblIDLP.Location = new System.Drawing.Point(173, 16);
         this.lblIDLP.Name = "lblIDLP";
         this.lblIDLP.Size = new System.Drawing.Size(21, 13);
         this.lblIDLP.TabIndex = 19;
         this.lblIDLP.Text = "ID:";
         // 
         // txtLPID
         // 
         this.txtLPID.Location = new System.Drawing.Point(217, 13);
         this.txtLPID.Name = "txtLPID";
         this.txtLPID.Size = new System.Drawing.Size(100, 20);
         this.txtLPID.TabIndex = 20;
         this.txtLPID.TextChanged += new System.EventHandler(this.txtLPID_TextChanged);
         // 
         // rbLP
         // 
         this.rbLP.AutoSize = true;
         this.rbLP.Enabled = false;
         this.rbLP.Location = new System.Drawing.Point(344, 40);
         this.rbLP.Name = "rbLP";
         this.rbLP.Size = new System.Drawing.Size(87, 17);
         this.rbLP.TabIndex = 21;
         this.rbLP.TabStop = true;
         this.rbLP.Text = "Legal Person";
         this.rbLP.UseVisualStyleBackColor = true;
         this.rbLP.CheckedChanged += new System.EventHandler(this.rbLP_CheckedChanged_1);
         // 
         // gbLP
         // 
         this.gbLP.Controls.Add(this.dtPickerLPTo);
         this.gbLP.Controls.Add(this.lblToLP);
         this.gbLP.Controls.Add(this.lblFromLP);
         this.gbLP.Controls.Add(this.dtPickerLPFrom);
         this.gbLP.Controls.Add(this.lblCompanyName);
         this.gbLP.Controls.Add(this.txtCompanyName);
         this.gbLP.Controls.Add(this.txtLPID);
         this.gbLP.Controls.Add(this.lblIDLP);
         this.gbLP.Enabled = false;
         this.gbLP.Location = new System.Drawing.Point(12, 143);
         this.gbLP.Name = "gbLP";
         this.gbLP.Size = new System.Drawing.Size(550, 42);
         this.gbLP.TabIndex = 22;
         this.gbLP.TabStop = false;
         this.gbLP.Text = "Company";
         // 
         // dtPickerLPTo
         // 
         this.dtPickerLPTo.CustomFormat = "yyyy-MM-dd";
         this.dtPickerLPTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtPickerLPTo.Location = new System.Drawing.Point(462, 13);
         this.dtPickerLPTo.MaxDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
         this.dtPickerLPTo.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
         this.dtPickerLPTo.Name = "dtPickerLPTo";
         this.dtPickerLPTo.Size = new System.Drawing.Size(65, 20);
         this.dtPickerLPTo.TabIndex = 22;
         this.dtPickerLPTo.Value = new System.DateTime(2013, 1, 31, 0, 0, 0, 0);
         // 
         // lblToLP
         // 
         this.lblToLP.AutoSize = true;
         this.lblToLP.Location = new System.Drawing.Point(433, 16);
         this.lblToLP.Name = "lblToLP";
         this.lblToLP.Size = new System.Drawing.Size(23, 13);
         this.lblToLP.TabIndex = 21;
         this.lblToLP.Text = "To:";
         // 
         // lblFromLP
         // 
         this.lblFromLP.AutoSize = true;
         this.lblFromLP.Location = new System.Drawing.Point(323, 16);
         this.lblFromLP.Name = "lblFromLP";
         this.lblFromLP.Size = new System.Drawing.Size(33, 13);
         this.lblFromLP.TabIndex = 16;
         this.lblFromLP.Text = "From:";
         // 
         // dtPickerLPFrom
         // 
         this.dtPickerLPFrom.CustomFormat = "yyyy-MM-dd";
         this.dtPickerLPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.dtPickerLPFrom.Location = new System.Drawing.Point(362, 13);
         this.dtPickerLPFrom.MaxDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
         this.dtPickerLPFrom.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
         this.dtPickerLPFrom.Name = "dtPickerLPFrom";
         this.dtPickerLPFrom.Size = new System.Drawing.Size(65, 20);
         this.dtPickerLPFrom.TabIndex = 17;
         this.dtPickerLPFrom.Value = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Location = new System.Drawing.Point(15, 39);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(56, 13);
         this.lblPassword.TabIndex = 23;
         this.lblPassword.Text = "Password:";
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(79, 36);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '●';
         this.txtPassword.Size = new System.Drawing.Size(100, 20);
         this.txtPassword.TabIndex = 24;
         this.txtPassword.Text = "maxim";
         // 
         // btnCreateReport
         // 
         this.btnCreateReport.Enabled = false;
         this.btnCreateReport.Location = new System.Drawing.Point(462, 11);
         this.btnCreateReport.Name = "btnCreateReport";
         this.btnCreateReport.Size = new System.Drawing.Size(100, 21);
         this.btnCreateReport.TabIndex = 27;
         this.btnCreateReport.Text = "Create Report";
         this.btnCreateReport.UseVisualStyleBackColor = true;
         this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
         // 
         // btnShowAllRP
         // 
         this.btnShowAllRP.Enabled = false;
         this.btnShowAllRP.Location = new System.Drawing.Point(462, 38);
         this.btnShowAllRP.Name = "btnShowAllRP";
         this.btnShowAllRP.Size = new System.Drawing.Size(100, 21);
         this.btnShowAllRP.TabIndex = 28;
         this.btnShowAllRP.Text = "Show All Clients";
         this.btnShowAllRP.UseVisualStyleBackColor = true;
         this.btnShowAllRP.Click += new System.EventHandler(this.btnShowAllRP_Click);
         // 
         // reportViewer1
         // 
         reportDataSource1.Name = "DataSet1";
         reportDataSource1.Value = this.DataTable1BindingSource;
         this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
         this.reportViewer1.LocalReport.ReportEmbeddedResource = "OboronEnergoProject.Report2.rdlc";
         this.reportViewer1.Location = new System.Drawing.Point(12, 191);
         this.reportViewer1.Name = "reportViewer1";
         this.reportViewer1.Size = new System.Drawing.Size(900, 440);
         this.reportViewer1.TabIndex = 30;
         this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
         // 
         // DataTable1TableAdapter
         // 
         this.DataTable1TableAdapter.ClearBeforeFill = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(924, 643);
         this.Controls.Add(this.reportViewer1);
         this.Controls.Add(this.btnShowAllRP);
         this.Controls.Add(this.btnCreateReport);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.lblPassword);
         this.Controls.Add(this.rbNP);
         this.Controls.Add(this.rbLP);
         this.Controls.Add(this.gbLP);
         this.Controls.Add(this.gbNP);
         this.Controls.Add(this.btnSignIn);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.lblUsername);
         this.Controls.Add(this.txtHost);
         this.Controls.Add(this.lblHost);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
         this.gbNP.ResumeLayout(false);
         this.gbNP.PerformLayout();
         this.gbLP.ResumeLayout(false);
         this.gbLP.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
    
      private System.Windows.Forms.Label lblHost;
      private System.Windows.Forms.TextBox txtHost;
      private System.Windows.Forms.Label lblUsername;
      private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.Button btnSignIn;
      private System.Windows.Forms.Label lblSurname;
      private System.Windows.Forms.TextBox txtSurname;
      private System.Windows.Forms.Label lblName;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.Label lblMiddleName;
      private System.Windows.Forms.TextBox txtMiddleName;
      private System.Windows.Forms.Label lblIDNP;
      private System.Windows.Forms.TextBox txtNPID;
      private System.Windows.Forms.GroupBox gbNP;
      private System.Windows.Forms.RadioButton rbNP;
      private System.Windows.Forms.Label lblCompanyName;
      private System.Windows.Forms.TextBox txtCompanyName;
      private System.Windows.Forms.Label lblIDLP;
      private System.Windows.Forms.TextBox txtLPID;
      private System.Windows.Forms.RadioButton rbLP;
      private System.Windows.Forms.GroupBox gbLP;
      private System.Windows.Forms.Label lblPassword;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Button btnCreateReport;

      private System.Windows.Forms.DateTimePicker dtPickerLPFrom;
      private System.Windows.Forms.Label lblToLP;
      private System.Windows.Forms.Label lblFromLP;
      private System.Windows.Forms.Label lblToNP;
      private System.Windows.Forms.Label lblFromNP;
      private System.Windows.Forms.DateTimePicker dtPickerLPTo;
      private System.Windows.Forms.DateTimePicker dtPickerNPTo;
      private System.Windows.Forms.DateTimePicker dtPickerNPFrom;
      private System.Windows.Forms.BindingSource DataTable1BindingSource;
      private DataSet1 DataSet1;
      private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
      private System.Windows.Forms.Button btnShowAllRP;
      private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

   }
}

