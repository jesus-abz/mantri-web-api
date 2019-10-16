using System;

namespace mantri_web_api.Modules
{
    public class Mantri
    {
        string nombre;
        string clase1;
        string clase2;
        string clase3;
        string elementomain;
        string elementosec1;
        string elementosec2;
        string elementosec3;
        int fase;
        string prevmorf;
        int salud;
        int defensa;
        int energia;
        int ataque;
        int velocidad;
        string imagen;
        string descripcion;
        string datosextra;
        string compatibilidad1;
        string compatibilidad2;
        string compatibilidad3;
        string compatibilidad4;
        string compatibilidad5;
        string compatibilidadtext;

        public Mantri(){}

        public Mantri(string nombre, string clase1, string clase2, string clase3, string elementomain, string elementosec1, string elementosec2, string elementosec3, int fase, string prevmorf, int salud, int defensa, int energia, int ataque, int velocidad, string imagen, string descripcion, string datosextra, string compatibilidad1, string compatibilidad2, string compatibilidad3, string compatibilidad4, string compatibilidad5, string compatibilidadtext)
        {
            this.nombre = nombre;
            this.clase1 = clase1;
            this.clase2 = clase2;
            this.clase3 = clase3;
            this.elementomain = elementomain;
            this.elementosec1 = elementosec1;
            this.elementosec2 = elementosec2;
            this.elementosec3 = elementosec3;
            this.fase = fase;
            this.prevmorf = prevmorf;
            this.salud = salud;
            this.defensa = defensa;
            this.energia = energia;
            this.ataque = ataque;
            this.velocidad = velocidad;
            this.imagen = imagen;
            this.descripcion = descripcion;
            this.datosextra = datosextra;
            this.compatibilidad1 = compatibilidad1;
            this.compatibilidad2 = compatibilidad2;
            this.compatibilidad3 = compatibilidad3;
            this.compatibilidad4 = compatibilidad4;
            this.compatibilidad5 = compatibilidad5;
            this.compatibilidadtext = compatibilidadtext;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Clase1 { get => clase1; set => clase1 = value; }
        public string Clase2 { get => clase2; set => clase2 = value; }
        public string Clase3 { get => clase3; set => clase3 = value; }
        public string Elementomain { get => elementomain; set => elementomain = value; }
        public string Elementosec1 { get => elementosec1; set => elementosec1 = value; }
        public string Elementosec2 { get => elementosec2; set => elementosec2 = value; }
        public string Elementosec3 { get => elementosec3; set => elementosec3 = value; }
        public int Fase { get => fase; set => fase = value; }
        public string Prevmorf { get => prevmorf; set => prevmorf = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Defensa { get => defensa; set => defensa = value; }
        public int Energia { get => energia; set => energia = value; }
        public int Ataque { get => ataque; set => ataque = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Datosextra { get => datosextra; set => datosextra = value; }
        public string Compatibilidad1 { get => compatibilidad1; set => compatibilidad1 = value; }
        public string Compatibilidad2 { get => compatibilidad2; set => compatibilidad2 = value; }
        public string Compatibilidad3 { get => compatibilidad3; set => compatibilidad3 = value; }
        public string Compatibilidad4 { get => compatibilidad4; set => compatibilidad4 = value; }
        public string Compatibilidad5 { get => compatibilidad5; set => compatibilidad5 = value; }
        public string Compatibilidadtext { get => compatibilidadtext; set => compatibilidadtext = value; }
    }
}