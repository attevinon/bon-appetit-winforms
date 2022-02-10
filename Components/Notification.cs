using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Menu
{
    public static class Notification
    {
        //основной метод для проверки некорректного ввода в текстовую строку
        private static bool ErrorMaxLength(ErrorProvider errorProvider, TextBox textBox, string warning, int maxLength, bool IsNullError)
        {
            //если нужно (в параметры передали IsNullError = true), то проводится проверка на незаполненное поле
            if (IsNullError && String.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, MESSAGES.NO_NAME); //соответсвующее предупреждение при некорректном вводе
                return true; //если есть ошибка, то возвращается true
            }

            //проверка на соответсвие вместимости строки
            if (textBox.Text.Length >= maxLength) 
            {
                errorProvider.SetError(textBox, warning);
                return true; //если есть ошибка, то возвращается true
            }

            errorProvider.Clear(); //если ввод корректный, то все предупреждения убираются
            return false;
        }

        //адпатация метода к различным полям класса Recipe
        public static bool ErrorName(ErrorProvider errorProviderName, TextBox textBoxName)
        {
            //данный метод используется ещё в Ingredients
            return ErrorMaxLength(errorProviderName, textBoxName, MESSAGES.MAX_NAME_LENGTH, Recipe.NAME_LENGTH, true);
        }
        public static bool ErrorDescription(ErrorProvider errorProviderDescription, TextBox textBoxDescription)
        {
            return ErrorMaxLength(errorProviderDescription, textBoxDescription, MESSAGES.MAX_DISCRIPTION_LENGTH, Recipe.DESCRIPTION_LENGTH, false);
        }
        public static bool ErrorDirections(ErrorProvider errorProviderCooking, TextBox textBoxCooking)
        {
            return ErrorMaxLength(errorProviderCooking, textBoxCooking, MESSAGES.MAX_COOKING_LENGTH, Recipe.DIRECTIONS_LENGTH, false);
        }

        //показывает уведомление о некорректном вводе данных 
        public static void MessageError(ref bool isClosing, ref bool isError)
        {
            MessageBox.Show(MESSAGES.ERROR_STRING, MessageBoxName.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            isError = true; //окно не закроется из-за возникнувшей ошибки
            isClosing = false; //вопрос о сохранении не актуален, пока ошибка не будет исправлена
        }

        //перегрузка предыдущего метода
        public static void MessageError(ref bool isClosing)
        {
            MessageBox.Show(MESSAGES.ERROR_STRING, MessageBoxName.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            isClosing = false; //вопрос о сохранении не актуален, пока ошибка не будет исправлена
        }

        //сообщение об успешном сохранении
        public static void MessageSaved()
        {
            MessageBox.Show(MESSAGES.SAVED_CHANGES, MessageBoxName.MESSAGE, MessageBoxButtons.OK);
        }

        //регулирует работу события Closing
        public static void Closing(FormClosingEventArgs e, ref bool isClosing, ref bool isError)
        {
            if (isError) //если произошла ошибка, то не закрывает окно
            {
                e.Cancel = true;
                isError = false; //возвращает изначальное значение чтобы можно было нажать "отменить" или закрыть окно
                return;
            }

            //если вопрос о сохранении актуален, то выдаёт соотвествующий MessageBox
            if (isClosing)
            {
                DialogResult result = MessageBox.Show(MESSAGES.EXIT_RECIPE, MessageBoxName.WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = (result == DialogResult.No); //отменяет закрытие окна, создание рецпта продолжается без потерь
            }
            //закрывает окно если пользователь не хочет сохранять рецепт
        }

        //перегрузка предыдущего метода
        public static void Closing(FormClosingEventArgs e, ref bool isClosing)
        {
            if (isClosing)
            {
                DialogResult result = MessageBox.Show(MESSAGES.EXIT_RECIPE, MessageBoxName.WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = (result == DialogResult.No); //отменяет закрытие окна, создание рецпта продолжается без потерь
            }
            //закрывает окно если пользователь не хочет сохранять рецепт
        }

        //вопрос, возникающий при нажатии кнопки отмены
        public static bool IsCancel()
        {
            DialogResult result = MessageBox.Show(MESSAGES.EXIT_RECIPE, MessageBoxName.MESSAGE, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.No; //если пользователь решает не отменять изменения, то возвращает true
        }
        //вопрос о сохранении, возникающий при закрытии окна
        public static bool IsSave(Recipe recipe)
        {
            DialogResult result = MessageBox.Show(MESSAGES.EXIT_SAVEORNOT, recipe.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return result == DialogResult.Yes; //если пользователь решает сохранить изменения, то возвращает true
        }
    }
}
