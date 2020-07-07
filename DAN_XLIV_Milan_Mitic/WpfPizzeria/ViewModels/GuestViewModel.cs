using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfPizzeria.Model;
using WpfPizzeria.Views;

namespace WpfPizzeria.ViewModels
{
    class GuestViewModel : ViewModelBase
    {
        Guest guest;
        Service service = new Service();

        #region Constructors

        public GuestViewModel(Guest guestOpen)
        {
            meal = new tblMenu();
            guest = guestOpen;

            MealList = service.GetAllMeals();
        }

        #endregion

        #region Properties

        private tblMenu meal;

        public tblMenu Meal
        {
            get
            {
                return meal;
            }
            set
            {
                meal = value;
                OnPropertyChanged("Meal");
            }
        }

        private List<tblMenu> mealList;

        public List<tblMenu> MealList
        {
            get
            {
                return mealList;
            }
            set
            {
                mealList = value;
                OnPropertyChanged("MealList");
            }
        }

        #endregion
    }
}
