using System;

namespace EjemploSinGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno valorElemento;

            GuardaObjetos objetos = new GuardaObjetos(3);

            Alumno alumno1 = new Alumno(8.5);
            Alumno alumno2 = new Alumno(10);
            Alumno alumno3 = new Alumno(6.8);

            objetos.AgregarElementos(alumno1);
            objetos.AgregarElementos(alumno2);
            objetos.AgregarElementos(alumno3);

            //objetos.AgregarElementos("Luis");
            //objetos.AgregarElementos("José");
            //objetos.AgregarElementos("Juan");

            valorElemento = (Alumno)objetos.ObtenerElemento(0);
            Console.WriteLine(valorElemento.Calificacion);
        }
    }

    class GuardaObjetos
    {
        //Campos
        private int i = 0;
        private object[] matrizElementos;

        //Constructor
        public GuardaObjetos(int elementosParam)
        { 
            matrizElementos = new object[elementosParam];
        }

        //Métodos
        public void AgregarElementos(object elementoPa)
        { 
            matrizElementos[i] = elementoPa;
            i++;
        }

        public object ObtenerElemento(int elementoParam)
        {
            return matrizElementos[elementoParam];
        }
    }

    class Alumno
    {
        //Campos
        double calificacion;

        public Alumno(double calificacionParam)
        {
            calificacion = calificacionParam;
        }

        public double Calificacion
        {
            get => calificacion;
        }
    }
}
