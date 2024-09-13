// See https://aka.ms/new-console-template for more information
using Ejercicio5_Eventos;

Console.WriteLine("Ejercicio #5\n");
//Implementa una clase AlarmClock que tenga un evento OnAlarmRing.
//El evento debe ser disparado cuando se alcance la hora configurada por el usuario.

Console.Write("Ingresa la hora para la alarma (HH:mm:ss): ");
string HoraDeAlarma = Console.ReadLine();

DateTime TiempoDeAlarma;
if (DateTime.TryParse(HoraDeAlarma, out TiempoDeAlarma))
{
    // esto es un poco extra, pero me gusto la funcionalidad =) : Si la hora ingresada ya pasó, se programa para el día siguiente
    if (TiempoDeAlarma.TimeOfDay <= DateTime.Now.TimeOfDay)
    {
        TiempoDeAlarma = TiempoDeAlarma.AddDays(1);
    }

    AlarmClock alarma = new AlarmClock(TiempoDeAlarma);
    alarma.EncendidoDeAlarma += AlarmClock_OnAlarmRing;

    Console.WriteLine("Alarma configurada para: " + TiempoDeAlarma.ToString("HH:mm:ss"));
    alarma.Inicio();

    Console.WriteLine("Presiona Enter para salir...");
    Console.ReadLine();

    alarma.fin();
}
else
{
    Console.WriteLine("Hora inválida");
}
static void AlarmClock_OnAlarmRing(object sender, EventArgs e)
{
    Console.WriteLine("LEVANTATEEE!!!!!!!!");
}
