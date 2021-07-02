using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionClase
{
    class Promedio
    {
        public string Nombre { get; set; }
        public int Cuenta { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }
        public Double Total { get; set; }
        public Double Prom { get; set; }
        public String comentario { get; set; }

        public Promedio() { }

        public Promedio(String _nombre,int _cuenta,int _nota1, int _nota2, int _nota3, int _nota4) 
        {
            Nombre = _nombre;
            Cuenta = _cuenta;
            Nota1 = _nota1;
            Nota2 = _nota2;
            Nota3 = _nota3;
            Nota4 = _nota4;
            


        }
        public string devolverNombreCuenta()
        {
            
            return Nombre + "  " + Cuenta;
        }
        public Double devolverPromedio()
        {
            Total = Nota1 + Nota2 + Nota3 + Nota4;
            Prom = Total/ 4;
            return  Prom;
            
            
        }
        public string devolverPasar()
        {
            string comentario;

            if (Prom >= 70)
            {
                comentario = "Aprobo";
                
            }
            else
            {
                comentario = "Reprobo";

            }
           
            return  comentario;
        }
    }

}
