using System.Xml.Serialization;

namespace MWC.BL
{
	public partial class Speaker : Contracts.BusinessEntityBase
	{
		[XmlAttribute("n")]
		public string Name { get; set; }
		[XmlAttribute("t")]
		public string Title { get; set; }
		[XmlAttribute("c")]
		public string Company { get; set; }
		[XmlAttribute("b")]
		public string Bio { get; set; }

		public Speaker ()
		{
		}
	}
}
