namespace Ejerciciodiamesaño
{
    public class program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int anyo = 0;
            Console.WriteLine("Ingresa por favor el año");
            anyo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa por favor el mes");
            mes = Convert.ToInt32(Console.ReadLine());
            if (mes > 12)
            {
                Console.WriteLine(("El número que ingresaste excede la cantidad de meses que existen en el año, por favor ingrese un numero valido para este campo"));
                mes = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ingresa por favor el dia");
            dia = Convert.ToInt32(Console.ReadLine());

            double añodiaextra = anyo % 4;
            Convert.ToDouble(dia);
            Convert.ToDouble(mes);

            if (añodiaextra == 0 && mes == 2 && dia > 29)
            {
                Console.WriteLine(("El número que ingresaste excede la cantidad de dias del mes, por favor inserte un número valido para este campo"));
                dia = Convert.ToInt32(Console.ReadLine());
            }

            if (añodiaextra != 0 && mes == 2 && dia > 28)
            {
                Console.WriteLine(("El número que ingresaste excede la cantidad de dias del mes, por favor inserte un número valido"));
                dia = Convert.ToInt32(Console.ReadLine());
            }

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11 && dia > 30)
            {
                Console.WriteLine(("El número que ingresaste excede la cantidad de dias del mes, por favor inserte un número valido"));
                dia = Convert.ToInt32(Console.ReadLine());
            }

            if (mes == 1 && mes == 3 || mes == 5 || mes == 7 && mes == 8 || mes == 10 || mes == 12 && dia > 31)
            {
                Console.WriteLine(("El número que ingresaste excede la cantidad de dias del mes, por favor inserte un número valido"));
                dia = Convert.ToInt32(Console.ReadLine());
            }

            DateTime miFecha = new DateTime(anyo, mes, dia);
            miFecha = miFecha.AddDays(1);

            Console.WriteLine(miFecha);
        }
    }
}