
namespace DapperApp.UI
{
    partial class AddMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbActor = new System.Windows.Forms.TextBox();
            this.lbActor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // tbMovieName
            // 
            this.tbMovieName.Location = new System.Drawing.Point(267, 81);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.Size = new System.Drawing.Size(188, 23);
            this.tbMovieName.TabIndex = 1;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(267, 110);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(188, 23);
            this.tbYear.TabIndex = 3;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(222, 113);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(35, 15);
            this.lbYear.TabIndex = 2;
            this.lbYear.Text = "Year :";
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(267, 140);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(188, 23);
            this.tbRating.TabIndex = 5;
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(222, 143);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(41, 15);
            this.lbRating.TabIndex = 4;
            this.lbRating.Text = "Rating";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(222, 171);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(44, 15);
            this.lbGenre.TabIndex = 6;
            this.lbGenre.Text = "Genre :";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(266, 169);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(188, 23);
            this.cbGenre.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(265, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbActor
            // 
            this.tbActor.Enabled = false;
            this.tbActor.Location = new System.Drawing.Point(265, 198);
            this.tbActor.Name = "tbActor";
            this.tbActor.Size = new System.Drawing.Size(188, 23);
            this.tbActor.TabIndex = 10;
            // 
            // lbActor
            // 
            this.lbActor.AutoSize = true;
            this.lbActor.Location = new System.Drawing.Point(220, 201);
            this.lbActor.Name = "lbActor";
            this.lbActor.Size = new System.Drawing.Size(36, 15);
            this.lbActor.TabIndex = 9;
            this.lbActor.Text = "Actor";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 360);
            this.Controls.Add(this.tbActor);
            this.Controls.Add(this.lbActor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.lbRating);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.label1);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.Label lbRating;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbActor;
        private System.Windows.Forms.Label lbActor;
    }
}