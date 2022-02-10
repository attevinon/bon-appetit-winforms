namespace My_Menu
{
    partial class FormMainMenu
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonGetRecipe = new System.Windows.Forms.Button();
            this.buttonEditRecipes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelMenu.ForeColor = System.Drawing.Color.Ivory;
            this.labelMenu.Location = new System.Drawing.Point(92, 81);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(318, 46);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "~ Смачна есці! ~";
            // 
            // buttonGetRecipe
            // 
            this.buttonGetRecipe.BackColor = System.Drawing.Color.Ivory;
            this.buttonGetRecipe.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.buttonGetRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Beige;
            this.buttonGetRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetRecipe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGetRecipe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGetRecipe.Location = new System.Drawing.Point(136, 186);
            this.buttonGetRecipe.Name = "buttonGetRecipe";
            this.buttonGetRecipe.Size = new System.Drawing.Size(214, 54);
            this.buttonGetRecipe.TabIndex = 1;
            this.buttonGetRecipe.Text = "Что бы приготовить?";
            this.buttonGetRecipe.UseVisualStyleBackColor = false;
            this.buttonGetRecipe.Click += new System.EventHandler(this.buttonGetRecipe_Click);
            // 
            // buttonEditRecipes
            // 
            this.buttonEditRecipes.BackColor = System.Drawing.Color.Ivory;
            this.buttonEditRecipes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.buttonEditRecipes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Beige;
            this.buttonEditRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditRecipes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEditRecipes.Location = new System.Drawing.Point(136, 275);
            this.buttonEditRecipes.Name = "buttonEditRecipes";
            this.buttonEditRecipes.Size = new System.Drawing.Size(214, 54);
            this.buttonEditRecipes.TabIndex = 2;
            this.buttonEditRecipes.Text = "Редактировать рецепты";
            this.buttonEditRecipes.UseVisualStyleBackColor = false;
            this.buttonEditRecipes.Click += new System.EventHandler(this.buttonEditRecipes_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(489, 446);
            this.Controls.Add(this.buttonEditRecipes);
            this.Controls.Add(this.buttonGetRecipe);
            this.Controls.Add(this.labelMenu);
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смачна есці!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelMenu;
        private Button buttonGetRecipe;
        private Button buttonEditRecipes;
    }
}