using System.Collections.Generic;
using WpfPizzeria.Model;
using WpfPizzeria.Views;

namespace WpfPizzeria.ViewModels
{
    class OrderViewModel : ViewModelBase
    {
        Order order;
        Service service = new Service();

        #region Constructors

        public OrderViewModel(Order orderOpen)
        {
            order = orderOpen;

            RecordList = service.GetRecords();
        }

        #endregion

        #region Properties

        private List<tblRecord> recordList;

        public List<tblRecord> RecordList
        {
            get
            {
                return recordList;
            }
            set
            {
                recordList = value;
                OnPropertyChanged("RecordList");

            }
        }

        private tblRecord record;

        public tblRecord Record
        {
            get
            {
                return record;
            }
            set
            {
                record = value;
                OnPropertyChanged("Record");

            }
        }

        #endregion
    }
}
