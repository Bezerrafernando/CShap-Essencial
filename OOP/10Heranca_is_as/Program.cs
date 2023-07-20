using _10Heranca_is_as;

//Fazendo a converção explícita (casting) sem usar o operador "as"

object carroObj = new Carro();

try
{
    var x = (string)carroObj; //System.InvalidCastExcepition;
}
catch (Exception ex)
{
    Console.WriteLine("\nA conversão falhou...\n");
    Console.WriteLine(ex.Message);
}
//-------------------------------------------------
//Fazendo a converção usando o operador  "as"

Object carroObj1 = new Carro();

var y = carroObj1 as string; // avalia y como null

if (y != null)
{
    Console.WriteLine("converteu obj para string");
}
else
{
    Console.WriteLine("y é null");
}
//------------------------------------------------------------
//Fazendo o downcasting usando o operador "as"

Circulo circulo1 = new Circulo();
Forma forma1 = circulo1;

//Circulo c = (Circulo)forma;
Circulo c = forma1 as Circulo; //downcasting

if (c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting inválida");
}

//---------------------------------------------------------
Circulo circulo = new Circulo();
Forma forma = circulo;

if (forma is Circulo) //verifica se downcasting é possivel
{
    Console.WriteLine("Comverteu Forma para Circulo\n");
    //((Circulo)forma).PintarCirculo();
    var tipo = forma as Circulo;
    tipo?.PintarCirculo();
}
else
{
    Console.WriteLine("Operação de downcasting não é possível");
}
class Carro { }
