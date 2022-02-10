namespace My_Menu
{
    partial class FormSearchRecipe
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
            this.checkedListBoxIngredients = new System.Windows.Forms.CheckedListBox();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.buttonSearchRecipes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxVegan = new System.Windows.Forms.CheckBox();
            this.labelNoRecipes = new System.Windows.Forms.Label();
            this.toolTipDescriptipn = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // checkedListBoxIngredients
            // 
            this.checkedListBoxIngredients.CheckOnClick = true;
            this.checkedListBoxIngredients.FormattingEnabled = true;
            this.checkedListBoxIngredients.Location = new System.Drawing.Point(50, 71);
            this.checkedListBoxIngredients.Name = "checkedListBoxIngredients";
            this.checkedListBoxIngredients.Size = new System.Drawing.Size(233, 264);
            this.checkedListBoxIngredients.Sorted = true;
            this.checkedListBoxIngredients.TabIndex = 0;
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.ItemHeight = 17;
            this.listBoxRecipes.Location = new System.Drawing.Point(361, 71);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(276, 327);
            this.listBoxRecipes.TabIndex = 1;
            this.listBoxRecipes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxRecipes_MouseDoubleClick);
            this.listBoxRecipes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxRecipes_MouseMove);
            // 
            // buttonSearchRecipes
            // 
            this.buttonSearchRecipes.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonSearchRecipes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearchRecipes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSearchRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchRecipes.Location = new System.Drawing.Point(208, 364);
            this.buttonSearchRecipes.Name = "buttonSearchRecipes";
            this.buttonSearchRecipes.Size = new System.Drawing.Size(75, 27);
            this.buttonSearchRecipes.TabIndex = 2;
            this.buttonSearchRecipes.Text = "Поиск";
            this.buttonSearchRecipes.UseVisualStyleBackColor = false;
            this.buttonSearchRecipes.Click += new System.EventHandler(this.buttonSearchRecipes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите ингредиенты:";
            // 
            // checkBoxVegan
            // 
            this.checkBoxVegan.AutoSize = true;
            this.checkBoxVegan.Location = new System.Drawing.Point(50, 368);
            this.checkBoxVegan.Name = "checkBoxVegan";
            this.checkBoxVegan.Size = new System.Drawing.Size(87, 21);
            this.checkBoxVegan.TabIndex = 4;
            this.checkBoxVegan.Text = "Веганское";
            this.checkBoxVegan.UseVisualStyleBackColor = true;
            this.checkBoxVegan.CheckedChanged += new System.EventHandler(this.checkBoxVegan_CheckedChanged);
            // 
            // labelNoRecipes
            // 
            this.labelNoRecipes.AutoSize = true;
            this.labelNoRecipes.BackColor = System.Drawing.SystemColors.Window;
            this.labelNoRecipes.Location = new System.Drawing.Point(430, 133);
            this.labelNoRecipes.Name = "labelNoRecipes";
            this.labelNoRecipes.Size = new System.Drawing.Size(139, 17);
            this.labelNoRecipes.TabIndex = 5;
            this.labelNoRecipes.Text = "Рецептов не найдено!";
            this.labelNoRecipes.Visible = false;
            // 
            // FormSearchRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.labelNoRecipes);
            this.Controls.Add(this.checkBoxVegan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchRecipes);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.checkedListBoxIngredients);
            this.MaximizeBox = false;
            this.Name = "FormSearchRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск рецептов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSearchRecipe_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBoxIngredients;
        private ListBox listBoxRecipes;
        private Button buttonSearchRecipes;
        private Label label1;
        private CheckBox checkBoxVegan;
        private Label labelNoRecipes;
        private ToolTip toolTipDescriptipn;
    }
}