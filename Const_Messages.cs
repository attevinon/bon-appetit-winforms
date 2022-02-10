using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Menu
{
    public static class MessageBoxName //названия для MessageBox 
    {
        public const string ERROR = "Ошибка";
        public const string WARNING = "Предупреждение";
        public const string MESSAGE = "Сообщение";
    }
    public static class MESSAGES //предупреждения, отображаются в MessageBox и ErrorProvider
    {
        public const string ERROR_STRING = "Неккоректный ввод данных!";

        public const string NO_INGREDIENTS = "Выберите как минимум 1 ингредиент!";
        public const string NO_NAME = "Это поле обязательно к заполнению.";

        static public readonly string MAX_DISCRIPTION_LENGTH = $"Максимальная длинна описания {Recipe.DESCRIPTION_LENGTH} символов";
        static public readonly string MAX_COOKING_LENGTH = $"Максимальная длинна описания приготовления {Recipe.COOKING_LENGTH} символов";
        static public readonly string MAX_NAME_LENGTH = $"Максимальная длинна названия {Recipe.NAME_LENGTH} символов";

        public const string EXIT_RECIPE = "Вы уверены, что хотите уйти?\nРецепт НЕ будет сохранён!";
        public const string EXIT_EDIT = "Вы уверены, что хотите уйти?\nИзменения НЕ будут сохранены!";
        public const string EXIT_SAVEORNOT = "Сохранить изменения?";

        public const string SAVED_CHANGES = "Изменения сохранены";
    }
}
