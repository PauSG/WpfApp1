using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.Message;

namespace WpfApp1
{
    class MainWindowVM : ObservableRecipient
    {
        Navigation NavigationService;
        private bool? dialog;
        public MainWindowVM()
        {
            NavigationService = new Navigation();
            InformacionCommand = new RelayCommand(abrirVentana);
        }

        private void abrirVentana()
        {
           dialog = NavigationService.abrirNuevaVentana();
            if (dialog == true)
            {
                Console.WriteLine("Se envio");
                Texto = WeakReferenceMessenger.Default.Send<TextoMessage>();
            }
            else
            {
                Texto = "No se envio nada";
            }
        }

        private string texto;
        public string Texto
        {
            get { return texto; }
            set { SetProperty(ref texto, value); }
        }

        public RelayCommand InformacionCommand { get; }

    }

}
