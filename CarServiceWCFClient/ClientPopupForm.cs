using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceCore.Context;
using CarServiceGUI.Session;

namespace CarServiceWCFClient
{
    public partial class ClientPopupForm : Form
    {
        private SessionData clonnedSessionData = new SessionData();

        public ClientPopupForm(SessionData sesssionData)
        {
            InitializeComponent();
            clonnedSessionData = sesssionData;
        }

        private void ClientPopupForm_Load(object sender, EventArgs e)
        {
            if(clonnedSessionData.Operation_Type == OperationTypes.MODIFY_CLIENT)
            {
                firstNameInput.Text = clonnedSessionData.selectedClient.Nume;
                lastNameInput.Text = clonnedSessionData.selectedClient.Prenume;
                stateInput.Text = clonnedSessionData.selectedClient.Judet;
                cityInput.Text = clonnedSessionData.selectedClient.Localitate;
                emailInput.Text = clonnedSessionData.selectedClient.Email;
                adressInput.Text = clonnedSessionData.selectedClient.Adresa;
                phoneInput.Text = clonnedSessionData.selectedClient.Telefon;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (clonnedSessionData.Operation_Type == OperationTypes.ADD_CLIENT)
            {
                if(string.IsNullOrWhiteSpace(firstNameInput.Text) == true || string.IsNullOrWhiteSpace(lastNameInput.Text) == true 
                    || string.IsNullOrWhiteSpace(stateInput.Text) == true || string.IsNullOrWhiteSpace(cityInput.Text) == true 
                    || string.IsNullOrWhiteSpace(adressInput.Text) == true || string.IsNullOrWhiteSpace(phoneInput.Text) == true)
                {
                    MessageBox.Show("Not all mandatory fields are filled");
                    return;
                }

                Client clientToAdd = new Client
                {
                    Nume = firstNameInput.Text,
                    Prenume = lastNameInput.Text,
                    Judet = stateInput.Text,
                    Localitate = cityInput.Text,
                    Email = emailInput.Text,
                    Telefon = phoneInput.Text,
                    Adresa = adressInput.Text
                };
                clonnedSessionData.clientRepository.AddClient(clientToAdd);
            }
            if (clonnedSessionData.Operation_Type == OperationTypes.MODIFY_CLIENT)
            {
                if (string.IsNullOrWhiteSpace(firstNameInput.Text) == true || string.IsNullOrWhiteSpace(lastNameInput.Text) == true
                || string.IsNullOrWhiteSpace(stateInput.Text) == true || string.IsNullOrWhiteSpace(cityInput.Text) == true
                || string.IsNullOrWhiteSpace(adressInput.Text) == true || string.IsNullOrWhiteSpace(phoneInput.Text) == true)
                {
                    MessageBox.Show("Not all mandatory fields are filled");
                    return;
                }

                var clientToModify = clonnedSessionData.clientRepository.GetClient(clonnedSessionData.selectedClient.ClientId);
                clientToModify.ClientId = clonnedSessionData.selectedClient.ClientId;
                clientToModify.Nume = firstNameInput.Text;
                clientToModify.Prenume = lastNameInput.Text;
                clientToModify.Judet = stateInput.Text;
                clientToModify.Localitate = cityInput.Text;
                clientToModify.Email = emailInput.Text;
                clientToModify.Telefon = phoneInput.Text;
                clientToModify.Adresa = adressInput.Text;
                clonnedSessionData.clientRepository.UpdateClient(clientToModify);
            }
        }

        private void firstNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void lastNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        private void phoneInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void cityInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void stateInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

    }
}
