using System.Xml.Serialization;

namespace XmlTransformer
{

	// A biblioteca Serializable

	[Serializable]
	[XmlRoot("biblioteca")] // TAG PAI. Não tem conteúdo.
	public class Biblioteca
	{
		[XmlElement("livro")]
		public Livro []? livro {get; set;}
	}
	public class Livro  // TAG LIVRO. Possui conteúdo. livro, autor, ano.
	{
		[XmlElement("titulo")] //conteúdo 1.
		public string? titulo { get; set; }

		[XmlElement("autor")] //conteúdo 2.
		public string? autor { get; set; }

		[XmlElement("ano")] //conteúdo 3.
		public int? ano { get; set; }
	}

}