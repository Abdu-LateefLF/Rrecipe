namespace Rrecipe
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.viewRecipesTabBtn = new System.Windows.Forms.Panel();
            this.selectIndictor = new System.Windows.Forms.Panel();
            this.viewRecipesBtn = new System.Windows.Forms.Button();
            this.createRecipeTabBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.recipeDetailsPanel = new Rrecipe.Pages.RecipeDetailsPanel();
            this.viewRecipesPanel = new Rrecipe.Pages.ViewRecipesPanel();
            this.createRecipePanel = new Rrecipe.Pages.CreateRecipePanel();
            this.viewRecipesTabBtn.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewRecipesTabBtn
            // 
            this.viewRecipesTabBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewRecipesTabBtn.Controls.Add(this.selectIndictor);
            this.viewRecipesTabBtn.Controls.Add(this.viewRecipesBtn);
            this.viewRecipesTabBtn.Controls.Add(this.createRecipeTabBtn);
            this.viewRecipesTabBtn.Controls.Add(this.panel3);
            this.viewRecipesTabBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewRecipesTabBtn.Location = new System.Drawing.Point(0, 0);
            this.viewRecipesTabBtn.Name = "viewRecipesTabBtn";
            this.viewRecipesTabBtn.Size = new System.Drawing.Size(200, 615);
            this.viewRecipesTabBtn.TabIndex = 0;
            // 
            // selectIndictor
            // 
            this.selectIndictor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.selectIndictor.Location = new System.Drawing.Point(3, 345);
            this.selectIndictor.Name = "selectIndictor";
            this.selectIndictor.Size = new System.Drawing.Size(10, 100);
            this.selectIndictor.TabIndex = 3;
            // 
            // viewRecipesBtn
            // 
            this.viewRecipesBtn.BackColor = System.Drawing.Color.Black;
            this.viewRecipesBtn.FlatAppearance.BorderSize = 0;
            this.viewRecipesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewRecipesBtn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecipesBtn.Location = new System.Drawing.Point(0, 274);
            this.viewRecipesBtn.Name = "viewRecipesBtn";
            this.viewRecipesBtn.Size = new System.Drawing.Size(200, 55);
            this.viewRecipesBtn.TabIndex = 2;
            this.viewRecipesBtn.Text = "View Recipes";
            this.viewRecipesBtn.UseVisualStyleBackColor = false;
            this.viewRecipesBtn.Click += new System.EventHandler(this.viewRecipesBtn_Click);
            // 
            // createRecipeTabBtn
            // 
            this.createRecipeTabBtn.BackColor = System.Drawing.Color.Black;
            this.createRecipeTabBtn.FlatAppearance.BorderSize = 0;
            this.createRecipeTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createRecipeTabBtn.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRecipeTabBtn.Location = new System.Drawing.Point(0, 213);
            this.createRecipeTabBtn.Name = "createRecipeTabBtn";
            this.createRecipeTabBtn.Size = new System.Drawing.Size(200, 55);
            this.createRecipeTabBtn.TabIndex = 1;
            this.createRecipeTabBtn.Text = "Create Recipe";
            this.createRecipeTabBtn.UseVisualStyleBackColor = false;
            this.createRecipeTabBtn.Click += new System.EventHandler(this.createRecipeTabBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.usernameLbl);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 207);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rrecipe.Properties.Resources.IconSmall;
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // usernameLbl
            // 
            this.usernameLbl.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.usernameLbl.Location = new System.Drawing.Point(12, 173);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(173, 25);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rrecipe.Properties.Resources.User_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(33, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "RRecipe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(735, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(44, 46);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.logOutBtn);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 52);
            this.panel2.TabIndex = 2;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Red;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(638, 9);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(91, 34);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // recipeDetailsPanel
            // 
            this.recipeDetailsPanel.BackColor = System.Drawing.Color.Gray;
            this.recipeDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeDetailsPanel.Location = new System.Drawing.Point(200, 52);
            this.recipeDetailsPanel.Name = "recipeDetailsPanel";
            this.recipeDetailsPanel.Size = new System.Drawing.Size(782, 563);
            this.recipeDetailsPanel.TabIndex = 5;
            // 
            // viewRecipesPanel
            // 
            this.viewRecipesPanel.BackColor = System.Drawing.Color.Gray;
            this.viewRecipesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewRecipesPanel.Location = new System.Drawing.Point(200, 52);
            this.viewRecipesPanel.Name = "viewRecipesPanel";
            this.viewRecipesPanel.Size = new System.Drawing.Size(782, 563);
            this.viewRecipesPanel.TabIndex = 4;
            // 
            // createRecipePanel
            // 
            this.createRecipePanel.BackColor = System.Drawing.Color.Gray;
            this.createRecipePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createRecipePanel.Location = new System.Drawing.Point(200, 52);
            this.createRecipePanel.Name = "createRecipePanel";
            this.createRecipePanel.Size = new System.Drawing.Size(782, 563);
            this.createRecipePanel.TabIndex = 3;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(982, 615);
            this.Controls.Add(this.recipeDetailsPanel);
            this.Controls.Add(this.viewRecipesPanel);
            this.Controls.Add(this.createRecipePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.viewRecipesTabBtn);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.viewRecipesTabBtn.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewRecipesTabBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Pages.CreateRecipePanel createRecipePanel;
        private System.Windows.Forms.Button createRecipeTabBtn;
        private System.Windows.Forms.Button viewRecipesBtn;
        private System.Windows.Forms.Panel selectIndictor;
        private Pages.ViewRecipesPanel viewRecipesPanel;
        private Pages.RecipeDetailsPanel recipeDetailsPanel;
    }
}

