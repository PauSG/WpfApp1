using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfApp1.Message;

namespace WpfApp1
{
    class NuevaVM : ObservableObject
    {
        private Message ServicioMessage;
        private Navigation ServicioNavigation;

        public NuevaVM()
        {
            ServicioMessage = new Message();
            ServicioNavigation = new Navigation();
            WeakReferenceMessenger.Default.Register<NuevaVM, TextoMessage>(this, (r, m) =>
            {
                m.Reply(r.Texto);
            });
        }

        private string texto;

        public string Texto
        {
            get { return texto; }
            set { SetProperty(ref texto, value); }
        }


    }
}
