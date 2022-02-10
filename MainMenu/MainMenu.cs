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
            this.Hide(); //��� ���� ����������
            FormSearchRecipe formSearchRecipe = new FormSearchRecipe();
            //��� ���� ��������� ��� ������������, ����� ����� � ���� ����� ���� ���������� ����� owner
            formSearchRecipe.Show(this); 
        }

        private void buttonEditRecipes_Click(object sender, EventArgs e)
        {
            this.Hide(); //��� ���� ����������
            FormEditRecipes formEditRecipes = new FormEditRecipes();
            //��� ���� ��������� ��� ������������, ����� ����� � ���� ����� ���� ���������� ����� owner
            formEditRecipes.Show(this);
        }
    }
}