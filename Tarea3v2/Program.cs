int tamanio=0;
int i=0;
float monto = 0;
int horas = 0;
float salario_bruto = 0;
float deduccion_CCSS = 0;
float aumento = 0;
int colaborador=0;
int operarios = 0;
int tecnicos = 0;
int profesionales = 0;
string salir = "";
float suma = 0;
int j = 0;


while (salir!="Si")
{
    string[] nombre = new string[tamanio + 1];
    Console.WriteLine("Ingrese el nombre: ");
    nombre[i] = Console.ReadLine();

    int[] cedula=new int[tamanio+1];
    Console.WriteLine("Ingrese cedula: ");
    cedula[i]=int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese tipo (1 operario, 2 tecnico, 3 profesional): ");
    colaborador= int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el monto por hora: ");
    monto = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese las horas laboradas: ");
    horas = int.Parse(Console.ReadLine());


    if (colaborador==1)
    {
        aumento = 0.15f * monto * horas;
    }
    if (colaborador == 2)
    {
        aumento = 0.10f * monto * horas;
    }
    if (colaborador == 3)
    {
        aumento = 0.05f * monto * horas;
    }

    salario_bruto = aumento+ (monto * horas);


    deduccion_CCSS = 9.17f / 100 * salario_bruto;


    Console.WriteLine("El nombre del colaborador es {0}: ", nombre[i]); 
    Console.WriteLine("La cedula {0}", cedula[i]);
    Console.WriteLine("El aumento es de: {0}", aumento);
    Console.WriteLine("El salario bruto es de: {0}", salario_bruto);
    Console.WriteLine("La deducción de CCSS es de: {0}", deduccion_CCSS);

    if (colaborador == 1)
    {
        float [] salario_neto_operario = new float[tamanio+1];
        salario_neto_operario[i] = salario_bruto - deduccion_CCSS;
        Console.WriteLine("El salario neto es: {0}", salario_neto_operario[i]);
    }
    if (colaborador == 2)
    {
        float[] salario_neto_tecnico = new float[tamanio + 1];
        salario_neto_tecnico[i]=salario_bruto-deduccion_CCSS;
        Console.WriteLine("El salario neto es: {0}", salario_neto_tecnico[i]);
    }
    if (colaborador == 3)
    {
        float[] salario_neto_profesional = new float[tamanio + 1];
        salario_neto_profesional[i] = salario_bruto - deduccion_CCSS;
        Console.WriteLine("El salario neto es: {0}", salario_neto_profesional[i]);
    }


    i++;
    tamanio++;
    tecnicos++;
    operarios++;
    profesionales++;
    Console.WriteLine("Deseas salir? Si/No");
    salir = Console.ReadLine();
}

   // for (j = 0; j < tamanio; j++)
      //  {
        //suma = suma + salario_neto_operario[i];
         //}
//Console.WriteLine(suma);

