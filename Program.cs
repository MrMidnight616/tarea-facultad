// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Random nrorandom = new Random();
string eleccion,personadice, inicio;


do
{
    int CaraoCruz = nrorandom.Next(1,3);

    Console.Clear();
    Console.WriteLine("jugamos?");
    inicio = Console.ReadLine();

    switch (CaraoCruz)
	{
		case 1:
			CaraoCruz = 1;
			eleccion = "cara";

            Console.WriteLine("cara o cruz");
            personadice = Console.ReadLine();
			if (personadice ==eleccion)
			{
                Console.WriteLine("si era CARA!!");
            }

            if (personadice != eleccion)
            {
                Console.WriteLine("no, era CARA!!");
            }

            break;

		case 2:
			CaraoCruz = 2;
			eleccion = "cruz";

            Console.WriteLine("cara o cruz");
            personadice = Console.ReadLine();
            if (personadice == eleccion)
            {
                Console.WriteLine("si era CRUZ!!");
            }

            if (personadice != eleccion)
            {
                Console.WriteLine("no, era CRUZ!!");
            }
            break;

        case 3: 
            CaraoCruz = 3;
            Console.WriteLine(" se clavo la moneda ");
            break;



    }

    Console.ReadKey();
	
}while (inicio=="si");


