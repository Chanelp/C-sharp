using System.Text;

namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre; //Atributo

        public string Nombre
        { //Propiedades
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TipoEscuela TipoEscuela;
        public Curso[] Cursos {get; set;}

        //Constructor, método que inicializa el objeto
        public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);
        
        /*public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            AñoCreacion = año;
        }*/

        //Parámetros opcionales
        //Firma: qué valor devuelve, que nombre tiene y qué parámetro recibe
        public Escuela(string nombre, int año, TipoEscuela tipo, string pais = "", string ciudad =""){
            (Nombre, AñoCreacion, TipoEscuela) = (nombre, año, tipo);
            Pais = pais;
            Ciudad = ciudad;
        }

        //Sobreescribir método ToString()
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} \n Pais: {Pais}, Año Creación: {AñoCreacion}, {System.Environment.NewLine} Ciudad: {Ciudad}";
        }

        /*
        Otra forma de definir el constructor:
        public Escuela(string nombre, int año) => (Nombre, AñoCreacion) = (nombre, año);
        */

        /*
        Otra forma de retornar los atributos es con StringBuilder: mejora el performace y más específico.

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre + "\n");
            sb.AppendLine("Pais: " + this.Pais + "\n");
            sb.AppendLine("Ciudad: " + this.Ciudad + "\n");
            sb.AppendLine("Año: " + this.AñoDeCreación + "\n");
            sb.AppendLine("Tipo de Escuela: " + this.TipoEscuelas + "\n");
            return sb.ToString();

        }*/

    }
}