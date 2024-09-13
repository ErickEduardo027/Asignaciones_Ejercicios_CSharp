using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ejercicio5_Eventos
{
    public class AlarmClock
    {
        private DateTime tiempoAlarma;
        private System.Timers.Timer temporizador;

        public event EventHandler EncendidoDeAlarma;

        public AlarmClock(DateTime tiempo)
        {
            tiempoAlarma = tiempo;
            temporizador = new System.Timers.Timer(1000);
            temporizador.Elapsed += ComprobarTiempo;
        }
        public void Inicio()
        {
            temporizador.Start();
        }
        public void fin()
        {
            temporizador.Stop();
        }
        private void ComprobarTiempo(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Now > tiempoAlarma)
            {
                temporizador.Stop();
                EncendidoDeAlarma?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
