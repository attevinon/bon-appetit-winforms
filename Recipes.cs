﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Menu
{
    
    public class Recipe : Ingredients
    {
        public static List<Recipe> RecipeLibrary = new(); //коллекция всех рецептов

        public Ingredients ingredients;

        internal const int NAME_LENGTH = 50; //максимальное кол-во символов для названия
        private string name;
        public string Name //название блюда
        {
            get => name;
            set
            {
                if (value.Length < NAME_LENGTH) //проверка на соответсвие максимальному кол-ву символов
                    name = value;
                else
                    throw new Exception();
            }
        }

        //значение по умолчанию для описания
        public const string DEFAULT_DESCRIPTION = "Нет описания."; 
        internal const int DESCRIPTION_LENGTH = 150;
        private string? description;
        public string? Description //описание блюда
        {
            get => description;
            set
            {
                if (value?.Length < DESCRIPTION_LENGTH) //проверка на соответсвие максимальному кол-ву символов
                    description = value;
                else
                    throw new Exception();
            }
        }

        //значение по умолчанию для приготовления
        public const string DEFAULT_NO_COOKING = "Нет информации о приготовлении блюда.";
        internal const int COOKING_LENGTH = 30000;
        private string? cooking;
        public string? Cooking //приготовление блюда
        {
            get => cooking;
            set
            {
                if (value?.Length < COOKING_LENGTH) //проверка на соответсвие максимальному кол-ву символов
                    cooking = value;
                else
                    throw new Exception();
            }
        }

        public Recipe(string? name)
        {
            Name = name; 
            ingredients = new Ingredients(); //создание нового объекта ингредиентов

            //если в инициализаторе не указаны значения для свойств Description и Cooking,
            //то им присваивается значение по умолчанию
            Description = DEFAULT_DESCRIPTION; 
            Cooking = DEFAULT_NO_COOKING;
        }

        //присоение свойствам значений, введённых с клавиатуры
        public void NewInfo(TextBox newName,TextBox newDescription, TextBox newCooking) 
        {
            Name = newName.Text;
            Description = newDescription.Text ?? DEFAULT_DESCRIPTION;
            Cooking = newCooking.Text ?? DEFAULT_NO_COOKING;
        }

        //обновление списка рецептов в некотором ListBox
        public static void Refresh(ListBox listBox, bool isNeedToClear = false) 
        {
            listBox.Items.Clear(); //очищение предыдущего списка объектов
            foreach (var recipe in RecipeLibrary)
                listBox.Items.Add(recipe.Name);
        }
    }
}
