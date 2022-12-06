namespace Assesment
{
    partial class Form1
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
            this.Ingredientslstbox = new System.Windows.Forms.ListBox();
            this.recipeListBox = new System.Windows.Forms.ListBox();
            this.Addbtn1 = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.Deletebtn1 = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ingredientslstbox
            // 
            this.Ingredientslstbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Ingredientslstbox.FormattingEnabled = true;
            this.Ingredientslstbox.ItemHeight = 15;
            this.Ingredientslstbox.Location = new System.Drawing.Point(224, 94);
            this.Ingredientslstbox.Name = "Ingredientslstbox";
            this.Ingredientslstbox.Size = new System.Drawing.Size(120, 94);
            this.Ingredientslstbox.TabIndex = 0;
            // 
            // recipeListBox
            // 
            this.recipeListBox.BackColor = System.Drawing.Color.Cyan;
            this.recipeListBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.recipeListBox.FormattingEnabled = true;
            this.recipeListBox.ItemHeight = 15;
            this.recipeListBox.Location = new System.Drawing.Point(445, 94);
            this.recipeListBox.Name = "recipeListBox";
            this.recipeListBox.Size = new System.Drawing.Size(120, 94);
            this.recipeListBox.TabIndex = 1;
            this.recipeListBox.SelectedIndexChanged += new System.EventHandler(this.Recipe_SelectedIndexChanged);
            // 
            // Addbtn1
            // 
            this.Addbtn1.BackColor = System.Drawing.Color.Lime;
            this.Addbtn1.Location = new System.Drawing.Point(102, 117);
            this.Addbtn1.Name = "Addbtn1";
            this.Addbtn1.Size = new System.Drawing.Size(75, 23);
            this.Addbtn1.TabIndex = 2;
            this.Addbtn1.Text = "Add";
            this.Addbtn1.UseVisualStyleBackColor = false;
            this.Addbtn1.Click += new System.EventHandler(this.Addbtn1_Click);
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(102, 79);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 23);
            this.txtbox1.TabIndex = 3;
            // 
            // Deletebtn1
            // 
            this.Deletebtn1.BackColor = System.Drawing.Color.Red;
            this.Deletebtn1.Location = new System.Drawing.Point(102, 165);
            this.Deletebtn1.Name = "Deletebtn1";
            this.Deletebtn1.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn1.TabIndex = 4;
            this.Deletebtn1.Text = "Delete";
            this.Deletebtn1.UseVisualStyleBackColor = false;
            this.Deletebtn1.Click += new System.EventHandler(this.Deletebtn1_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Silver;
            this.searchButton.ForeColor = System.Drawing.Color.Maroon;
            this.searchButton.Location = new System.Drawing.Point(102, 208);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.Deletebtn1);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.Addbtn1);
            this.Controls.Add(this.recipeListBox);
            this.Controls.Add(this.Ingredientslstbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Ingredientslstbox;
        private ListBox recipeListBox;
        private Button Addbtn1;
        private TextBox txtbox1;
        private Button Deletebtn1;
        private Button searchButton;
    }
}