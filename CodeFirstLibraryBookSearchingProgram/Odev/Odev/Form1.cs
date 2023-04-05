using Library.BLL.Controllers;
using Library.DAL.Entity;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgwList.DataSource = LibraryController.GetBooks();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryController.UpdateData(Convert.ToInt32(tbID.Text), tbBookName.Text, tbAuthorName.Text);
            dgwList.DataSource = LibraryController.GetBooks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LibraryController.AddBook(tbBookName.Text, tbAuthorName.Text);
            dgwList.DataSource = LibraryController.GetBooks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LibraryController.DeleteBook(Convert.ToInt32(tbID.Text));
            dgwList.DataSource = LibraryController.GetBooks();
        }
    }
}