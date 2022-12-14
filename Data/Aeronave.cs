using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voe_airline_Blazor_vesp.Data
{
    public class Aeronave
    {
        public string? Modelo { get; set; }
        public string? Codigo { get; set;}
        public string? Fabricante { get; set;}
      
        public Aeronave(string? modelo, string? codigo, string? fabricante)
        {
            Modelo = modelo;
            Codigo = codigo;
            Fabricante = fabricante;
        }
    }
}