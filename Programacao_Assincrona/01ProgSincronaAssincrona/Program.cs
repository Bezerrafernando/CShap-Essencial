Console.WriteLine("### Programação Síncrona ####\n");

int espera = 4000;//representa 4000 milisegundos ou 4 segundos

Console.WriteLine("Tecle algo para iniciar");
Console.ReadLine();

RealizarTarefa(espera);//chama método

Console.ReadKey();

static void RealizarTarefa(int tempo)
{
    Console.WriteLine("\n>>>iniciando a tarefa...");
    //Task.delay(Timespan.FromMilliseconds(tempo));
    Thread.Sleep(tempo);
    Console.WriteLine(">>>Tarefa concluida.");
}
