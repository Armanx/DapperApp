
namespace DapperApp.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnActors = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnDirectors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMovies
            // 
            this.btnMovies.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMovies.Location = new System.Drawing.Point(384, 108);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(218, 182);
            this.btnMovies.TabIndex = 0;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = true;
            // 
            // btnActors
            // 
            this.btnActors.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActors.Location = new System.Drawing.Point(608, 108);
            this.btnActors.Name = "btnActors";
            this.btnActors.Size = new System.Drawing.Size(218, 182);
            this.btnActors.TabIndex = 1;
            this.btnActors.Text = "Actors";
            this.btnActors.UseVisualStyleBackColor = true;
            // 
            // btnGenre
            // 
            this.btnGenre.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenre.Location = new System.Drawing.Point(384, 296);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Size = new System.Drawing.Size(218, 182);
            this.btnGenre.TabIndex = 2;
            this.btnGenre.Text = "Genres ";
            this.btnGenre.UseVisualStyleBackColor = true;
            // 
            // btnDirectors
            // 
            this.btnDirectors.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDirectors.Location = new System.Drawing.Point(608, 296);
            this.btnDirectors.Name = "btnDirectors";
            this.btnDirectors.Size = new System.Drawing.Size(218, 182);
            this.btnDirectors.TabIndex = 3;
            this.btnDirectors.Text = "Directors";
            this.btnDirectors.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.btnDirectors);
            this.Controls.Add(this.btnGenre);
            this.Controls.Add(this.btnActors);
            this.Controls.Add(this.btnMovies);
            this.Name = "MainForm";
            this.Text = "MovieDb";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnActors;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnDirectors;
    }
}

