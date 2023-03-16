using System.Xml; //Por padrão já temos essa LIB.
//Necessário instalação da lib.
using Newtonsoft.Json; //dotnet add package Newtonsoft.Json

namespace ConvertXml //Namespace a ser importado para o arquivo principal.
{
	///Retorna string convertida em Json.
	class ConvertToJson{
		public string? JsonConvertido;
		public void ConvertXmlForJson()
		{
			System.IO.File.WriteAllText("NewArquivo.json", this.JsonConvertido);
		}
		public ConvertToJson(string stringNameArchive){
			//Instânciar a classe do System.Xml
			XmlDocument pegaXml = new XmlDocument(); //lib de manipular Xml
			pegaXml.Load(stringNameArchive); //método load para carregar o arquivo xml. Esse método não retorna valor apenas carrega o XML.
			string json = JsonConvert.SerializeXmlNode(pegaXml); //converte o XML em Json.
			this.JsonConvertido = json; //Função retorna o valor do json. Ja dentro da propriedade.
		}
	}

}