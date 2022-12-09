using System;
using System.ComponentModel.DataAnnotations;
namespace CRUDAPI {
public class Usuario
 {
public Usuario() => CriadoEm = DateTime.Now;
[Key]
public int Id {get; set;}
public string Nome {get;set;}
public string DataNasc {get;set;}

public DateTime CriadoEm {get;set;}
 }
}