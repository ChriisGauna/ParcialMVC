namespace ParcialMVC.Models;

public class Libro
{
public int Id { get; set; }
public string? Nombre { get; set; }
public int Año { get; set; }
public string? Genero { get; set; }
public bool EsNacional { get; set; }
public decimal Precio { get; set; }
public string? Empresa { get; set; }
public string? Imagen { get; set; }

public int? ClienteId { get; set; }

public virtual Cliente Usuario { get; set; }
}