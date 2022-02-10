namespace My_Menu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Recipe.RecipeLibrary.AddRange(new Recipe[]
            {
                new Recipe("Жаренная картошка с грибочками")
                {
                    ingredients = new Ingredients(new object[] { Ingredients.Vegan[2], Ingredients.Vegan[13], Ingredients.Vegan[17], Ingredients.Vegan[18]}),
                    Description = "Она очень вкусно пахнет... На все случаи жизни!",
                    Cooking =
                    "1. Картофель и грибы почистить.\n" +
                    "2. Разогреть масло на сковородке.\n " +
                    "Нарезать грибы и жарить их 10 минут.\n " +
                    "3. Нарезать картошку кубиками и добавить к картофелю. Жарить 20 минут. \n" +
                    "4. Когда картошка будет почти готова, добавить к ней зелень и посолить. Жарить ещё 5 минут.\n\n" +
                    "Подавать горячей, по желанию со сметанкой!"

                },
                new Recipe("Слоёнки с яблоками")
                {
                    ingredients = new Ingredients(new object[] {Ingredients.ASF[9], Ingredients.Vegan[4], Ingredients.ASF[5]}),
                    Description = "Сладости на скорую руку",
                    Cooking = "1. Разморозить тесто.\n " +
                    "2. Раскатать тесто.\n " +
                    "3. Нарезать яблоки кубиками. \n" +
                    "4. Разделить тесто на прямоугольнички, выложить их на противень, застелённый пекарской бумагой. \n" +
                    "5. Вложить в прямоугольники яблочки на одну половинку, второй накрыть их и слепить тесто по краю. " +
                    "Сверху сделать несколько надрезов. Смазать яйцом или маслом верхушку, чтобы она была золотистой и сочной.\n" +
                    "6. Выпекать 15 минут на 180 градусах.\n\n " +
                    "7. Посыпать сахарной пудрой и подождать пока слойки остынут :)"
                },
                new Recipe("Хлеб с сыром")
                {
                    ingredients = new Ingredients(new object[] { Ingredients.ASF[0], Ingredients.ASF[1] }),
                    Description = "Вкусный перекус, а иногда полноценный завтрак",
                    Cooking = "На нарезанный хлеб положить кусочек сыра и в микроволновку на 2 минуты (пока сыр не расплавится) \n" +
                    "Вот и всё... Приятного аппетита!"
                }
            });

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainMenu());
        }
    }
}