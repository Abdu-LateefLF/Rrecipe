namespace Rrecipe.Pages
{
    partial class ViewRecipesPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.recipeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearSearchBtn = new System.Windows.Forms.Button();
            this.searchTxtbox = new System.Windows.Forms.TextBox();
            this.enterSearchBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Recipes";
            // 
            // recipeFlowPanel
            // 
            this.recipeFlowPanel.AutoScroll = true;
            this.recipeFlowPanel.Location = new System.Drawing.Point(20, 83);
            this.recipeFlowPanel.Name = "recipeFlowPanel";
            this.recipeFlowPanel.Size = new System.Drawing.Size(732, 449);
            this.recipeFlowPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearSearchBtn);
            this.panel1.Controls.Add(this.searchTxtbox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(239, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 41);
            this.panel1.TabIndex = 3;
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.FlatAppearance.BorderSize = 0;
            this.clearSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSearchBtn.ForeColor = System.Drawing.Color.LightGray;
            this.clearSearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearSearchBtn.Location = new System.Drawing.Point(385, 0);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(42, 40);
            this.clearSearchBtn.TabIndex = 2;
            this.clearSearchBtn.Text = "X";
            this.clearSearchBtn.UseVisualStyleBackColor = true;
            this.clearSearchBtn.Click += new System.EventHandler(this.clearSearchBtn_Click);
            // 
            // searchTxtbox
            // 
            this.searchTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTxtbox.BackColor = System.Drawing.Color.DimGray;
            this.searchTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxtbox.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtbox.Location = new System.Drawing.Point(3, 10);
            this.searchTxtbox.Name = "searchTxtbox";
            this.searchTxtbox.Size = new System.Drawing.Size(386, 34);
            this.searchTxtbox.TabIndex = 0;
            this.searchTxtbox.Text = "Search";
            this.searchTxtbox.Enter += new System.EventHandler(this.searchTxtbox_Enter);
            this.searchTxtbox.Leave += new System.EventHandler(this.searchTxtbox_Leave);
            // 
            // enterSearchBtn
            // 
            this.enterSearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enterSearchBtn.FlatAppearance.BorderSize = 0;
            this.enterSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterSearchBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterSearchBtn.Location = new System.Drawing.Point(673, 13);
            this.enterSearchBtn.Name = "enterSearchBtn";
            this.enterSearchBtn.Size = new System.Drawing.Size(79, 40);
            this.enterSearchBtn.TabIndex = 4;
            this.enterSearchBtn.Text = "Enter";
            this.enterSearchBtn.UseVisualStyleBackColor = false;
            this.enterSearchBtn.Click += new System.EventHandler(this.enterSearchBtn_Click);
            // 
            // ViewRecipesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.enterSearchBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.recipeFlowPanel);
            this.Controls.Add(this.label1);
            this.Name = "ViewRecipesPanel";
            this.Size = new System.Drawing.Size(782, 563);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel recipeFlowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTxtbox;
        private System.Windows.Forms.Button clearSearchBtn;
        private System.Windows.Forms.Button enterSearchBtn;
    }
}
