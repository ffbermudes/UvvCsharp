//Função do código é carregar em uma variável o conteúdo do XML. assim posso trabalhar no mesmo.


using System.Xml.Serialization;
using XmlTransformer;
namespace ProgramaPrincipal{
	class ClassProgramaPrincipal{
		public static void Main(string [] args){
			var serializer = new XmlSerializer(typeof(Biblioteca));
			using (var reader = new StreamReader("biblioteca.xml"))
			{
				var biblioteca = (Biblioteca)serializer.Deserialize(reader);
			Console.WriteLine(biblioteca.livro[1].autor);
			}
		}
	}
}