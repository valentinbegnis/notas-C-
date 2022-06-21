using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Delegados_Sort_Tasks
{
	public class Program
	{
		public delegate int DelegadoOrdenar(string tituloUno, string tituloDos);

		public static void Main()
		{
			DelegadoOrdenar delegadoOrdenar = OrdenarAlfabeticamente;

			List<Libro> listaLibros = new List<Libro>()
			{
				new Libro("El color que cayo del cielo", "HP Lovecraft", 3200),
				new Libro("Operacion Masacre", "Rodolfo Walsh", 2300),
				new Libro("La metamorfosis", "Franz Kafka", 1200),
				new Libro("Dracula", "Bram Stoker", 2000)
			};

			MostrarLibros(); // Muestro libros sin ordenar

			Task tarea = Task.Run(() => {
				Thread.Sleep(3000); // Simulo que el ordenamiento se demora 3 segundos

				listaLibros.Sort((x, y) => delegadoOrdenar(x.Titulo, y.Titulo));
			});

			tarea.Wait();

			MostrarLibros(); // Muestro libros ordenados

			void MostrarLibros()
			{
				foreach (Libro libro in listaLibros)
				{
					Console.WriteLine(libro.Titulo);
				}
				Console.WriteLine("----------------------");
			}

			// metodo que voy a usar como criterio de ordenamiento
			// podria usar cualquier otro que tenga la misma firma y tipo de retorno que DelegadoOrdenar
			int OrdenarAlfabeticamente(string tituloUno, string tituloDos)
			{
				return string.Compare(tituloUno, tituloDos);
			}
		}
	}

	public class Libro
	{
		private string titulo;
		private string autor;
		private float precio;

		public string Titulo { get => this.titulo; }
		public string Autor { get => this.autor; }
		public float Precio { get => this.precio; }

		public Libro(string titulo, string autor, float precio)
		{
			this.titulo = titulo;
			this.autor = autor;
			this.precio = precio;
		}
	}
}
