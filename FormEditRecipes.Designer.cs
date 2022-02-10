namespace My_Menu
{
    partial class FormEditRecipes
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
            this.listboxMyRecipes = new System.Windows.Forms.ListBox();
            this.buttonANewRecipe = new System.Windows.Forms.Button();
            this.labelChooseRecipe = new System.Windows.Forms.Label();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonChangeIngredients = new System.Windows.Forms.Button();
            this.textBoxCooking = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCooking = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCooking = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIngredients = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxMyRecipes
            // 
            this.listboxMyRecipes.FormattingEnabled = true;
            this.listboxMyRecipes.ItemHeight = 17;
            this.listboxMyRecipes.Location = new System.Drawing.Point(34, 34);
            this.listboxMyRecipes.Name = "listboxMyRecipes";
            this.listboxMyRecipes.Size = new System.Drawing.Size(277, 344);
            this.listboxMyRecipes.TabIndex = 0;
            this.listboxMyRecipes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listboxMyRecipes_MouseClick);
            // 
            // buttonANewRecipe
            // 
            this.buttonANewRecipe.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonANewRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonANewRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonANewRecipe.Location = new System.Drawing.Point(171, 392);
            this.buttonANewRecipe.Name = "buttonANewRecipe";
            this.buttonANewRecipe.Size = new System.Drawing.Size(140, 30);
            this.buttonANewRecipe.TabIndex = 1;
            this.buttonANewRecipe.Text = "Новый рецепт";
            this.buttonANewRecipe.UseVisualStyleBackColor = false;
            this.buttonANewRecipe.Click += new System.EventHandler(this.buttonANewRecipe_Click);
            // 
            // labelChooseRecipe
            // 
            this.labelChooseRecipe.AutoSize = true;
            this.labelChooseRecipe.Location = new System.Drawing.Point(436, 76);
            this.labelChooseRecipe.Name = "labelChooseRecipe";
            this.labelChooseRecipe.Size = new System.Drawing.Size(120, 17);
            this.labelChooseRecipe.TabIndex = 2;
            this.labelChooseRecipe.Text = "Выберите рецепт...";
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.buttonCancel);
            this.panelEdit.Controls.Add(this.buttonSave);
            this.panelEdit.Controls.Add(this.buttonChangeIngredients);
            this.panelEdit.Controls.Add(this.textBoxCooking);
            this.panelEdit.Controls.Add(this.textBoxDescription);
            this.panelEdit.Controls.Add(this.textBoxName);
            this.panelEdit.Controls.Add(this.labelCooking);
            this.panelEdit.Controls.Add(this.labelDescription);
            this.panelEdit.Controls.Add(this.labelName);
            this.panelEdit.Location = new System.Drawing.Point(346, 22);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(320, 413);
            this.panelEdit.TabIndex = 3;
            this.panelEdit.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(117, 369);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 31);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(208, 369);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 31);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonChangeIngredients
            // 
            this.buttonChangeIngredients.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonChangeIngredients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonChangeIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeIngredients.Location = new System.Drawing.Point(28, 327);
            this.buttonChangeIngredients.Name = "buttonChangeIngredients";
            this.buttonChangeIngredients.Size = new System.Drawing.Size(117, 29);
            this.buttonChangeIngredients.TabIndex = 6;
            this.buttonChangeIngredients.Text = "Ингредиенты...";
            this.buttonChangeIngredients.UseVisualStyleBackColor = false;
            this.buttonChangeIngredients.Click += new System.EventHandler(this.buttonChangeIngredients_Click);
            // 
            // textBoxCooking
            // 
            this.textBoxCooking.Location = new System.Drawing.Point(28, 207);
            this.textBoxCooking.Multiline = true;
            this.textBoxCooking.Name = "textBoxCooking";
            this.textBoxCooking.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCooking.Size = new System.Drawing.Size(265, 114);
            this.textBoxCooking.TabIndex = 5;
            this.textBoxCooking.TextChanged += new System.EventHandler(this.textBoxCooking_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(28, 94);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(265, 71);
            this.textBoxDescription.TabIndex = 4;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 25);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelCooking
            // 
            this.labelCooking.AutoSize = true;
            this.labelCooking.Location = new System.Drawing.Point(28, 178);
            this.labelCooking.Name = "labelCooking";
            this.labelCooking.Size = new System.Drawing.Size(103, 17);
            this.labelCooking.TabIndex = 2;
            this.labelCooking.Text = "Приготовление:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(28, 64);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(69, 17);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Описание:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название:";
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderDescription
            // 
            this.errorProviderDescription.ContainerControl = this;
            // 
            // errorProviderCooking
            // 
            this.errorProviderCooking.ContainerControl = this;
            // 
            // errorProviderIngredients
            // 
            this.errorProviderIngredients.ContainerControl = this;
            // 
            // FormEditRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(699, 464);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.labelChooseRecipe);
            this.Controls.Add(this.buttonANewRecipe);
            this.Controls.Add(this.listboxMyRecipes);
            this.MaximizeBox = false;
            this.Name = "FormEditRecipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактировать рецепты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditRecipes_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditRecipes_FormClosed);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listboxMyRecipes;
        private Button buttonANewRecipe;
        private Label labelChooseRecipe;
        private Panel panelEdit;
        private Button buttonSave;
        private Button buttonChangeIngredients;
        private TextBox textBoxCooking;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Label labelCooking;
        private Label labelDescription;
        private Label labelName;
        private Button buttonCancel;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderDescription;
        private ErrorProvider errorProviderCooking;
        private ErrorProvider errorProviderIngredients;
    }
}