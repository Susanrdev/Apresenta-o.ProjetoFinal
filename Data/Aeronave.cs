using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace voe_airline_Blazor_vesp.Data
{
    public class Aeronave
    {
        public int? Id { get; set; }
        public string? Modelo { get; set; }
        public string? Codigo { get; set;}
      
        public Aeronave(string? modelo, string? codigo, int? id)
        {
            Modelo = modelo;
            Codigo = codigo;
            Id = id;
        }
    }
}