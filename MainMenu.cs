namespace My_Menu
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonGetRecipe_Click(object sender, EventArgs e)
        {
            this.Hide(); //прячет это окно!!!!!!!!!!!!
            FormSearchRecipe formSearchRecipe = new FormSearchRecipe();
            formSearchRecipe.Show(this); //передает это окно как родительское чтобы потом к нему можно было обращаться через owner
        }

        private void buttonEditRecipes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditRecipes formEditRecipes = new FormEditRecipes();
            formEditRecipes.Show(this);
        }
    }
}