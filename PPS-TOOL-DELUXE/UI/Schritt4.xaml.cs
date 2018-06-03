using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.Model.DragAndDrop;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Step4 : Window
    {
        #region drag and drop
        public ObservableCollection<ProductionOrderModel> ShareList { get; set; }

        public static readonly DependencyProperty DraggedItemProperty =
            DependencyProperty.Register("DraggedItem", typeof(ProductionOrderModel), typeof(Step4));
        public ProductionOrderModel DraggedItem
        {
            get { return (ProductionOrderModel)GetValue(DraggedItemProperty); }
            set { SetValue(DraggedItemProperty, value); }
        }
#endregion
        #region edit mode monitoring

        /// <summary>
        /// State flag which indicates whether the grid is in edit
        /// mode or not.
        /// </summary>
        public bool IsEditing { get; set; }

        private void OnBeginEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            IsEditing = true;
            //in case we are in the middle of a drag/drop operation, cancel it...
            if (IsDragging) ResetDragDrop();
        }

        private void OnEndEdit(object sender, DataGridCellEditEndingEventArgs e)
        {
            IsEditing = false;
        }

        #endregion
        #region Drag and Drop Rows

        /// <summary>
        /// Keeps in mind whether
        /// </summary>
        public bool IsDragging { get; set; }

        /// <summary>
        /// Initiates a drag action if the grid is not in edit mode.
        /// </summary>
        private void OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (IsEditing) return;

            var row = UIHelpers.TryFindFromPoint<DataGridRow>((UIElement)sender, e.GetPosition(producesGrid));
            if (row == null || row.IsEditing) return;

            //set flag that indicates we're capturing mouse movements
            IsDragging = true;
            DraggedItem = (ProductionOrderModel)row.Item;
        }


        /// <summary>
        /// Completes a drag/drop operation.
        /// </summary>
        private void OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (!IsDragging || IsEditing)
            {
                return;
            }

            //get the target item
                var targetItem = producesGrid.SelectedItem;

                if (targetItem == null || !ReferenceEquals(DraggedItem, targetItem))
                {
                    //remove the source from the list
                    ((producesGrid).ItemsSource as IList).Remove(DraggedItem);

                    //get target index
                    var targetIndex = ((producesGrid).ItemsSource as IList).IndexOf(targetItem);

                    //move source at the target's location
                    ((producesGrid).ItemsSource as IList).Insert(targetIndex, DraggedItem);

                    //select the dropped item
                    producesGrid.SelectedItem = DraggedItem;
                }

            //reset
            ResetDragDrop();
        }


        /// <summary>
        /// Closes the popup and resets the
        /// grid to read-enabled mode.
        /// </summary>
        private void ResetDragDrop()
        {
            IsDragging = false;
            popup1.IsOpen = false;
            producesGrid.IsReadOnly = false;
        }


        /// <summary>
        /// Updates the popup's position in case of a drag/drop operation.
        /// </summary>
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!IsDragging || e.LeftButton != MouseButtonState.Pressed) return;

            //display the popup if it hasn't been opened yet
            if (!popup1.IsOpen)
            {
                //switch to read-only mode
                producesGrid.IsReadOnly = true;

                //make sure the popup is visible
                popup1.IsOpen = true;
            }


            Size popupSize = new Size(popup1.ActualWidth, popup1.ActualHeight);
            popup1.PlacementRectangle = new Rect(e.GetPosition(this), popupSize);

            //make sure the row under the grid is being selected
            Point position = e.GetPosition(producesGrid);
            var row = UIHelpers.TryFindFromPoint<DataGridRow>(producesGrid, position);
            if (row != null) producesGrid.SelectedItem = row.Item;
        }

        #endregion
        public Step4()
        {
            InitializeComponent();
            var viewModel = ServiceLocator.Current.GetInstance<Step4ViewModel>();
            if (viewModel.CloseAction == null)
                viewModel.CloseAction = Close;
            var nextWindow = new Step5();
            if (viewModel.ShowNextAction == null)
                viewModel.ShowNextAction = nextWindow.Show;
        }

        private void Schritt4_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void Schritt4_ContentRendered(object sender, System.EventArgs e)
        {
            var viewModel = ServiceLocator.Current.GetInstance<Step4ViewModel>();
            viewModel.Initialize();
        }

        private void producesGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (producesGrid.SelectedIndex == -1)
            {
                btn_minus.IsEnabled = false;
                return;
            }
            btn_minus.IsEnabled = true;
        }
    }
}
