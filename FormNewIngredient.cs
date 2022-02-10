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
    public partial class FormNewIngredient : Form
    {
        bool isError; //хранит информацию о способе использовании события Closing
        bool useClosingEvent = true; //хранит информацию о способе закрытия окна
        bool isVegan; //хранит информацию о том, веганский ли новый ингредиент
        public FormNewIngredient()
        {
            InitializeComponent();
        }

        //проверка на ошибку при введении названия с клавиатуры
        private void textBoxName_TextChanged(object sender, EventArgs e) 
        {
            isError = Notification.ErrorName(errorProviderName, textBoxName);
        }

        //если отмечено, то ингредиент подходит веганам
        private void checkBoxIsVegan_CheckedChanged(object sender, EventArgs e)
        {
            isVegan = checkBoxIsVegan.Checked;
        }

        //добавляет новый ингредиент если не возникло ошибок
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (isError)
            {
                Notification.MessageError(ref useClosingEvent);
                return;
            }

            //в зависимости от вида ингредиента добавляет его в соотвествующий список (коллекцию)
            if (isVegan) 
                Ingredients.Vegan.Add(textBoxName.Text);
            else
                Ingredients.ASF.Add(textBoxName.Text);

            //вопрос о сохранении не появляется и окно закрывается
            useClosingEvent = false;
            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //вопрос о сохранении ингредиента при закрытии окна
        private void FormNewIngredient_FormClosing(object sender, FormClosingEventArgs e)
        {
            Notification.Closing(e, ref useClosingEvent);
        }

        private void FormNewIngredient_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(); //сам очищает мусор, т.к. диалоговые окна не делают это автоматически
        }

    }
}
