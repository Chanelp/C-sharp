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
        public TipoEscuela TipoEscuela;

        //Constructor, método que inicializa el objeto
        public Escuela(string nombre, int año){
            this.nombre = nombre;
            AñoCreacion = año;
        }
        
        //Sobreescribir método ToString()
        public override string ToString(){
            return $"Nombre: {Nombre}, Tipo: {TipoEscuela} \n Pais: {Pais}, Año Creación: {AñoCreacion}, Ciudad: {Ciudad}" ;
        }

        //Otra forma de definir el constructor
        //public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);

    }
}