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
    public partial class DialogIngredients : Form
    {
        Recipe recipe; //рецепт общий для всего окна
        bool UseClosingEvent = true;
        bool ErrorCought = false; //хранит информацию о том, возникали ли ошибки
        public DialogIngredients()
        {
            InitializeComponent();

            Ingredients.Refresh(checkedListBoxIngredients); //заполнение общими ингредиентами CheckedListBox
        }

        //впервые вызывается в родительском окне и отмечает ингредиенты, входящие в состав рецепта
        public void CheckIngredients(Recipe recipe) 
        {
            this.recipe = recipe; //инициализация общего для всего окна рецепта
            recipe.ingredients.Check(checkedListBoxIngredients); //отмечает ингредиенты из состава блюда
            labelRecipe.Text = recipe.Name; //название рецепта отображается над списком ингредиентов
        }

        //изменяет отображаемые ингредиенты в общем списке при переключении "веганского" и "стандартного" режимов
        private void checkBoxIsVegan_CheckedChanged(object sender, EventArgs e) 
        {
            Ingredients.VeganChanged(checkBoxIsVegan, checkedListBoxIngredients);
            CheckIngredients(recipe); //заново отмечает ингредиенты, входящие в состав блюда
        }

        //обеспечивает добавление нового ингредиента в список
        private void buttonAddIngredient_Click(object sender, EventArgs e) 
        {
            FormNewIngredient formNewIngredient = new FormNewIngredient();
            formNewIngredient.ShowDialog();
            Ingredients.Refresh(checkedListBoxIngredients); //обновление списка ингредиентов
            CheckIngredients(recipe); //заново отмечает ингредиенты, входящие в состав блюда

        }

        //сохранение изменений
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //присовение нового состава изменяемому блюду
            recipe.ingredients.Set(checkedListBoxIngredients, true);

            //если ни один ингредиент не был отмечен, то показывает предупреждение
            if (recipe.ingredients.IsCheckedNull(errorProviderIngredients, checkedListBoxIngredients))
                return; //окно остаётся открытым

            UseClosingEvent = false; //в случае отсутсвия ошибок вопроса о сохранении нет
            Notification.MessageSaved(); //сообщение об успешном сохранении
            this.Close(); //окно закрывается
        }

        //при отмене окно просто закрывается
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //окно нельзя закрыть, если ошибка не была решена
        private void DialogIngredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ErrorCought)
            {
                e.Cancel = true;
                ErrorCought = false;
            }
        }

        private void DialogIngredients_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(); //очищается мусор, т.к. диалоговые окна сами его не очищают
        }

    }
}
