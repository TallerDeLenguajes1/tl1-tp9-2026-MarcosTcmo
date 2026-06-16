string direccion;
Console.WriteLine("Ingrese un path para una ubicacion de archivo");
direccion = Console.ReadLine();
do
{
    if (Path.Exists(direccion))
    {
        Console.WriteLine("funciona asi");
    }
    else
    {
        Console.WriteLine("La direccion que ingreso no existe, ingrese otra");
        direccion = Console.ReadLine();
    }
} while (!(Path.Exists(direccion)));
foreach (string direcciones in Directory.GetDirectories(direccion))
{
    Console.WriteLine(Path.GetFileName(direcciones));
}
foreach (string archivos in Directory.GetFiles(direccion))
{
    Console.WriteLine(Path.GetFileName(archivos));
    byte[] bits = File.ReadAllBytes(archivos);
    long tamanio = bits.Length;
    Console.WriteLine(tamanio);
}