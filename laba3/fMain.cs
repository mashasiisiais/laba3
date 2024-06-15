using System;
using System.Windows.Forms;

namespace laba3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void btnAddAbonent_Click(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            fAbonent ft = new fAbonent(abonent);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbAbonentsInfo.Text += string.Format(
                    "{0}, {1}. Вартість: {2} грн. Акції: {3}. Ціна: {4} грн. Борг: {5}. Контракт: {6}. Річний дохід з абонента: {7} грн",
                    abonent.Name, abonent.Number, abonent.Service, abonent.Extra, abonent.CostT,
                    abonent.Debt ? "Є" : "Немає", abonent.Contract ? "Підписано" : "Не підписано",
                    abonent.GetYearIncome());
            }

        }
        private void btnAddClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
 "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

       
    }
}
