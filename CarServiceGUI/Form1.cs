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
            sessionData.selectedClient = ClientMapper.fromModelToEntity((ClientModel)clientsFoundListBox.SelectedItem);
            if(sessionData.selectedClient == null)
            {
                clientCarsLabel.Visible = false;
                modifyAutoButton.Visible = false;
                deleteAutoButton.Visible = false;
            }
            else
            {
                clientCarsLabel.Visible = true;
                clientAutosListBox.Visible = true;
                modifyAutoButton.Visible = true;
                deleteAutoButton.Visible = true;
                var obtainedClient = sessionData.clientRepository.GetClient(sessionData.selectedClient.ClientId);
                List<Automobil> clientAutos = sessionData.clientRepository.GetAutosOfClient(obtainedClient);
                foreach(var auto in clientAutos)
                {
                    if(!clientAutosListBox.Items.Contains(auto))
                    {
                        clientAutosListBox.Items.Add(AutoMapper.FromEntityToModel(auto));
                    }
                }
            }
        }


    }
}
