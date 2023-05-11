using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class Impressora
    {
        public List<Documento> ListaDocumentos = new();
        static Impressora instancia { get; set; }

        private Impressora()
        {
        }

        public static Impressora Instancia()
        {
            if (instancia == null)
            {
                instancia = new Impressora();
            }
            return instancia;
        }

        public void AdicionarImpressao(Documento documento)
        {
            var temIsso = ListaDocumentos.Where(item => item == documento);
            if (!temIsso.Any())
            {
                ListaDocumentos.Add(documento);
            } else
            {
                Console.WriteLine("Já existe esse documento na fila");
            }
            
        }



        public void Imprimir()
        {
            foreach(Documento documento in ListaDocumentos)
            {
                Console.WriteLine(documento.texto);
            }
        }
    }
}