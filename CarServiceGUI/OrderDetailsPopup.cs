using CarServiceCore.Context;
using CarServiceCore.Model;
using CarServiceCore.Utils.Mapper;
using CarServiceGUI.Session;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
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
                PopulateFields();
            }
            else if(clonedSessionData.Operation_Type == OperationTypes.VIEW_ORDER_DETAILS)
            {
                PopulateFields();
                DisableActionsViewMode();
            }
        }

        private void PopulateFields()
        {
            List<Mecanic> orderMechanics = clonedSessionData.orderRepository.GetMechanicsForOrder(clonedSessionData.selectedOrder);
            List<Operatie> orderOperations = clonedSessionData.orderRepository.GetOperationsForOrder(clonedSessionData.selectedOrder);
            List<Operatie> allOperations = clonedSessionData.operationsRepository.GetAllOperations();
            if (orderMechanics != null)
            {
                foreach (Mecanic mechanic in orderMechanics)
                {
                    orderMechanicsListBox.Items.Add(mechanic);
                }
            }
            if (allOperations != null)
            {
                foreach (var operation in allOperations)
                {
                    orderOperationsCheckedList.Items.Add(OperationsMapper.FromEntityToModel(operation));
                }
            }
            if (orderOperations != null)
            {
                foreach (var operation in orderOperations)
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

        private void DisableActionsViewMode()
        {
            appointmentDatePicker.Enabled = false;
            finalizationDatePicker.Enabled = false;
            totalPriceTextBox.Enabled = false;
            kmNumberTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            addMechanicButton.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
            saveOrderDetailsButton.Enabled = false;
            markOrderFinished.Enabled = false;
            markOrderImpossible.Enabled = false;
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
            MessageBox.Show(orderMechanicsListBox.SelectedItem.ToString());
            Type entityType = ObjectContext.GetObjectType(orderMechanicsListBox.SelectedItem.GetType());            
            var selectedMechanic  = MechanicMapper.FromModelToEntity((MechanicModel)orderMechanicsListBox.SelectedItem);
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

        private void markOrderFinished_Click(object sender, EventArgs e)
        {
            var order = clonedSessionData.selectedOrder;
            clonedSessionData.orderRepository.SetStatusToOrder(order, OrderStatusEnum.OrderFinished.ElementAt(0).Value);
        }

        private void markOrderImpossible_Click(object sender, EventArgs e)
        {
            var order = clonedSessionData.selectedOrder;
            clonedSessionData.orderRepository.SetStatusToOrder(order, OrderStatusEnum.OrderDenied.ElementAt(0).Value);
        }
    }
}
