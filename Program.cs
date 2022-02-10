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
                new Recipe("�������� �������� � ����������")
                {
                    ingredients = new Ingredients(new object[]
                    { Ingredients.Vegan[2], Ingredients.Vegan[13], Ingredients.Vegan[17], Ingredients.Vegan[18], Ingredients.Vegan[12]}),
                    Description = "��� ����� ������ ������... �� ��� ������ �����!",
                    Directions =
                    "1. ��������� � ����� ���������." + Environment.NewLine +
                    "2. ��������� ����� �� ����������. �������� ��� � �����." + Environment.NewLine +
                    "3. �������� ��� �� ���������� �������. �������� � ���� ����� � ������ �� ������ 10 �����." + Environment.NewLine +
                    "4. �������� ��������� �������� � �������� � ����������. ������ 20 �����" + Environment.NewLine +
                    "5. ����� � �������� �������� ���������� �������, �������� � ��� ������ � ��������. ������ ��� 5 �����." + Environment.NewLine +
                    Environment.NewLine + "�������� �������, �� ������� �� ���������!"

                },
                new Recipe("������ � ��������")
                {
                    ingredients = new Ingredients(new object[]
                    {Ingredients.ASF[9], Ingredients.Vegan[4], Ingredients.ASF[5]}),
                    Description = "�������� �� ������ ����",
                    Directions = "1. ����������� �����." + Environment.NewLine +
                    "2. ��������� �����." + Environment.NewLine +
                    "3. �������� ������ ��������." + Environment.NewLine +
                    "4. ��������� ����� �� ��������������, �������� �� �� ���������, ���������� ��������� �������." + Environment.NewLine +
                    "5. ������� ������� �� ���� �������� ��������������, ������ ���������� ������� �� � ������� ����� �� ����." +
                    "������ ������� ��������� ��������." + Environment.NewLine +
                    "6. ������� ����� ��� ������ ��������, ����� ��� ���� ���������� � ������." + Environment.NewLine +
                    "7. �������� 15 ����� �� 180 ��������." + Environment.NewLine + Environment.NewLine +
                    "8. �������� �������� ������ � ��������� ���� ������ ������� :)"
                },
            });

            Recipe.RecipeLibrary.Add(new Recipe("���� � �����")
            {
                ingredients = new Ingredients(new object[]
                { Ingredients.ASF[0], Ingredients.ASF[1] }),
                Description = "������� �������, � ������ ����������� �������",
                Directions = "�� ���������� ���� �������� ������� ���� � ��������� � ������������� �� 2 ������ (���� ��� �� �����������)." + Environment.NewLine +
                Environment.NewLine + "��� � ��... ��������� ��������!"
            });
            Recipe.RecipeLibrary.Add(new Recipe("��� � �������")
            {
                ingredients = new Ingredients(new object[]
                {Ingredients.Vegan[6], Ingredients.Vegan[11], Ingredients.Vegan[12], Ingredients.Vegan[15], Ingredients.Vegan[16], Ingredients.Vegan[17]}),
                Description = "�������, ����� ����� � ����",
                Directions = "1. ������� ��� � ���������� ���� � ��������, �������� � �� ������� �������." + Environment.NewLine +
                "2. ����� ���� �������, �������� � �� �������� ���." + Environment.NewLine +
                "3. �������� (��������) �������, ���������� ����� � ���. � ��� ����������, � ����� ������, � ���, ��� ��� �������� :)" + Environment.NewLine +
                "4. ��������� ����� �� ����������. ������ �������� ���� ���, � ����� �������� ������� � �����." + Environment.NewLine +
                "5. ����� ��� ��������, �������� ��� � ������ �� ����������. ����� ��� �������� � ��� ���������������� ���������, � ����� �������� �����." + Environment.NewLine +
                "6. ����� ����, ��� �� ���������� � ��� ��� �������� ����������� �������� �� ���������� �� ���������," +
                "�����, ���� ����, ������� ������ �� ������ ������. ���� �� �������� �������� ������, �� ������ ����� �����!" + Environment.NewLine + Environment.NewLine +
                "������ ����� ����� ����� ����������� � ����������� �� ����� ������������!" +
                "��������, �� ������ �������� ��������, �����, �������, ������ � ��, ��� ���������." + Environment.NewLine +
                " ��������� �������� :)"
            });

            Recipe.RecipeLibrary.Add(new Recipe("�������")
            {
                ingredients = new Ingredients(new object[]
                {Ingredients.Vegan[8], Ingredients.Vegan[13], Ingredients.Vegan[17], Ingredients.ASF[5]}),
                Description = "��, ��� � ��������� ��������� ������ ������",
                Directions = "1. ��������� ��������� � �������� ��� �� ������� ����." + Environment.NewLine +
                "2. ������ � ����� ���� �� �������� ���������." + Environment.NewLine +
                "3. � ��������� �������� ���� � ����, ���� �� �����. ���������� �� ���������� �������� ���������." + Environment.NewLine +
                "4. ��������� ����� �� ����������." + Environment.NewLine +
                "5. ������������ ������ �������� �� ����� � �������� �� ���������." + Environment.NewLine +
                "6. ������ ������� �� ���������� �������." + Environment.NewLine + Environment.NewLine +
                "�������� �������� (���� �������� ��� ���� �����!), ����� �� ��������� � �������� ������ �������."
            });

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainMenu());
        }
    }
}