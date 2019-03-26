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
    public partial class OrderDetailsPopup : Form
    {
        private SessionData clonedSessionData;

        private List<MechanicModel> addedMechanics = new List<MechanicModel>();
        private List<OperationModel> addedOperations = new List<OperationModel>();

        public OrderDetailsPopup(SessionData sessionData)
        {
            InitializeComponent();
            clonedSessionData = sessionData;
            if(clonedSessionData.Operation_Type == OperationTypes.MODIFY_ORDER_DETAILS)
            {
                List<Mecanic> orderMechanics = clonedSessionData.orderRepository.GetMechanicsForOrder(clonedSessionData.selectedOrder);
                List<Operatie> orderOperations = clonedSessionData.orderRepository.GetOperationsForOrder(clonedSessionData.selectedOrder);
                List<Operatie> allOperations = clonedSessionData.operationsRepository.GetAllOperations();
                if(orderMechanics != null)
                {
                    foreach(var mechanic in orderMechanics)
                    {
                        orderMechanicsListBox.Items.Add(mechanic);
                    }
                }
                if(allOperations != null)
                {
                    foreach(var operation in allOperations)
                    {
                        orderOperationsCheckedList.Items.Add(OperationsMapper.FromEntityToModel(operation));
                    }
                }
                if(orderOperations != null)
                {
                    foreach(var operation in orderOperations)
                    {
                        orderOperationsListBox.Items.Add(OperationsMapper.FromEntityToModel(operation));
                    }
                }
                appointmentDatePicker.Value = (DateTime)clonedSessionData.selectedOrder.DataProgramare;
                finalizationDatePicker.Value = (DateTime)clonedSessionData.selectedOrder.DataFinalizare;
                totalPriceTextBox.Text = clonedSessionData.selectedOrder.ValoarePiese.ToString();
                kmNumberTextBox.Text = clonedSessionData.selectedOrder.KmBord.ToString();
                descriptionTextBox.Text = clonedSessionData.selectedOrder.Descriere;
            }
        }

        private void addMechanicButton_Click(object sender, EventArgs e)
        {
            var availableMechanics = clonedSessionData.mechanicRepository.GetAvailableMechanicsToExecuteOperation();
            if (availableMechanics.ToList().Count() > 0)
            {
               foreach(var mechanic in availableMechanics)
               {
                   addedMechanics.Add(MechanicMapper.FromEntityToModel(mechanic));
                   orderMechanicsListBox.Items.Add(MechanicMapper.FromEntityToModel(mechanic));
               }
            }
            else if(availableMechanics.ToList().Count() < 1)
            {
                MessageBox.Show("No available mechanics");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderOperationsCheckedList.Visible = true;
            saveOperationChoice.Visible = true;
        }

        private void saveOperationChoice_Click(object sender, EventArgs e)
        {
            foreach(OperationModel i in orderOperationsCheckedList.CheckedItems)
            {
                if(!orderOperationsListBox.Items.Contains(i))
                {
                    addedOperations.Add(i);
                    orderOperationsListBox.Items.Add(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedMechanic  = MechanicMapper.FromModelToEntity((MechanicModel)orderMechanicsListBox.SelectedItem);
            MessageBox.Show(selectedMechanic.ToString());
            clonedSessionData.mechanicRepository.DeleteMechanic(selectedMechanic.MecanicId);
            orderMechanicsListBox.Update();
        }

        private void saveOrderDetailsButton_Click(object sender, EventArgs e)
        {
            if(addedMechanics.Count() == 0)
            {
                MessageBox.Show("You need at least one mechanic");
            }
            else if(addedOperations.Count() == 0)
            {
                MessageBox.Show("You need at least one operation");
            }

            foreach(MechanicModel mechanic in addedMechanics)
            {
                foreach(OperationModel operation in addedOperations)
                {
                    DetaliiComanda orderDetails = new DetaliiComanda
                    {
                        ComandaId = clonedSessionData.selectedOrder.ComandaId,
                        AutoId = clonedSessionData.selectedAuto.AutoId,
                        MecanicId = mechanic.MechanicId,
                        OperatieId = operation.OperationId,
                        ImagineId = 2
                    };
                    clonedSessionData.orderRepository.AddOrderDetailsForOrder(orderDetails);
                }
            }
        }
    }
}
