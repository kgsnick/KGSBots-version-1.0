using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgs_bots
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        // Обработчик загрузки формы.
        public void Form4_Load(object sender, EventArgs e)
        {

            // Заносим список поддерживаемых языков.
            comboBox1.DataSource = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),
                System.Globalization.CultureInfo.GetCultureInfo("en-US")
            };

            // Каждый элемент списка comboBox1 будет являться экземпляром класса CultureInfo.

            comboBox1.DisplayMember = "NativeName"; // <= System.Globalization.CultureInfo.GetCultureInfo("ru-RU").NativeName
            comboBox1.ValueMember = "Name"; // <= System.Globalization.CultureInfo.GetCultureInfo("ru-RU").Name

            // Если в настройках есть язык, выбираем его в списке.
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                comboBox1.SelectedValue = Properties.Settings.Default.Language;
            }



        }

        // Обработчик закрытия формы.
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Сохраняем выбранный язык.
            Properties.Settings.Default.Language = comboBox1.SelectedValue.ToString();          
            Properties.Settings.Default.Save();
        }
    }
}
