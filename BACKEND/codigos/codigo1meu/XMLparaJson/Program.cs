using ConvertXml;

namespace ProgramaPrincipal
{
	class ClassePrincipal{
		public static void Main(string [] args){
			ConvertToJson XmlToJson = new ConvertToJson("Biblioteca.xml");
			XmlToJson.ConvertXmlForJson();
		}
	}
}