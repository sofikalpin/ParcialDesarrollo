using Modelos;

public class Servicio
{
    private const string Archivo = "comercio.txt";

    public List<Comercio> GetProductos() => File.Exists(Archivo)
        ? File.ReadAllLines(Archivo)
            .Select(l => l.Split('|'))
            .Select(d => new Comercio
            {
                Id = int.Parse(d[0]),
                Nombre = d[1],
                Precio = decimal.Parse(d[2])
            }).ToList()
        : new List<Comercio>();

    public void AddProducto(Comercio p) =>
        File.AppendAllText(Archivo, $"{p.Id}|{p.Nombre}|{p.Precio}\n");

    public void PutProducto(Comercio nuevo)
    {
        var productos = GetProductos();
        var index = productos.FindIndex(p => p.Id == nuevo.Id);
        if (index == -1) throw new Exception("Producto no encontrado");
        productos[index] = nuevo;
        GuardarTodos(productos);
    }

    public void DeleteProducto(int id)
    {
        var productos = GetProductos();
        if (!productos.RemoveAll(p => p.Id == id).Equals(0))
            GuardarTodos(productos);
        else
            throw new Exception("Producto no encontrado");
    }

    private void GuardarTodos(List<Comercio> productos) =>
        File.WriteAllLines(Archivo, productos.Select(p => $"{p.Id}|{p.Nombre}|{p.Precio}"));
}