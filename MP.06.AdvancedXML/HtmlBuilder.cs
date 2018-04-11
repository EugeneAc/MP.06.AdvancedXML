using System.IO;
using System.Xml.Xsl;

namespace MP._06.AdvancedXML
{
	public class HtmlBuilder
	{
		private XslCompiledTransform _xsl;
		private XsltArgumentList _args;

		public HtmlBuilder(string xsltFilePath, string nameSpace)
		{
			_xsl = new XslCompiledTransform();
			_args = new XsltArgumentList();
			_args.AddExtensionObject(nameSpace, new Counters());
			_xsl.Load(xsltFilePath);
		}

		public void BuildHtml(string xmlFilePath, string outFilePath)
		{
			StreamWriter writer = File.CreateText(outFilePath);
			_xsl.Transform(xmlFilePath, _args, writer);
			writer.Close();
		}
	}
}
