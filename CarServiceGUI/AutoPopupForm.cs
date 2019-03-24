using CarServiceCore.Context;
using CarServiceCore.Model;
using CarServiceCore.Utils.Mapper;
using CarServiceCore.Utils.Transformer;
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
    public partial class AutoPopupForm : Form
    {
        private SessionData clonnedSessionData = new SessionData();
        private int selectedOwnerIndex = 0;
        private int selectedChassisIndex = 0;

        public AutoPopupForm(SessionData sessionData)
        {
            InitializeComponent();
            clonnedSessionData = sessionData;
            if (clonnedSessionData.Operation_Type == OperationTypes.MODIFY_AUTO || clonnedSessionData.Operation_Type == OperationTypes.ADD_AUTO)
            {
                foreach (var client in sessionData.clientRepository.GetClients())
                {
                    if (client.ClientId == clonnedSessionData.selectedClient.ClientId)
                    {
                        selectedOwnerIndex = sessionData.clientRepository.GetClients().IndexOf(client);
                    }
                    autoOwnersComboBox.Items.Add(ClientMapper.fromEntityToModel(client));
                }
                foreach (var chassis in sessionData.chassisRepository.GetAllChassis())
                {
                    chassisComboBox.Items.Add(ChassisMapper.FromEntityToModel(chassis));
                }

                //chassisComboBox.SelectedItem = ChassisMapper.FromEntityToModel(clonnedSessionData.chassisRepository.GetChassis(chassisId)).ToString();
            }
        }

        private void AutoPopupForm_Load(object sender, EventArgs e)
        {
            if (clonnedSessionData.Operation_Type == OperationTypes.MODIFY_AUTO)
            {
                chassisComboBox.SelectedIndex = selectedChassisIndex;
                autoOwnersComboBox.SelectedIndex = selectedOwnerIndex;
                registrationNumberTextBox.Text = clonnedSessionData.selectedAuto.NumarAuto;
                chassisSeriesTextBox.Text = clonnedSessionData.selectedAuto.SerieSasiu;
                chassisComboBox.Enabled = false;
            }
            if (clonnedSessionData.Operation_Type == OperationTypes.ADD_AUTO)
            {
                autoOwnersComboBox.Enabled = true;
                chassisComboBox.Enabled = true;
            }
        }

        private void autoSaveButton_Click(object sender, EventArgs e)
        {
            var clientChoosed = ClientMapper.fromModelToEntity((ClientModel)autoOwnersComboBox.SelectedItem);
            var chassisSelected = (ChassisModel)chassisComboBox.SelectedItem;
            if (clonnedSessionData.Operation_Type == OperationTypes.MODIFY_AUTO)
            {
                var autoToModify = clonnedSessionData.selectedAuto;
                autoToModify.AutoId = clonnedSessionData.selectedAuto.AutoId;
                autoToModify.NumarAuto = registrationNumberTextBox.Text;
                autoToModify.SerieSasiu = chassisSeriesTextBox.Text;
                autoToModify.ClientId = clientChoosed.ClientId;
                clonnedSessionData.autoRepository.UpdateAuto(autoToModify);
            }
            if (clonnedSessionData.Operation_Type == OperationTypes.ADD_AUTO)
            {
                Automobil autoToAdd = new Automobil
                {
                    NumarAuto = registrationNumberTextBox.Text,
                    SerieSasiu = chassisSeriesTextBox.Text,
                    ClientId = clientChoosed.ClientId,
                    SasiuId = chassisSelected.SasiuId
                };
                clonnedSessionData.autoRepository.AddAuto(autoToAdd);
            }
        }

        private void registrationNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void chassisSeriesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
