using System;

namespace Tarea01_Ejercicio3_Vera_Ivan
{
    internal class Program
    {
        private string nombre;
        private int edad;
        private string dni;

        static void Main(string[] args)
        {
            // Llamadas a las funciones para ejecutar cada ejercicio
            Ejercicio1();
            Console.WriteLine(); // Línea en blanco
            Ejercicio2();
            Console.WriteLine(); // Línea en blanco
            Ejercicio3();
            Console.WriteLine(); // Línea en blanco
            Ejercicio4();
        }

        // Función para ejecutar el ejercicio 1: Crear y mostrar información de una Persona
        static void Ejercicio1()
        {
            Persona persona = new Persona();
            persona.SetNombre("Juan Pérez");
            persona.SetEdad(30);
            persona.SetDni("12345678A");
            Console.WriteLine("Ejercicio 1 - Información de la Persona:");
            persona.ImprimirInformacion();
        }

        // Función para ejecutar el ejercicio 2: Crear y mostrar información de un Punto
        static void Ejercicio2()
        {
            Punto punto = new Punto();
            punto.SetX(5.0);
            punto.SetY(7.5);
            Console.WriteLine("Ejercicio 2 - Información del Punto:");
            punto.ImprimirPunto();
        }

        // Función para ejecutar el ejercicio 3: Crear y mostrar información de un Círculo
        static void Ejercicio3()
        {
            Circulo circulo = new Circulo();
            circulo.SetX(0);
            circulo.SetY(0);
            circulo.SetRadio(5);
            Console.WriteLine("Ejercicio 3 - Información del Círculo:");
            circulo.ImprimirCirculo();
        }

        // Función para ejecutar el ejercicio 4: Crear y mostrar información de una Persona con género
        static void Ejercicio4()
        {
            PersonaConGenero personaConGenero = new PersonaConGenero();
            personaConGenero.SetNombre("Carlos");
            personaConGenero.SetApellido("Sánchez");
            personaConGenero.SetEdad(25);
            personaConGenero.SetGenero("Masculino");
            Console.WriteLine("Ejercicio 4 - Información de la Persona con Género:");
            personaConGenero.ImprimirInformacion();
        }
    }

    // Clase Persona
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;

        // Función para establecer el nombre
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        // Función para obtener el nombre
        public string GetNombre()
        {
            return this.nombre;
        }

        // Función para establecer la edad
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        // Función para obtener la edad
        public int GetEdad()
        {
            return this.edad;
        }

        // Función para establecer el DNI
        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        // Función para obtener el DNI
        public string GetDni()
        {
            return this.dni;
        }

        // Función para imprimir la información de la persona
        public void ImprimirInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, DNI: {dni}");
        }
    }

    // Clase Punto
    class Punto
    {
        private double x;
        private double y;

        // Función para establecer el valor de x
        public void SetX(double x)
        {
            this.x = x;
        }

        // Función para obtener el valor de x
        public double GetX()
        {
            return this.x;
        }

        // Función para establecer el valor de y
        public void SetY(double y)
        {
            this.y = y;
        }

        // Función para obtener el valor de y
        public double GetY()
        {
            return this.y;
        }

        // Función para imprimir las coordenadas del punto
        public void ImprimirPunto()
        {
            Console.WriteLine($"Punto: ({x}, {y})");
        }
    }

    // Clase Circulo
    class Circulo
    {
        private double x;
        private double y;
        private double radio;

        // Función para establecer el valor de x (centro)
        public void SetX(double x)
        {
            this.x = x;
        }

        // Función para obtener el valor de x (centro)
        public double GetX()
        {
            return this.x;
        }

        // Función para establecer el valor de y (centro)
        public void SetY(double y)
        {
            this.y = y;
        }

        // Función para obtener el valor de y (centro)
        public double GetY()
        {
            return this.y;
        }

        // Función para establecer el radio
        public void SetRadio(double radio)
        {
            this.radio = radio;
        }

        // Función para obtener el radio
        public double GetRadio()
        {
            return this.radio;
        }

        // Función para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Función para imprimir la información del círculo
        public void ImprimirCirculo()
        {
            Console.WriteLine($"Círculo: Centro ({x}, {y}), Radio: {radio}, Área: {CalcularArea():F2}");
        }
    }

    // Clase PersonaConGenero
    class PersonaConGenero
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string genero;

        // Función para establecer el nombre
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        // Función para obtener el nombre
        public string GetNombre()
        {
            return this.nombre;
        }

        // Función para establecer el apellido
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        // Función para obtener el apellido
        public string GetApellido()
        {
            return this.apellido;
        }

        // Función para establecer la edad
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        // Función para obtener la edad
        public int GetEdad()
        {
            return this.edad;
        }

        // Función para establecer el género
        public void SetGenero(string genero)
        {
            this.genero = genero;
        }

        // Función para obtener el género
        public string GetGenero()
        {
            return this.genero;
        }

        // Función para imprimir la información de la persona con género
        public void ImprimirInformacion()
        {
            Console.WriteLine($"Nombre: {nombre} {apellido}, Edad: {edad}, Género: {genero}");
        }
    }
}
