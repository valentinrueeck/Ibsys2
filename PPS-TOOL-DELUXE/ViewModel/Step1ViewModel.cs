using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.Model.Output;
using PPS_TOOL_DELUXE.UI;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class Step1ViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public Action CloseAction { get; set; }
        public Action ShowNextAction { get; set; }

        private ExportModel exportModel;
        List<Sellwish> sellWish = new List<Sellwish>();
        List<Selldirect> sellDirect = new List<Selldirect>();
        List<Forecast> forecasts = new List<Forecast>();

        public int Sellwish1 { get; set; } 
        public int Sellwish2 { get; set; }
        public int Sellwish3 { get; set; }

        public int selldirect1 { get; set; }
        public int selldirect2 { get; set; }
        public int selldirect3 { get; set; }

        public long selldirect1price { get; set; }
        public long selldirect2price { get; set; }
        public long selldirect3price { get; set; }

        public long selldirect1fine { get; set; }
        public long selldirect2fine { get; set; }
        public long selldirect3fine { get; set; }

        public int forecast11 { get; set; }
        public int forecast12 { get; set; }
        public int forecast13 { get; set; }
               
        public int forecast21 { get; set; }
        public int forecast22 { get; set; }
        public int forecast23 { get; set; }
               
        public int forecast31 { get; set; }
        public int forecast32 { get; set; }
        public int forecast33 { get; set; }

        public Step1ViewModel()
        {
            exportModel = ServiceLocator.Current.GetInstance<MainViewModel>().export;

            Sellwish1 = 0;
            Sellwish2 = 0;
            Sellwish3 = 0;

            selldirect1 = 0;
            selldirect2 = 0;
            selldirect3 = 0;

            selldirect1price = 0L;
            selldirect2price = 0L;
            selldirect3price = 0L;

            selldirect1fine = 0L;
            selldirect2fine = 0L;
            selldirect3fine = 0L;

            forecast11 = 0;
            forecast21 = 0;
            forecast31 = 0;

            forecast12 = 0;
            forecast22 = 0;
            forecast32 = 0;

            forecast13 = 0;
            forecast23 = 0;
            forecast33 = 0;

            NextCommand = new RelayCommand(NextClick);
        }

        public RelayCommand NextCommand { get; set; }

        public void NextClick()
        {
            sellWish.Add(new Sellwish(1, Sellwish1));
            sellWish.Add(new Sellwish(2, Sellwish2));
            sellWish.Add(new Sellwish(3, Sellwish3));

            sellDirect.Add(new Selldirect(1, selldirect1, selldirect1price, selldirect1fine));
            sellDirect.Add(new Selldirect(2, selldirect2, selldirect2price, selldirect2fine));
            sellDirect.Add(new Selldirect(3, selldirect3, selldirect3price, selldirect3fine));

            forecasts.Add(new Forecast(1, 1, forecast11));
            forecasts.Add(new Forecast(2, 1, forecast12));
            forecasts.Add(new Forecast(3, 1, forecast13));
            forecasts.Add(new Forecast(1, 2, forecast21));
            forecasts.Add(new Forecast(2, 2, forecast22));
            forecasts.Add(new Forecast(3, 2, forecast23));
            forecasts.Add(new Forecast(1, 3, forecast31));
            forecasts.Add(new Forecast(2, 3, forecast32));
            forecasts.Add(new Forecast(3, 3, forecast33));

            exportModel.sellwishList = sellWish;
            exportModel.sellDirectList = sellDirect;
            exportModel.forecastList = forecasts;
            ServiceLocator.Current.GetInstance<MainViewModel>().export = exportModel;
            CloseAction();
            ShowNextAction();
        }
    }
}
