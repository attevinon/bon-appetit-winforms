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
    public partial class FormEditRecipes : Form
    {
        Recipe recipe; //объект рецепта, общий для всего окна
        object[] starterIngredients; //массив начального состава блюда

        //хранит информацию о способе использовании события Closing
        //изначально false т.к. никакой рецепт не выбран и вопрос о сохранении не актуален
        bool useClosingEvent = false; 

        //хранит информацию о том, пуст ли состав блюда
        bool noIngredients;

        //хранят информацию о том, есть ли неккоректно заполненные поля
        bool errorName;
        bool errorDescription;
        bool errorDirections;
        public FormEditRecipes()
        {
            InitializeComponent();

            //добавляет все существующие рецепты в ListBox
            Recipe.Refresh(listboxMyRecipes);
        }
        
        //кнопка добавления нового рецепта
        private void buttonANewRecipe_Click(object sender, EventArgs e)
        {
            FormNewRecipe formNewRecipe = new FormNewRecipe();
            formNewRecipe.ShowDialog(this);
            //после добавления список рецептов очищается и обновляется
            Recipe.Refresh(listboxMyRecipes); 
        }

        //обеспечивает отображение информации на panelEdit
        //о конкретном рецепте, выбранном пользователем в listBoxMyRecipes
        private void listboxMyRecipes_MouseClick(object sender, MouseEventArgs e)
        {
            //если пользователь ничего не выбрал, то panelEdit не изменяется
            if (listboxMyRecipes.SelectedItem == null)
                return;

            //если при переключении на другой рецепт панель видна и свойства рецепта изменены,
            //то поступает вопрос о сохранении
            if (panelEdit.Visible 
                &&(textBoxName?.Text != recipe?.Name
                || textBoxDescription?.Text != recipe?.Description
                || textBoxDirections?.Text != recipe?.Directions)) 
            { 
                if (Notification.IsSave(recipe)) //IsSave возвращает результат вопроса о сохранении
                    SaveChanges(); //если ответ положительный, то рецепт сохраняется
            }

            RecipeSearch(ref recipe); //поиск соответсвующего рецепта

            panelEdit.Show(); //панель изменений становится видимой

            //текстовым полям присваиваются соответсвующие значения свойств рецепта
            textBoxName.Text = recipe.Name;
            textBoxDescription.Text = recipe?.Description;
            textBoxDirections.Text = recipe?.Directions;

            //начальный состав рецепта копируется в массив объектов
            starterIngredients = recipe.ingredients.Copy();
            useClosingEvent = true;
        }

        //осуществляет поиск рецептов
        private void RecipeSearch(ref Recipe searchedRecipe)
        {
            foreach (var recipe in Recipe.RecipeLibrary)
            {
                //присваивает значение для общей переменной в случае нахождения соответствия
                //между названием рецепта и выделенным объектом
                if (recipe.Name == listboxMyRecipes?.SelectedItem?.ToString())
                {
                    searchedRecipe = recipe; 
                    break; //прерывает цикл
                }
            }
        }

        //при нажатии кнопки изменения ингредиентов создаётся окно, где уже отмечены ингредиенты,
        //входящие в состав редактируемого продукта
        private void buttonChangeIngredients_Click(object sender, EventArgs e)
        {
            DialogIngredients dialogIngredients = new DialogIngredients();
            dialogIngredients.CheckIngredients(recipe);
            dialogIngredients.ShowDialog(this);
            //после закрытия окна производится проверка на отсутсвие отмеченных ингредиентов,
            //чтобы присвоить значение для переменной NoIngredients и в случае true показать предупреждение
            noIngredients = recipe.ingredients.IsCheckedNull(errorProviderIngredients, buttonChangeIngredients);
        }

        //при некорректном вводе в соответсвующие текстовые поля выдаётся предупреждение
        //и присваивается значение в переменные, хранящие информацию о наличии ошибок
        private void textBoxName_TextChanged(object sender, EventArgs e) =>
            errorName = Notification.ErrorName(errorProviderName, textBoxName);
        private void textBoxDescription_TextChanged(object sender, EventArgs e) =>
            errorDescription = Notification.ErrorDescription(errorProviderDescription, textBoxDescription);
        private void textBoxDirections_TextChanged(object sender, EventArgs e) =>
            errorDirections = Notification.ErrorDirections(errorProviderCooking, textBoxDirections);

        //нажатие кнопки "Сохранить" сохраняет внесённые изменения
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        //нажатие кнопки "Отменить" отменяет внесённые изменения,
        //предварительно задавая предупреждающий вопрос
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //если пользователь изменил своё мнение, то действие кнопки отменяется
            if (Notification.IsCancel())
                return;

            //в случае выбора отмены, состав блюда становится прежним,
            //а панель для реадктирования скрывается
            recipe.ingredients.Replace(starterIngredients);
            panelEdit.Hide();
            useClosingEvent = false;
        }

        //сохраняет изменения, если они не вызывают исключений
        private void SaveChanges()
        {
            //проверка на наличие ошибки(ок)
            if (noIngredients || errorName ||  errorDescription || errorDirections)
            {
                Notification.MessageError(ref useClosingEvent); //сообщение об ошибке
                return; //прерывание метода
            }

            //в случае отсутсвия ошибок присвоение значений соотвествующим свойствам рецепта
            recipe.NewInfo(textBoxName, textBoxDescription, textBoxDirections);

            Notification.MessageSaved(); //сообщение об успешном сохранении
            Recipe.Refresh(listboxMyRecipes); //обновление списка рецептов
            useClosingEvent = false; //вопрос о сохранении при закрытии окна не появится 
        }

        //закрывает окно, если
        private void FormEditRecipes_FormClosing(object sender, FormClosingEventArgs e)
        {
            //вопрос о сохранении изменений
            Notification.Closing(e, ref useClosingEvent);
        }

        //в случае закрытия окна показывает родительское окно (главное меню)
        private void FormEditRecipes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
