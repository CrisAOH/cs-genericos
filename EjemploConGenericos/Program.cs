using System;

namespace EjemploConGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno valorElemento;
            string valorElemento2;

            GuardaObjetos<Alumno> objetos = new GuardaObjetos<Alumno>(3);

            Alumno alumno1 = new Alumno(8.5);
            Alumno alumno2 = new Alumno(10);
            Alumno alumno3 = new Alumno(6.8);

            objetos.AgregarElementos(alumno1);
            objetos.AgregarElementos(alumno2);
            objetos.AgregarElementos(alumno3);

            GuardaObjetos<string> objetos2 = new GuardaObjetos<string>(3);

            objetos2.AgregarElementos("Luis");
            objetos2.AgregarElementos("José");
            objetos2.AgregarElementos("Juan");

            valorElemento = objetos.ObtenerElemento(0);
            valorElemento2 = objetos2.ObtenerElemento(1);
            Console.WriteLine(valorElemento.Calificacion);
            Console.WriteLine(valorElemento2);
        }
    }

    class GuardaObjetos<T>
    {
        //Campos
        private int i = 0;
        private T[] matrizElementos;

        //Constructor
        public GuardaObjetos(int elementosParam)
        {
            matrizElementos = new T[elementosParam];
        }

        //Métodos
        public void AgregarElementos(T elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++;
        }

        public T ObtenerElemento(int elementoParam)
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
