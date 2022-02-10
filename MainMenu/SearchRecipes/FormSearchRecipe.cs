using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Menu
{
    public partial class FormSearchRecipe : Form
    {
        List<Recipe> ProperRecipes; //коллекция рецептов, подходящих под условия поиска
        public FormSearchRecipe()
        {
            InitializeComponent();

            Ingredients.Refresh(checkedListBoxIngredients); //добавление списка ингредиентов
        }

        //возвращает коллецию отмеченных ингредиентов
        private List<object> ListOfSelectedIngredients()
        {
            //создание нового списка отмеченных ингредиентов
            var SelectedIngredients = new List<object>(15);

            //перебор всех отмеченных ингредиентов и добавление их в коллекцию
            foreach (var ingredient in checkedListBoxIngredients.CheckedItems)
                SelectedIngredients.Add(ingredient);
            return SelectedIngredients;
        }

        //при нажатии кнопки производится поиск подходящих рецептов
        private void buttonSearchRecipes_Click(object sender, EventArgs e)
        {
            //если до этого не было подходящих рецептов, то надпись об этом скрывается
            if (labelNoRecipes.Visible) 
                labelNoRecipes.Hide();

            listBoxRecipes.Items.Clear(); //очищение предыдущего списка подходящих рецептов

            //поиск подходящих рецептов и добавление их в коллекцию
            ProperRecipes = SearchRecipes(ListOfSelectedIngredients(), ref ProperRecipes);

            //вывод названий рецептов в список ListBox
            foreach (var recipe in ProperRecipes)
            {
                listBoxRecipes.Items.Add((object)recipe.Name);
            }

            //если подходящих рецептов нет, то появляется соответствующая надпись
            if (ProperRecipes.Count == 0) 
                labelNoRecipes.Show();

        }

        //поиск рецептов, удволетворяющих условиям поиска
        private ref List<Recipe> SearchRecipes(List<object> selectedIngredients, ref List<Recipe> ProperRecipes)
        {
            //новое значение для коллекции подходящих рецептов
            ProperRecipes = new List<Recipe>();

            //перебирается каждый ингредиент, отмеченный в списке
            foreach (var ingredient in selectedIngredients)
            {
                //поиск рецептов, в состав которых входит конкретный отмеченный ингредиент
                foreach (var recipe in Recipe.RecipeLibrary)
                {
                    if (IsForVegan(recipe) && IsContainsWithoutRepeat(recipe, ingredient))
                        ProperRecipes.Add(recipe); //если рецепт рецепт должен быть веганским
                    else if (!checkBoxVegan.Checked && IsContainsWithoutRepeat(recipe, ingredient))
                        ProperRecipes.Add(recipe); //если неважно каким будет рецепт
                }
            }
            return ref ProperRecipes; //возвращает новую коллекцию подходящих рецептов
        }

        //возвращает информацию о том, содержит ли рецепт искомый ингредиент
        //и не будет ли он пересекаться с уже добавленными в коллекцию рецептами
        private bool IsContainsWithoutRepeat(Recipe recipe, object ingredient)
        {
            return recipe.ingredients.IsContains(ingredient) && ProperRecipes.Contains(recipe) == false;
        }

        //возвращает информацию о том, должен ли рецепт быть веганским
        //и если да, то не содержит ли он ПЖП (продуктов животного происхождения)
        private bool IsForVegan(Recipe recipe)
        {
            return checkBoxVegan.Checked && recipe.ingredients.IsVegan();
        }

        //метод для поялвения описания при наведении курсора на рецепт
        int hoveredIndex = -1; //изначальный индекс отсутсвия рецепта

        #if DEBUG
        private void listBoxRecipes_MouseMove(object sender, MouseEventArgs e)
        {
            //новый индекс рецепта, где курсор остановился
            int newHoveredIndex = listBoxRecipes.IndexFromPoint(e.Location);
            if (hoveredIndex != newHoveredIndex) 
            {
                //если новое положение курсора указывает на другой рецепт, то присваивается новый индекс
                hoveredIndex = newHoveredIndex;
                if (hoveredIndex > -1)
                {
                    //в текст подсказки устанавливается описание того рецепта, на который наведён курсор
                    toolTipDescriptipn.SetToolTip(listBoxRecipes, ProperRecipes[hoveredIndex].Description);
                }
                //если курсор не указывает ни на один рецепт, то ничего не происходит
            }
        }
        # endif

        //меняет список отображаемых ингредиентов при изменении отметки в CheckBox
        private void checkBoxVegan_CheckedChanged(object sender, EventArgs e) 
        {
            Ingredients.VeganChanged(checkBoxVegan, checkedListBoxIngredients);
        }

        //открывает окно с информацией о рецепте при двойном щелчке по нему
        private void listBoxRecipes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //создание нового окна
            FormThisRecipe formThisRecipe = new FormThisRecipe();

            //поиск выбранного рецепта в общей библиотеке
            foreach (var recipe in Recipe.RecipeLibrary)
            {
                //передает в новое окно рецепт, ессли его название соответсвует выбранному
                if (recipe.Name == listBoxRecipes.SelectedItem.ToString()) 
                {
                    formThisRecipe.ShowThisRecipe(recipe);
                    break; //после нахождения цикл прерывается
                }
            }
            formThisRecipe.Show(this); //открытие диалогового окна
        }

        //окно закрывается
        private void FormSearchRecipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show(); //появляется родительское окно (главное меню)
        }
    }
}
