namespace CoreEscuela.Entidades
{
    class Escuela {
        string nombre; //Atributo

        public string Nombre{ //Propiedades
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad {get; set;}

        //Constructor, método que inicializa el objeto
        public Escuela(string nombre, int año){
            this.nombre = nombre;
            AñoCreacion = año;
        }
        
        //Otra forma de definir el constructor
        //public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);

    }
}