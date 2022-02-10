namespace My_Menu
{
    partial class DialogIngredients
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.checkBoxIsVegan = new System.Windows.Forms.CheckBox();
            this.labelRecipe = new System.Windows.Forms.Label();
            this.errorProviderIngredients = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxIngredients
            // 
            this.checkedListBoxIngredients.CheckOnClick = true;
            this.checkedListBoxIngredients.FormattingEnabled = true;
            this.checkedListBoxIngredients.Location = new System.Drawing.Point(27, 46);
            this.checkedListBoxIngredients.Name = "checkedListBoxIngredients";
            this.checkedListBoxIngredients.Size = new System.Drawing.Size(278, 304);
            this.checkedListBoxIngredients.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(152, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 17);
            this.labelName.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(221, 410);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 28);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(131, 410);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 28);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonAddIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddIngredient.Location = new System.Drawing.Point(169, 361);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(136, 26);
            this.buttonAddIngredient.TabIndex = 4;
            this.buttonAddIngredient.Text = "Новый ингредиент";
            this.buttonAddIngredient.UseVisualStyleBackColor = false;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // checkBoxIsVegan
            // 
            this.checkBoxIsVegan.AutoSize = true;
            this.checkBoxIsVegan.Location = new System.Drawing.Point(27, 365);
            this.checkBoxIsVegan.Name = "checkBoxIsVegan";
            this.checkBoxIsVegan.Size = new System.Drawing.Size(87, 21);
            this.checkBoxIsVegan.TabIndex = 5;
            this.checkBoxIsVegan.Text = "Веганское";
            this.checkBoxIsVegan.UseVisualStyleBackColor = true;
            this.checkBoxIsVegan.CheckedChanged += new System.EventHandler(this.checkBoxIsVegan_CheckedChanged);
            // 
            // labelRecipe
            // 
            this.labelRecipe.AutoSize = true;
            this.labelRecipe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRecipe.Location = new System.Drawing.Point(27, 23);
            this.labelRecipe.MaximumSize = new System.Drawing.Size(275, 0);
            this.labelRecipe.MinimumSize = new System.Drawing.Size(275, 0);
            this.labelRecipe.Name = "labelRecipe";
            this.labelRecipe.Size = new System.Drawing.Size(275, 20);
            this.labelRecipe.TabIndex = 6;
            this.labelRecipe.Text = "Recipe Name";
            this.labelRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProviderIngredients
            // 
            this.errorProviderIngredients.ContainerControl = this;
            // 
            // DialogIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.labelRecipe);
            this.Controls.Add(this.checkBoxIsVegan);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.checkedListBoxIngredients);
            this.MaximizeBox = false;
            this.Name = "DialogIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменить состав";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogIngredients_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogIngredients_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBoxIngredients;
        private Label labelName;
        private Button buttonSave;
        private Button buttonCancel;
        private Button buttonAddIngredient;
        private CheckBox checkBoxIsVegan;
        private Label labelRecipe;
        private ErrorProvider errorProviderIngredients;
    }
}