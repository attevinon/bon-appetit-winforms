namespace My_Menu
{
    partial class FormNewRecipe
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxVegan = new System.Windows.Forms.CheckBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxDirections = new System.Windows.Forms.TextBox();
            this.checkedListBoxMealIngredients = new System.Windows.Forms.CheckedListBox();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDirections = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIngredients = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDirections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(56, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(242, 25);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(56, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            // 
            // checkBoxVegan
            // 
            this.checkBoxVegan.AutoSize = true;
            this.checkBoxVegan.Location = new System.Drawing.Point(584, 382);
            this.checkBoxVegan.Name = "checkBoxVegan";
            this.checkBoxVegan.Size = new System.Drawing.Size(87, 21);
            this.checkBoxVegan.TabIndex = 2;
            this.checkBoxVegan.Text = "Веганское";
            this.checkBoxVegan.UseVisualStyleBackColor = true;
            this.checkBoxVegan.CheckedChanged += new System.EventHandler(this.checkBoxVegan_CheckedChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(56, 134);
            this.textBoxDescription.MaxLength = 100;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(316, 71);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxDirections
            // 
            this.textBoxDirections.Location = new System.Drawing.Point(56, 256);
            this.textBoxDirections.Multiline = true;
            this.textBoxDirections.Name = "textBoxDirections";
            this.textBoxDirections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDirections.Size = new System.Drawing.Size(316, 149);
            this.textBoxDirections.TabIndex = 4;
            this.textBoxDirections.TextChanged += new System.EventHandler(this.textBoxDirections_TextChanged);
            // 
            // checkedListBoxMealIngredients
            // 
            this.checkedListBoxMealIngredients.CheckOnClick = true;
            this.checkedListBoxMealIngredients.FormattingEnabled = true;
            this.checkedListBoxMealIngredients.Location = new System.Drawing.Point(423, 60);
            this.checkedListBoxMealIngredients.Name = "checkedListBoxMealIngredients";
            this.checkedListBoxMealIngredients.Size = new System.Drawing.Size(248, 284);
            this.checkedListBoxMealIngredients.TabIndex = 5;
            this.checkedListBoxMealIngredients.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxMealIngredients_SelectedIndexChanged);
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(423, 30);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(149, 17);
            this.labelIngredients.TabIndex = 6;
            this.labelIngredients.Text = "Выберите ингредиенты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Приготовление:";
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonAddIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddIngredient.Location = new System.Drawing.Point(423, 378);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(143, 27);
            this.buttonAddIngredient.TabIndex = 9;
            this.buttonAddIngredient.Text = "Добавить игредиент";
            this.buttonAddIngredient.UseVisualStyleBackColor = false;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Location = new System.Drawing.Point(628, 447);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 27);
            this.buttonDone.TabIndex = 10;
            this.buttonDone.Text = "Готово!";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(530, 447);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-4, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 440);
            this.panel1.TabIndex = 12;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderDescription
            // 
            this.errorProviderDescription.ContainerControl = this;
            // 
            // errorProviderDirections
            // 
            this.errorProviderDirections.ContainerControl = this;
            // 
            // errorProviderIngredients
            // 
            this.errorProviderIngredients.ContainerControl = this;
            // 
            // FormNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(729, 487);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.checkedListBoxMealIngredients);
            this.Controls.Add(this.textBoxDirections);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxVegan);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormNewRecipe";
            this.Text = "Добавить новый рецепт";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewRecipe_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNewRecipe_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDirections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private Label labelName;
        private CheckBox checkBoxVegan;
        private TextBox textBoxDescription;
        private TextBox textBoxDirections;
        private CheckedListBox checkedListBoxMealIngredients;
        private Label labelIngredients;
        private Label label1;
        private Label label2;
        private Button buttonAddIngredient;
        private Button buttonDone;
        private Button buttonCancel;
        private Panel panel1;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderDescription;
        private ErrorProvider errorProviderDirections;
        private ErrorProvider errorProviderIngredients;
    }
}