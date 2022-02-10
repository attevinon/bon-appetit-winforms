using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Menu
{
    public class Ingredients
    {
        public Ingredients() //конструктор без параметров
        {

        }

        //конструктор, принимающий массив объектов (ингредиентов)
        public Ingredients(object[]? ingredients) 
        {
            if (ingredients != null)
            сompound.AddRange(ingredients);
        }

        internal static List<object> ASF = new List<object>() //общие ингредиенты содержащие ПЖП (Animal source foods)
        {
            "Хлеб",
            "Сыр",
            "Масло сливочное",
            "Молоко",
            "Йогурт",
            "Яйца",
            "Рыба (любая)",
            "Креветки",
            "Сосиски",
            "Слоёное тесто",
            "Мороженое",
            "Сыр творожный",
            "Майонез"
        };

        internal static List<object> Vegan = new List<object>() //общие веганские ингредиенты
        {
            "Помидоры",
            "Капуста",
            "Грибы (любые)",
            "Горох",
            "Яблоки",
            "Сельдирей",
            "Рис",
            "Брокколи",
            "Мука",
            "Сода",
            "Шампиньоны",
            "Морковь",
            "Лук",
            "Картофель",
            "Фасоль",
            "Соль",
            "Кукуруза",
            "Масло подсолнечное",
            "Зелень",
            "Орехи"
        };

        private List<object> compound = new List<object>(20); //ингредиенты (состав) для некоторого блюда
        protected List<object> сompound { get => compound; private set => compound = value; }

        //обновляет общий список ингредиентов в некотором CheckedListBox
        public static void Refresh(CheckedListBox checkedListBox) 
        {
            checkedListBox.Items.Clear();
            checkedListBox.Items.AddRange(ASF.ToArray());
            checkedListBox.Items.AddRange(Vegan.ToArray());
            checkedListBox.Sorted = true;
        }

        //обновляет общий список ингредиентов, если меняется наличие отметки в CheckBox
        public static void VeganChanged(CheckBox checkBox, CheckedListBox checkedListBox)
        {
            if (checkBox.Checked)
            {
                foreach (var item in ASF)
                    checkedListBox.Items.Remove(item);
            }
            else
                checkedListBox.Items.AddRange(ASF.ToArray());
        }

        //копирует список ингредиентов (состав) блюда в массив объектов
        public object[] Copy()
        {
            object[] ingredients = new object[сompound.Count];
            сompound.CopyTo(ingredients);
            return ingredients;
        }

        //заменяет список ингредиентов (состав) блюда на массив объектов
        public void Replace(object[] ingredients)
        {
            сompound.Clear();
            сompound.AddRange(ingredients);
        }

        //печатает список ингредиентов (состав) блюда в строку, через запятую, с точкой на конце
        public void Print(Label textIngredients)
        {
            textIngredients.ResetText(); //удаление исходного текста (стандартного)
            foreach (var item in сompound) //перечисление ингредиентов и добавление их в список через запятую
            {
                textIngredients.Text += item?.ToString();

                if (сompound.IndexOf(item) == сompound.Count - 1)
                    textIngredients.Text += "."; //после последнего ставится точка
                else
                    textIngredients.Text += ", ";
            }
        }

        //проверяет, веганский ли состав у блюда
        public bool IsVegan()
        {
            foreach (var ingredient in сompound)
            {
                if (ASF.Contains(ingredient))
                    return false;
            }
            return true; //если веганское, то возвращает true
        }

        //присаивает составу блюда новый список ингредиентов,
        //который выбирается из отмеченных ингредиентов в некотором CheckedListBox
        public void Set (CheckedListBox checkedListBox, bool IsNeedToClear)
        {
            if (IsNeedToClear) //нужно ли очищать старый состав, если он был
                сompound.Clear(); //если передается true, то очищает

            foreach (var item in checkedListBox.CheckedItems)
                сompound.Add(item); 
        }

        //проверяет, пуст ли список ингредиентов (состав) блюда
        public bool IsCheckedNull(ErrorProvider errorProvider, Control control)
        {
            if (сompound.Count == 0) 
            {
                //выдает предупреждение, если список пуст
                errorProvider.SetError(control, MESSAGES.NO_INGREDIENTS);
                return true;
            }
            errorProvider.Clear(); //если в составе есть ингредиент(ы), то убирает предупреждение
            return false;
        }

        //проверяет, входит ли некоторый ингредиент в состав некоторого блюда
        public bool IsContains(object ingredient) => сompound.Contains(ingredient); //если есть, то возвращает true

        //отмечает в CheckedListBox все ингредиенты, входящие в состав некоторого блюда
        public void Check(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++) //в CheckedListBox содержится общий список ингредиентов
            {
                //если объект по данному индексу (из общего списка) входит в состав продукта,
                //то он определяется в категорию отмеченных элементов
                if (сompound.Contains(checkedListBox.Items[i])) 
                    checkedListBox.SetItemChecked(i, true); 
            }
        }

    }
}
