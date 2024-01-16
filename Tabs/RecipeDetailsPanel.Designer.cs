namespace Rrecipe.Pages
{
    partial class RecipeDetailsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.recipeNameLbl = new System.Windows.Forms.Label();
            this.prepTimeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.instructionsTxtbox = new System.Windows.Forms.TextBox();
            this.backToListBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recipeNameLbl
            // 
            this.recipeNameLbl.AutoSize = true;
            this.recipeNameLbl.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipeNameLbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.recipeNameLbl.Location = new System.Drawing.Point(13, 12);
            this.recipeNameLbl.Name = "recipeNameLbl";
            this.recipeNameLbl.Size = new System.Drawing.Size(212, 41);
            this.recipeNameLbl.TabIndex = 2;
            this.recipeNameLbl.Text = "Recipe Name";
            // 
            // prepTimeLbl
            // 
            this.prepTimeLbl.AutoSize = true;
            this.prepTimeLbl.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prepTimeLbl.Location = new System.Drawing.Point(15, 66);
            this.prepTimeLbl.Name = "prepTimeLbl";
            this.prepTimeLbl.Size = new System.Drawing.Size(138, 25);
            this.prepTimeLbl.TabIndex = 3;
            this.prepTimeLbl.Text = "Prep Time: --";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(20, 134);
            this.descriptionTxtBox.Multiline = true;
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.ReadOnly = true;
            this.descriptionTxtBox.Size = new System.Drawing.Size(283, 96);
            this.descriptionTxtBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingredients";
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.Location = new System.Drawing.Point(20, 273);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(241, 251);
            this.ingredientsListBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(342, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Instructions";
            // 
            // instructionsTxtbox
            // 
            this.instructionsTxtbox.Location = new System.Drawing.Point(347, 133);
            this.instructionsTxtbox.Multiline = true;
            this.instructionsTxtbox.Name = "instructionsTxtbox";
            this.instructionsTxtbox.ReadOnly = true;
            this.instructionsTxtbox.Size = new System.Drawing.Size(404, 391);
            this.instructionsTxtbox.TabIndex = 9;
            // 
            // backToListBtn
            // 
            this.backToListBtn.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToListBtn.Location = new System.Drawing.Point(624, 20);
            this.backToListBtn.Name = "backToListBtn";
            this.backToListBtn.Size = new System.Drawing.Size(127, 33);
            this.backToListBtn.TabIndex = 16;
            this.backToListBtn.Text = "Back to List";
            this.backToListBtn.UseVisualStyleBackColor = true;
            this.backToListBtn.Click += new System.EventHandler(this.backToListBtn_Click);
            // 
            // RecipeDetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.backToListBtn);
            this.Controls.Add(this.instructionsTxtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ingredientsListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prepTimeLbl);
            this.Controls.Add(this.recipeNameLbl);
            this.Name = "RecipeDetailsPanel";
            this.Size = new System.Drawing.Size(782, 563);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipeNameLbl;
        private System.Windows.Forms.Label prepTimeLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox instructionsTxtbox;
        private System.Windows.Forms.Button backToListBtn;
    }
}
