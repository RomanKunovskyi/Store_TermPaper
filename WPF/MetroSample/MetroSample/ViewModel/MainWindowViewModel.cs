using System.Collections.ObjectModel;
using Dto;
using Bll.Abstract;
using Bll.Concrete;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace MetroSample.ViewModel
{
    public class MainWindowViewModel: INotifyPropertyChanged
    {
        private bool SetPropertry<T>(ref T Storage, T Value, [CallerMemberName] string Propertyname = null)
        {
            if (EqualityComparer<T>.Default.Equals(Storage, Value)) return false;
            Storage = Value;
            OnPropertyChanged(Propertyname);
            return true;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public MainWindowViewModel()
        {
            StartUp();
        }

        public void StartUp()
        {
            LoadDetails();
        }

        public void LoadDetails()
        {
            IPurchaseHistoryBll.ClearSortAndFilters();
            var p = IPurchaseHistoryBll.GetList();
            MasterData = new ObservableCollection<PurchaseHistoryDto>(p);
        }


        private PurchaseHistoryDto _SelectedPurchaseHistoryDto;

        public PurchaseHistoryDto SelectedPurchaseHistoryDto
        {
            get { return _SelectedPurchaseHistoryDto; }
            set 
            {
                if (_SelectedPurchaseHistoryDto!=null)
                {
                    
                    IPurchaseHistoryBll.ClearSortAndFilters();
                    var p = IPurchaseHistoryBll.GetList();
                    _MasterData = new ObservableCollection<PurchaseHistoryDto>(p);
                    _IPurchaseHistoryBll.Edit(_SelectedPurchaseHistoryDto, productOldName);   
                }
                SetPropertry(ref _SelectedPurchaseHistoryDto,value);
                if (_SelectedPurchaseHistoryDto != null)
                {
                    productOldName = _SelectedPurchaseHistoryDto.Name;
                }
            }
        }


        
        private IPurchaseHistoryBll _IPurchaseHistoryBll;
        public IPurchaseHistoryBll IPurchaseHistoryBll
        {
            get { 
                
                if(_IPurchaseHistoryBll == null)
                {
                    _IPurchaseHistoryBll = new PurchaseHistoryBll(nickname);
                }

                return _IPurchaseHistoryBll ;
            }

            set
            {
                _IPurchaseHistoryBll = value;
            
            }
        }

        private ObservableCollection<PurchaseHistoryDto> _MasterData;
        public ObservableCollection<PurchaseHistoryDto> MasterData
        {
            get { return _MasterData; }
            set
            {
                SetPropertry(ref this._MasterData, value);
            }
        }


        public static string nickname = "";
        string productOldName = null;

        //Commands
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj => {
                      if(IPurchaseHistoryBll.GetList().Count!=0)
                      {
                          SelectedPurchaseHistoryDto = null;
                      }
                      PurchaseHistoryDto NewDto = new PurchaseHistoryDto("Null", 0, "Null", "Null", "Null", DateTime.Now);
                      _IPurchaseHistoryBll.Add(NewDto);
                      LoadDetails(); 
                      
                  }));
            }
        }
        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand(obj => {
                      _IPurchaseHistoryBll.Delete(_SelectedPurchaseHistoryDto);
                      SelectedPurchaseHistoryDto = null;
                      LoadDetails();
                  }));
            }
        }
    }
}
