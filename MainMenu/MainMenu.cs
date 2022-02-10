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
            this.Hide(); //это окно скрывается
            FormSearchRecipe formSearchRecipe = new FormSearchRecipe();
            //это окно передаётся как родительское, чтобы потом к нему можно было обращаться через owner
            formSearchRecipe.Show(this); 
        }

        private void buttonEditRecipes_Click(object sender, EventArgs e)
        {
            this.Hide(); //это окно скрывается
            FormEditRecipes formEditRecipes = new FormEditRecipes();
            //это окно передаётся как родительское, чтобы потом к нему можно было обращаться через owner
            formEditRecipes.Show(this);
        }
    }
}