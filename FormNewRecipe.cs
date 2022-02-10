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
    public partial class FormNewRecipe : Form
    {
        bool useClosingEvent = true; //хранит информацию о способе использовании события Closing
        bool errorCought = false; //хранит информацию о том, была ли ошибка, чтобы окно не закрылось после её возникновения

        //хранит информацию о том, пуст ли состав блюда
        bool noIngredients = true; //изначально состав блюда пуст

        //хранят информацию о том, есть ли неккоректно заполненные поля
        bool errorName = true; //изначально поле имени пустое
        bool errorDescription;
        bool errorCooking;

        Recipe recipe; //общий рецепт для всего окна
        public FormNewRecipe()
        {
            InitializeComponent();

            Ingredients.Refresh(checkedListBoxMealIngredients); //заполнение спика ингредиентов

            recipe = new Recipe(textBoxName.Text); //создание нового рецепта

        }

        //при некорректном вводе в соответсвующие текстовые поля выдаётся предупреждение
        //и присваивается значение в переменные, хранящие информацию о наличии ошибок
        private void textBoxName_TextChanged(object sender, EventArgs e) =>
            errorName = Notification.ErrorName(errorProviderName, textBoxName);
        private void textBoxDescription_TextChanged(object sender, EventArgs e) =>
            errorDescription = Notification.ErrorDescription(errorProviderDescription, textBoxDescription);
        private void textBoxCooking_TextChanged(object sender, EventArgs e) =>
            errorCooking = Notification.ErrorCooking(errorProviderCooking, textBoxCooking);

        //отмеченные ингредиенты присваиваются в состав блюда
        private void checkedListBoxMealIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            recipe.ingredients?.Set(checkedListBoxMealIngredients, false);
            //проверка на отсутсвие отмеченных ингредиентов,
            //чтобы присвоить значение для переменной NoIngredients и в случае true показать предупреждение
            noIngredients = recipe.ingredients.IsCheckedNull(errorProviderIngredients, checkedListBoxMealIngredients);

        }
        private void buttonAddIngredient_Click(object sender, EventArgs e) //добавление нового ингредиента в список
        {
            FormNewIngredient formNewIngredient = new FormNewIngredient();
            formNewIngredient.ShowDialog();
            Ingredients.Refresh(checkedListBoxMealIngredients); //обновление списка ингредиентов
        }

        //изменение списка отображаемых ингредиентов в зависимости от наличия отметки
        private void checkBoxVegan_CheckedChanged(object sender, EventArgs e)
        {
            Ingredients.VeganChanged(checkBoxVegan, checkedListBoxMealIngredients);
        }

        //сохраняет рецепт, если все поля заполненны корректно
        private void buttonDone_Click(object sender, EventArgs e) 
        {
            //проверка на наличие ошибки(ок)
            if (noIngredients || errorName || errorDescription || errorCooking)
            {
                Notification.MessageError(ref useClosingEvent, ref errorCought); //сообщение об ошибке
                return; //прерывание сохранения
            }

            //в случае отсутсвия ошибок присвоение значений соотвествующим свойствам рецепта
            recipe.NewInfo(textBoxName, textBoxDescription, textBoxCooking);

            Recipe.RecipeLibrary.Add(recipe); //добавление рецепта в общий список для последующего его отображения
            MessageBox.Show("Рецепт добавлен!", MessageBoxName.MESSAGE, MessageBoxButtons.OK);
            useClosingEvent = false;
            this.Close(); //окно закрывается без вопроса о сохранении
        }

        //отменяет создание рецепта, будет вопрос о сохранении
        private void buttonCancel_Click(object sender, EventArgs e) 
        {
            useClosingEvent = true; //вопрос о сохранении актуален
            this.Close();
        }

        private void FormNewRecipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Notification.Closing(e, ref useClosingEvent, ref errorCought);
            //закрывает окно если пользователь не хочет сохранять рецепт
        }
        private void FormNewRecipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(); //сам очищает мусор, т.к. диалоговые окна не делают это автоматически
        }
    }
}
