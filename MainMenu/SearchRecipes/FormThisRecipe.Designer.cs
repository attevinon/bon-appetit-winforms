namespace My_Menu
{
    partial class FormThisRecipe
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelIsVegan = new System.Windows.Forms.Label();
            this.textCooking = new System.Windows.Forms.TextBox();
            this.labelCooking = new System.Windows.Forms.Label();
            this.textIngredients = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.PeachPuff;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(59, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIngredients.Location = new System.Drawing.Point(6, 3);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(96, 17);
            this.labelIngredients.TabIndex = 2;
            this.labelIngredients.Text = "Ингредиенты:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(6, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(73, 17);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Описание:";
            // 
            // labelIsVegan
            // 
            this.labelIsVegan.AutoSize = true;
            this.labelIsVegan.BackColor = System.Drawing.Color.OliveDrab;
            this.labelIsVegan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelIsVegan.ForeColor = System.Drawing.Color.Ivory;
            this.labelIsVegan.Location = new System.Drawing.Point(59, 389);
            this.labelIsVegan.Name = "labelIsVegan";
            this.labelIsVegan.Size = new System.Drawing.Size(153, 17);
            this.labelIsVegan.TabIndex = 4;
            this.labelIsVegan.Text = "Подходит для веганов!";
            // 
            // textCooking
            // 
            this.textCooking.BackColor = System.Drawing.Color.Ivory;
            this.textCooking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCooking.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textCooking.Location = new System.Drawing.Point(345, 64);
            this.textCooking.MaxLength = 30000;
            this.textCooking.Multiline = true;
            this.textCooking.Name = "textCooking";
            this.textCooking.ReadOnly = true;
            this.textCooking.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCooking.Size = new System.Drawing.Size(296, 343);
            this.textCooking.TabIndex = 7;
            // 
            // labelCooking
            // 
            this.labelCooking.AutoSize = true;
            this.labelCooking.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCooking.Location = new System.Drawing.Point(345, 31);
            this.labelCooking.Name = "labelCooking";
            this.labelCooking.Size = new System.Drawing.Size(108, 17);
            this.labelCooking.TabIndex = 8;
            this.labelCooking.Text = "Приготовление:";
            // 
            // textIngredients
            // 
            this.textIngredients.AutoSize = true;
            this.textIngredients.Location = new System.Drawing.Point(7, 30);
            this.textIngredients.MaximumSize = new System.Drawing.Size(260, 130);
            this.textIngredients.Name = "textIngredients";
            this.textIngredients.Size = new System.Drawing.Size(31, 17);
            this.textIngredients.TabIndex = 9;
            this.textIngredients.Text = "Ingr";
            // 
            // textDescription
            // 
            this.textDescription.AutoSize = true;
            this.textDescription.Location = new System.Drawing.Point(7, 35);
            this.textDescription.MaximumSize = new System.Drawing.Size(260, 150);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(74, 17);
            this.textDescription.TabIndex = 10;
            this.textDescription.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textIngredients);
            this.panel1.Controls.Add(this.labelIngredients);
            this.panel1.Location = new System.Drawing.Point(59, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 146);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textDescription);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Location = new System.Drawing.Point(59, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 155);
            this.panel2.TabIndex = 12;
            // 
            // FormThisRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(694, 456);
            this.Controls.Add(this.labelCooking);
            this.Controls.Add(this.textCooking);
            this.Controls.Add(this.labelIsVegan);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "FormThisRecipe";
            this.Text = "Рецепт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThisRecipe_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private Label labelIngredients;
        private Label labelDescription;
        private Label labelIsVegan;
        private TextBox textCooking;
        private Label labelCooking;
        private Label textIngredients;
        private Label textDescription;
        private Panel panel1;
        private Panel panel2;
    }
}