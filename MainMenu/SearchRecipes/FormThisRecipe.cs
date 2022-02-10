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
    public partial class FormThisRecipe : Form
    {
        public FormThisRecipe()
        {
            InitializeComponent();
        }

        //при передаче через родительское окно рецепта, текстовым полям присваиваются значения его свойств
        public void ShowThisRecipe(Recipe recipe) 
        {
            labelName.Text = recipe.Name;
            textDescription.Text = recipe?.Description;
            textDirections.Text = recipe?.Directions;

            //печать ингредиентов рецепта
            recipe.ingredients.Print(textIngredients);

            // отображает соответсвующую надпись, если рецепт веганский
            labelIsVegan.Visible = recipe.ingredients.IsVegan();
        }

        private void FormThisRecipe_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(); //сам очищает мусор, т.к. диалоговые окна не делают это автоматически
        }
    }
}
