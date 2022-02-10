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
                    ingredients = new Ingredients(new object[]
                    { Ingredients.Vegan[2], Ingredients.Vegan[13], Ingredients.Vegan[17], Ingredients.Vegan[18], Ingredients.Vegan[12]}),
                    Description = "Она очень вкусно пахнет... На все случаи жизни!",
                    Directions =
                    "1. Картофель и грибы почистить." + Environment.NewLine +
                    "2. Разогреть масло на сковородке. Нарезать лук и грибы." + Environment.NewLine +
                    "3. Пожарить лук до золотистой хорочки. Добавить к луку грибы и жарить их вместе 10 минут." + Environment.NewLine +
                    "4. Нарезать картофель кубиками и добавить в сковородку. Жарить 20 минут" + Environment.NewLine +
                    "5. Когда у картошки появится золотистая корочка, добавить к ней зелень и посолить. Жарить ещё 5 минут." + Environment.NewLine +
                    Environment.NewLine + "Подавать горячей, по желанию со сметанкой!"

                },
                new Recipe("Слойки с яблоками")
                {
                    ingredients = new Ingredients(new object[]
                    {Ingredients.ASF[9], Ingredients.Vegan[4], Ingredients.ASF[5]}),
                    Description = "Сладости на скорую руку",
                    Directions = "1. Разморозить тесто." + Environment.NewLine +
                    "2. Раскатать тесто." + Environment.NewLine +
                    "3. Нарезать яблоки кубиками." + Environment.NewLine +
                    "4. Разделить тесто на прямоугольники, выложить их на противень, застелённый пекарской бумагой." + Environment.NewLine +
                    "5. Вложить яблочки на одну половину прямоугольника, второй половинкой накрыть их и слепить тесто по краю." +
                    "Сверху сделать несколько надрезов." + Environment.NewLine +
                    "6. Смазать яйцом или маслом верхушку, чтобы она была золотистой и сочной." + Environment.NewLine +
                    "7. Выпекать 15 минут на 180 градусах." + Environment.NewLine + Environment.NewLine +
                    "8. Посыпать сахарной пудрой и подождать пока слойки остынут :)"
                },
            });

            Recipe.RecipeLibrary.Add(new Recipe("Хлеб с сыром")
            {
                ingredients = new Ingredients(new object[]
                { Ingredients.ASF[0], Ingredients.ASF[1] }),
                Description = "Вкусный перекус, а иногда полноценный завтрак",
                Directions = "На нарезанный хлеб положить кусочек сыра и отправить в микроволновку на 2 минуты (пока сыр не расплавится)." + Environment.NewLine +
                Environment.NewLine + "Вот и всё... Приятного аппетита!"
            });
            Recipe.RecipeLibrary.Add(new Recipe("Рис с овощами")
            {
                ingredients = new Ingredients(new object[]
                {Ingredients.Vegan[6], Ingredients.Vegan[11], Ingredients.Vegan[12], Ingredients.Vegan[15], Ingredients.Vegan[16], Ingredients.Vegan[17]}),
                Description = "Кажется, такое любят в Азии",
                Directions = "1. Промыть рис и вскипятить воду в кастрюле, добавить в неё немного куркумы." + Environment.NewLine +
                "2. Когда вода закипит, насыпать в неё промытый рис." + Environment.NewLine +
                "3. Нарезать (натереть) морковь, болгарский перец и лук. В том количестве, в каком любите, и так, как вам нравится :)" + Environment.NewLine +
                "4. Разогреть масло на сковородке. Первым закинуть туда лук, а после добавить морковь и перец." + Environment.NewLine +
                "5. Когда рис сварится, добавить его к овощам на сковородку. Можно уже закинуть к ним консервированную кукурузку, а можно добавить потом." + Environment.NewLine +
                "6. После того, как всё обжарилось и рис уже начинает покрываться зажаркой от пребывания на сковороде," +
                "можно, если есть, немного полить всё соевым соусом. Если не добавили кукурузу раньше, то сейчас самое время!" + Environment.NewLine + Environment.NewLine +
                "Состав этого блюда может варьировать в зависимости от ваших предпочтений!" +
                "Например, вы можете добавить брокколи, грибы, горошек, фасоль и всё, что захочется." + Environment.NewLine +
                " Приятного аппетита :)"
            });

            Recipe.RecipeLibrary.Add(new Recipe("Драники")
            {
                ingredients = new Ingredients(new object[]
                {Ingredients.Vegan[8], Ingredients.Vegan[13], Ingredients.Vegan[17], Ingredients.ASF[5]}),
                Description = "То, что у белорусов находится вместо сердца",
                Directions = "1. Почистить картофель и натереть его на крупной тёрке." + Environment.NewLine +
                "2. Отжать и слить воду из натёртого картофеля." + Environment.NewLine +
                "3. К картофелю добавить муку и яйца, соль по вкусу. Перемешать до достижения желаемой клейкости." + Environment.NewLine +
                "4. Разогреть масло на сковородке." + Environment.NewLine +
                "5. Сформировать руками лепёшечки из теста и выложить на сковороду." + Environment.NewLine +
                "6. Жарить драники до золотистой корочки." + Environment.NewLine + Environment.NewLine +
                "Подавать горячими (хотя холодные они тоже клёвые!), можно со сметанкой и посыпать свежей зеленью."
            });

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainMenu());
        }
    }
}