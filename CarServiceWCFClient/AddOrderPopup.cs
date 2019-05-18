using CarServiceCore.Context;
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
    public partial class AddOrderPopup : Form
    {
        private readonly SessionData clonedSessionData;

        public AddOrderPopup(SessionData sessionData)
        {
            InitializeComponent();
            clonedSessionData = sessionData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comanda orderToAdd = new Comanda
            {
                AutoId = clonedSessionData.selectedAuto.AutoId,
                ClientId = clonedSessionData.selectedClient.ClientId,
                DataProgramare = appointmentDatePicker.Value,
                DataFinalizare = finalizationDatePicker.Value,
                KmBord = Int32.Parse(kmNumberTextBox.Text),
                Descriere = descriptionTextBox.Text,
                ValoarePiese = Int32.Parse(totalPriceTextBox.Text)
            };

            clonedSessionData.orderRepository.AddOrder(orderToAdd);
        }
    }
}
