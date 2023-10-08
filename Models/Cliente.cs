namespace ParcialMVC.Models;


public class Cliente
{
public int Id { get; set; }
public string? Nombre { get; set; }
public decimal Edad { get; set; }
public string? Empresa { get; set; }

public virtual ICollection<Libro> Libros { get; set; }
}