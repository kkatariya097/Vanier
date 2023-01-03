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
    public partial class FormSalesManager : Form
    {
        //lists 
        List<Client> clientList = new List<Client>();
        List<Client> clientListTemp = new List<Client>();


        public FormSalesManager()
        {
            InitializeComponent();
        }


        //clear all textboxes mentioned below
        public void ClearAll()
        {
            textBoxClientID.Clear();
            textBoxClientName.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxPostal.Clear();
            maskedTextBoxPhone.Clear();
            textBoxFax.Clear();
            textBoxEmail.Clear();
        }


        //this method will add data to listviewClient
        public void addintoListView(Client client)
        {
            ListViewItem item = new ListViewItem(client.ClientID.ToString());
            item.SubItems.Add(client.ClientName);
            item.SubItems.Add(client.ClientStreet);
            item.SubItems.Add(client.ClientCity);
            item.SubItems.Add(client.ClientPostal);
            item.SubItems.Add(client.ClientPhone);
            item.SubItems.Add(client.ClientFax);
            item.SubItems.Add(client.ClientEmail);
            listViewClient.Items.Add(item);
        }

        //No duplicate values check function
        private bool checkClientData(Client client)
        {
            foreach (Client clnobj in clientListTemp)
            {
                if (clnobj.ClientID.Equals(client.ClientID))
                {
                    return false;
                }
            }
            return true;

        }











        private void FormSalesManager_Load(object sender, EventArgs e)
        {
            textBoxClientID.Focus();
            buttonSearch.Enabled = false;
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            FormHome homeobj = new FormHome();
            homeobj.Show();
            this.Close();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;
            int option = comboBoxSearch.SelectedIndex;
            switch (option)
            {
                case 0:
                    {
                        labelSearchInfo.Text = "Enter Client ID :";
                        textBoxSearchInfo.Focus();
                        break;
                    }

                case 1:
                    {
                        labelSearchInfo.Text = "Enter Client Name :";
                        textBoxSearchInfo.Focus();
                        break;
                    }

                case 2:
                    {
                        labelSearchInfo.Text = "Enter Client's Postal Code :";
                        textBoxSearchInfo.Focus();
                        break;
                    }
            }
        }

        private void textBoxSearchInfo_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;
        }

        //List all CLients in List view 
        private void buttonList_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            listViewClient.Items.Clear();
            client.ListAllClients(listViewClient);
        }


        //save client info
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            if ((ClientValidation.checkClientID(textBoxClientID))
                && ClientValidation.checkCLientName(textBoxClientName)
                && ClientValidation.checkCLientName(textBoxCity)
                && ClientValidation.checkPostal(textBoxPostal)
                && ClientValidation.checkEmail(textBoxEmail))
            {
                client.ClientID = Convert.ToInt32(textBoxClientID.Text);
                client.ClientName = textBoxClientName.Text;
                client.ClientStreet = textBoxStreet.Text;
                client.ClientCity = textBoxCity.Text;
                client.ClientPostal = textBoxPostal.Text;
                client.ClientFax = textBoxFax.Text;
                client.ClientPhone = maskedTextBoxPhone.Text;
                client.ClientEmail = textBoxEmail.Text;

                listViewClient.Items.Clear();

                //immediate add to listview while saving 
                if (clientListTemp.Count > 0)
                {
                    if (checkClientData(client))
                    {
                        client.SaveaClient(client);
                    }
                    else
                    {
                        client.UpdateaClient(client);
                        MessageBox.Show("Client Already Exist. Data Updated Successfully.");
                    }
                }
                else
                {
                    clientListTemp.Add(client);
                    client.SaveaClient(client);
                }
                addintoListView(client);
                client.ListAllClients(listViewClient);
                ClearAll();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int option = comboBoxSearch.SelectedIndex;

            switch (option)
            {
                case -1:
                    MessageBox.Show("Select a option to search from Combo Box.");
                    break;

                //search by Employee id
                case 0:
                    {
                        Client client = SalesManagerIO.SearchbyClientID(Convert.ToInt32(textBoxSearchInfo.Text));
                        if (client != null)
                        {
                            textBoxClientID.Text = client.ClientID.ToString();
                            textBoxClientName.Text = client.ClientName;
                            textBoxStreet.Text = client.ClientStreet;
                            textBoxCity.Text = client.ClientCity;
                            textBoxPostal.Text = client.ClientPostal;
                            textBoxFax.Text = client.ClientFax;
                            maskedTextBoxPhone.Text = client.ClientPhone;
                            textBoxEmail.Text = client.ClientEmail;
                        }
                        else
                        {
                            MessageBox.Show("Client Not Found. Enter Valid Client ID or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }

                case 1:
                    {
                        Client client = SalesManagerIO.SearchbyClientName(textBoxSearchInfo.Text);
                        if (client != null)
                        {
                            textBoxClientID.Text = client.ClientID.ToString();
                            textBoxClientName.Text = client.ClientName;
                            textBoxStreet.Text = client.ClientStreet;
                            textBoxCity.Text = client.ClientCity;
                            textBoxPostal.Text = client.ClientPostal;
                            textBoxFax.Text = client.ClientFax;
                            maskedTextBoxPhone.Text = client.ClientPhone;
                            textBoxEmail.Text = client.ClientEmail;
                        }
                        else
                        {
                            MessageBox.Show("Client Not Found. Enter Valid Client Name or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }
                case 2:
                    {
                        Client client = SalesManagerIO.SearchbyClientPostal(textBoxSearchInfo.Text);
                        if (client != null)
                        {
                            textBoxClientID.Text = client.ClientID.ToString();
                            textBoxClientName.Text = client.ClientName;
                            textBoxStreet.Text = client.ClientStreet;
                            textBoxCity.Text = client.ClientCity;
                            textBoxPostal.Text = client.ClientPostal;
                            textBoxFax.Text = client.ClientFax;
                            maskedTextBoxPhone.Text = client.ClientPhone;
                            textBoxEmail.Text = client.ClientEmail;
                        }
                        else
                        {
                            MessageBox.Show("Client Not Found. Enter Valid Client's Postal Code or try again.");
                            ClearAll();
                            textBoxSearchInfo.Focus();
                        }
                        break;
                    }

            }
        }
    }
}