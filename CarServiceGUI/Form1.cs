using CarServiceCore.Context;
using CarServiceCore.Model;
using CarServiceCore.Utils.Mapper;
using CarServiceGUI.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceGUI
{
    public partial class Form1 : Form
    {
        private SessionData sessionData = new SessionData();

        public Form1()
        {
            InitializeComponent();
        }

        private void clientFirstNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void clientLastNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void searchClientButton_Click(object sender, EventArgs e)
        {
            clientsFoundListBox.Items.Clear();
            clientCarsLabel.Visible = false;
            bool containsResults = false;
            List<Client> foundClients = sessionData.clientRepository.PartialSearchClients(clientFirstNameInput.Text, clientLastNameInput.Text);
            foreach(var client in foundClients)
            {
                if (client.Nume.ToLower().StartsWith(clientFirstNameInput.Text.ToLower()))
                {
                    containsResults = true;
                }
            }
            if (containsResults == true)
            {
                foreach (var client in foundClients)
                {
                    if (client.Nume.ToLower().StartsWith(clientFirstNameInput.Text.ToLower()))
                    {
                        clientsFoundListBox.Items.Add(ClientMapper.fromEntityToModel(client));
                    }
                }
                clientsFoundListBox.Visible = true;
                modifyClientButton.Visible = true;
                deleteClientButton.Visible = true;
            }
            else
            {
                modifyClientButton.Visible = false;
                deleteClientButton.Visible = false;
                clientsFoundListBox.Visible = false;
            }
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            sessionData.Operation_Type = OperationTypes.ADD_CLIENT;
            ClientPopupForm clientPopupForm = new ClientPopupForm(sessionData);
            clientPopupForm.Show();
        }

        private void modifyClientButton_Click(object sender, EventArgs e)
        {
            sessionData.Operation_Type = OperationTypes.MODIFY_CLIENT;
            sessionData.selectedClient = ClientMapper.fromModelToEntity((ClientModel)clientsFoundListBox.SelectedItem);
            ClientPopupForm clientPopupForm = new ClientPopupForm(sessionData);
            clientPopupForm.Show();
        }

        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            var clientToDelete = ClientMapper.fromModelToEntity((ClientModel)clientsFoundListBox.SelectedItem);
            sessionData.clientRepository.DeleteClient(clientToDelete.ClientId);
        }

        private void clientsFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientAutosListBox.Items.Clear();
            sessionData.selectedClient = ClientMapper.fromModelToEntity((ClientModel)clientsFoundListBox.SelectedItem);
            if(sessionData.selectedClient == null)
            {
                clientCarsLabel.Visible = false;
                modifyAutoButton.Visible = false;
                deleteAutoButton.Visible = false;
                addAutoToClientButton.Visible = false;
            }
            else
            {
                var obtainedClient = sessionData.clientRepository.GetClient(sessionData.selectedClient.ClientId);
                if (obtainedClient != null)
                {
                    clientCarsLabel.Visible = true;
                    clientAutosListBox.Visible = true;
                    modifyAutoButton.Visible = true;
                    deleteAutoButton.Visible = true;
                    addAutoToClientButton.Visible = true;
                    List<Automobil> clientAutos = sessionData.clientRepository.GetAutosOfClient(obtainedClient);
                    foreach (var auto in clientAutos)
                    {
                        if (!clientAutosListBox.Items.Contains(auto))
                        {
                            clientAutosListBox.Items.Add(AutoMapper.FromEntityToModel(auto));
                        }
                    }
                }
            }
        }

        private void deleteAutoButton_Click(object sender, EventArgs e)
        {
            var autoToDelete = AutoMapper.FromModelToEntity((AutoModel)clientAutosListBox.SelectedItem);
            sessionData.autoRepository.DeleteAuto(autoToDelete.AutoId);
        }

        private void modifyAutoButton_Click(object sender, EventArgs e)
        {
            sessionData.Operation_Type = OperationTypes.MODIFY_AUTO;
            sessionData.selectedAuto = AutoMapper.FromModelToEntity((AutoModel)clientAutosListBox.SelectedItem);
            AutoPopupForm autoPopupForm = new AutoPopupForm(sessionData);
            autoPopupForm.Show();
        }

        private void addAutoToClientButton_Click(object sender, EventArgs e)
        {
            sessionData.Operation_Type = OperationTypes.ADD_AUTO;
            AutoPopupForm autoPopupForm = new AutoPopupForm(sessionData);
            autoPopupForm.Show();
        }

        private void clientAutosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sessionData.selectedAuto = AutoMapper.FromModelToEntity((AutoModel)clientAutosListBox.SelectedItem);
            modifyAutoButton.Visible = true;
            deleteAutoButton.Visible = true;
            getOrdersForAutoButton.Visible = true;
            addOrderButton.Visible = true;
        }

        private void getOrdersForAutoButton_Click(object sender, EventArgs e)
        {
            ordersListBox.Items.Clear();
            ordersListBox.Visible = true;
            sessionData.selectedAuto = AutoMapper.FromModelToEntity((AutoModel)clientAutosListBox.SelectedItem);
            List<Comanda> foundOrders = sessionData.autoRepository.GetOrdersForCar(sessionData.selectedAuto);
            if (foundOrders != null)
            {
                foreach (var order in foundOrders)
                {
                    ordersListBox.Items.Add(OrderMapper.FromEntityToModel(order));
                }
            }
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            AddOrderPopup addOrderPopup = new AddOrderPopup(sessionData);
            addOrderPopup.Show();
        }

        private void ordersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sessionData.selectedAuto = AutoMapper.FromModelToEntity((AutoModel)clientAutosListBox.SelectedItem);
            modifyOrderButton.Visible = true;
            deleteOrderButton.Visible = true;
            viewOrderButton.Visible = true;
        }
    }
}
