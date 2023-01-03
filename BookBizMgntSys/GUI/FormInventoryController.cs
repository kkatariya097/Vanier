using BookBizMgntSys.Business;
using BookBizMgntSys.Data_IO;
using BookBizMgntSys.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBizMgntSys.GUI
{
    public partial class FormInventoryController : Form
    {
        //lists 
        List<Book> bookList = new List<Book>();
        List<Book> bookListTemp = new List<Book>();

        public FormInventoryController()
        {
            InitializeComponent();
            textBoxISBN.Focus();
           

        }

        public void ClearAll()
        {
            textBoxISBN.Clear();
            textBoxTitle.Clear();  
            textBoxUnitPrice.Clear();
            textBoxYear.Clear();
            textBoxQOH.Clear(); 
            textBoxSearchInfo.Clear();
            textBoxOtherPub.Clear();
        }


        //search button 
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int option = comboBoxSearchBy.SelectedIndex;

            switch (option)
            {
                case -1:
                    MessageBox.Show("Select a option to search from Combo Box.");
                    break;

                //search by Book ISBN
                case 0:
                    {
                        Book book = InventoryControllerIO.SearchISBN(Convert.ToInt32(textBoxSearchInfo.Text));
                        if (book != null)
                        {
                            textBoxISBN.Text = book.ISBN.ToString();
                            textBoxTitle.Text = book.Title;
                            textBoxUnitPrice.Text = book.UnitPrice.ToString();
                            textBoxYear.Text = book.YearPublished.ToString();
                            textBoxQOH.Text = book.QuantityOnHand.ToString();
                            textBoxOtherPub.Text = book.PublisherName;
                            textBoxAuthor.Text = book.AuthorName;
                        }
                        else
                        {
                            MessageBox.Show("Book Not Found. Enter Valid ISBN or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }

                    //search by Book Title
                case 1:
                    {
                        Book book = InventoryControllerIO.SearchBookTitle(textBoxSearchInfo.Text);
                        if (book != null)
                        {
                            textBoxISBN.Text = book.ISBN.ToString();
                            textBoxTitle.Text = book.Title;
                            textBoxUnitPrice.Text = book.UnitPrice.ToString();
                            textBoxYear.Text = book.YearPublished.ToString();
                            textBoxQOH.Text = book.QuantityOnHand.ToString();
                            textBoxOtherPub.Text = book.PublisherName;
                            textBoxAuthor.Text = book.AuthorName;
                        }
                        else
                        {
                            MessageBox.Show("Book Not Found. Enter Valid Book Title or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }

                    //Search by Book Publisher Name
                case 2:
                    {
                        Book book = InventoryControllerIO.SearchBookPublisher(textBoxSearchInfo.Text);
                        if (book != null)
                        {
                            textBoxISBN.Text = book.ISBN.ToString();
                            textBoxTitle.Text = book.Title;
                            textBoxUnitPrice.Text = book.UnitPrice.ToString();
                            textBoxYear.Text = book.YearPublished.ToString();
                            textBoxQOH.Text = book.QuantityOnHand.ToString();
                            textBoxOtherPub.Text = book.PublisherName;
                            textBoxAuthor.Text = book.AuthorName;
                        }
                        else
                        {
                            MessageBox.Show("Book Not Found. Enter Valid Publisher Name or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }

                //Search by Book Author Name
                case 3:
                    {
                        Book book = InventoryControllerIO.SearchBookAuthor(textBoxSearchInfo.Text);
                        if (book != null)
                        {
                            textBoxISBN.Text = book.ISBN.ToString();
                            textBoxTitle.Text = book.Title;
                            textBoxUnitPrice.Text = book.UnitPrice.ToString();
                            textBoxYear.Text = book.YearPublished.ToString();
                            textBoxQOH.Text = book.QuantityOnHand.ToString();
                            textBoxOtherPub.Text = book.PublisherName;
                            textBoxAuthor.Text = book.AuthorName;
                        }
                        else
                        {
                            MessageBox.Show("Book Not Found. Enter Valid Author Name or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }
            }
        }

        private void FormInventoryController_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPubName_SelectedIndexChanged(object sender, EventArgs e)
        {

            int option = comboBoxPubName.SelectedIndex;
            switch (option)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }

                case 2:
                    {
                        break;
                    }

                case 3:
                    {
                        break;
                    }

                case 4:
                    {
                        labelOtherPub.Text = "Enter Other Pub. Name :";
                        textBoxOtherPub.Focus();
                        break;
                    }
            }
        }

        private void textBoxSearchInfo_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = false;
        }

        private void comboBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;

            int option = comboBoxSearchBy.SelectedIndex;
            switch (option)
            {
                case 0:
                    {
                        labelSearchInfo.Text = "Enter ISBN :";
                        textBoxSearchInfo.Focus();
                        break;
                    }

                case 1:
                    {
                        labelSearchInfo.Text = "Enter Title :";
                        textBoxSearchInfo.Focus();
                        break;
                    }
                case 2:
                    {
                        labelSearchInfo.Text = "Enter Pub Name :";
                        textBoxSearchInfo.Focus();
                        break;
                    }
                case 3:
                    {
                        labelSearchInfo.Text = "Enter Author Name :";
                        textBoxSearchInfo.Focus();
                        break;
                    }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHome homeobj = new FormHome();
            homeobj.Show();
            this.Close();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            Book book = new Book();
            if (BookValidation.checkBookISBN(textBoxISBN) && BookValidation.checkstring(textBoxTitle) && BookValidation.checkYear(textBoxYear))
            {
                book.ISBN = Convert.ToInt32(textBoxISBN.Text);
                book.Title = textBoxTitle.Text;
                book.UnitPrice = Convert.ToInt32(textBoxUnitPrice.Text);
                book.YearPublished = Convert.ToInt32(textBoxYear.Text);
                book.QuantityOnHand = Convert.ToInt32(textBoxQOH.Text);
                if (comboBoxPubName.SelectedIndex == 0)
                {
                    book.PublisherName = comboBoxPubName.SelectedItem.ToString();
                }
                else if (comboBoxPubName.SelectedIndex == 1)
                {
                    book.PublisherName = comboBoxPubName.SelectedItem.ToString();

                }
                else if (comboBoxPubName.SelectedIndex == 2)
                {
                    book.PublisherName = comboBoxPubName.SelectedItem.ToString();

                }
                else if (comboBoxPubName.SelectedIndex == 3)
                {
                    book.PublisherName = comboBoxPubName.SelectedItem.ToString();

                }
                else if (comboBoxPubName.SelectedIndex == 4)
                {

                    book.PublisherName = textBoxOtherPub.Text;

                }
                book.AuthorName = textBoxAuthor.Text;
                listViewBook.Items.Clear();

                if (bookListTemp.Count > 0)
                {
                    if(checkBookData(book))
                    {
                        book.SaveaBook(book);
                    }
                    else
                    {
                        book.UpdateaBook(book);
                        MessageBox.Show("Book Already Exist. Data Updated Successfully.");
                    }
                    
                }

                else
                {
                    bookListTemp.Add(book);
                    book.SaveaBook(book);
                }
                addintoListViewBook(book);
                book.ListAllBook(listViewBook);
                ClearAll();
            }
        }
            
            //this method will add data to listviewBook
          public void addintoListViewBook(Book book)
            {
                ListViewItem item = new ListViewItem(book.ISBN.ToString());
                item.SubItems.Add(book.Title);
                item.SubItems.Add(book.UnitPrice.ToString());
                item.SubItems.Add(book.YearPublished.ToString());
                item.SubItems.Add(book.QuantityOnHand.ToString());
                item.SubItems.Add(book.PublisherName);
                item.SubItems.Add(book.AuthorName);
                listViewBook.Items.Add(item);
            }

        //No duplicate values check function
        private bool checkBookData(Book book)
        {
            foreach (Book bookobj in bookListTemp)
            {
                if (bookobj.ISBN.Equals(book.ISBN))
                {
                    return false;
                }
            }
            return true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormHome homeobj = new FormHome();
            homeobj.Show();
            this.Close();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            Book bk=new Book();
           
            listViewBook.Items.Clear();
            bk.ListAllBook(listViewBook);







        }
    }
}
