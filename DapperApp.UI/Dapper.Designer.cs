
namespace DapperApp.UI
{
    partial class Dapper
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
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSetInitiCatalog = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tbOutWindows = new System.Windows.Forms.TextBox();
            this.tbArguments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(12, 367);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(91, 71);
            this.btnCreateDB.TabIndex = 0;
            this.btnCreateDB.Text = "Create DB";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(109, 367);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(91, 71);
            this.btnCreateTable.TabIndex = 1;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSetInitiCatalog
            // 
            this.btnSetInitiCatalog.Location = new System.Drawing.Point(206, 367);
            this.btnSetInitiCatalog.Name = "btnSetInitiCatalog";
            this.btnSetInitiCatalog.Size = new System.Drawing.Size(91, 71);
            this.btnSetInitiCatalog.TabIndex = 2;
            this.btnSetInitiCatalog.Text = "Set Init Catalog";
            this.btnSetInitiCatalog.UseVisualStyleBackColor = true;
            this.btnSetInitiCatalog.Click += new System.EventHandler(this.btnSetInitiCatalog_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(691, 367);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 71);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(594, 367);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 71);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(497, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 71);
            this.button7.TabIndex = 5;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(400, 367);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 71);
            this.button8.TabIndex = 4;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // tbOutWindows
            // 
            this.tbOutWindows.Location = new System.Drawing.Point(26, 18);
            this.tbOutWindows.Multiline = true;
            this.tbOutWindows.Name = "tbOutWindows";
            this.tbOutWindows.Size = new System.Drawing.Size(755, 292);
            this.tbOutWindows.TabIndex = 8;
            // 
            // tbArguments
            // 
            this.tbArguments.Location = new System.Drawing.Point(109, 316);
            this.tbArguments.Name = "tbArguments";
            this.tbArguments.Size = new System.Drawing.Size(672, 23);
            this.tbArguments.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Arguments :";
            // 
            // Dapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbArguments);
            this.Controls.Add(this.tbOutWindows);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSetInitiCatalog);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnCreateDB);
            this.Name = "Dapper";
            this.Text = "Dapper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSetInitiCatalog;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbOutWindows;
        private System.Windows.Forms.TextBox tbArguments;
        private System.Windows.Forms.Label label1;
    }
}