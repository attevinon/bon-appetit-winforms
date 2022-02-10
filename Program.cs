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
                    ingredients = new Ingredients(new object[] { Ingredients.Vegan[2], Ingredients.Vegan[13], Ingredients.Vegan[17], Ingredients.Vegan[18]}),
                    Description = "��� ����� ������ ������... �� ��� ������ �����!",
                    Cooking =
                    "1. ��������� � ����� ���������.\n" +
                    "2. ��������� ����� �� ����������.\n " +
                    "�������� ����� � ������ �� 10 �����.\n " +
                    "3. �������� �������� �������� � �������� � ���������. ������ 20 �����. \n" +
                    "4. ����� �������� ����� ����� ������, �������� � ��� ������ � ��������. ������ ��� 5 �����.\n\n" +
                    "�������� �������, �� ������� �� ���������!"

                },
                new Recipe("������ � ��������")
                {
                    ingredients = new Ingredients(new object[] {Ingredients.ASF[9], Ingredients.Vegan[4], Ingredients.ASF[5]}),
                    Description = "�������� �� ������ ����",
                    Cooking = "1. ����������� �����.\n " +
                    "2. ��������� �����.\n " +
                    "3. �������� ������ ��������. \n" +
                    "4. ��������� ����� �� ���������������, �������� �� �� ���������, ���������� ��������� �������. \n" +
                    "5. ������� � �������������� ������� �� ���� ���������, ������ ������� �� � ������� ����� �� ����. " +
                    "������ ������� ��������� ��������. ������� ����� ��� ������ ��������, ����� ��� ���� ���������� � ������.\n" +
                    "6. �������� 15 ����� �� 180 ��������.\n\n " +
                    "7. �������� �������� ������ � ��������� ���� ������ ������� :)"
                },
                new Recipe("���� � �����")
                {
                    ingredients = new Ingredients(new object[] { Ingredients.ASF[0], Ingredients.ASF[1] }),
                    Description = "������� �������, � ������ ����������� �������",
                    Cooking = "�� ���������� ���� �������� ������� ���� � � ������������� �� 2 ������ (���� ��� �� �����������) \n" +
                    "��� � ��... ��������� ��������!"
                }
            });

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainMenu());
        }
    }
}