using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace MP._06.AdvancedXML
{
	public class BookToRssTransformer
	{
		private XslCompiledTransform _xsl;
		public BookToRssTransformer(string xsltFilePath)
		{
			_xsl = new XslCompiledTransform();
			var settings = new XsltSettings { EnableScript = true };
			_xsl.Load(xsltFilePath, settings, null);
		}

		public void TransformXmlFile (string xmlFilePath, string outFilePath)
		{
		    using (StreamWriter writer = File.CreateText(outFilePath))
		    {
		        _xsl.Transform(xmlFilePath, null, writer);
            }
		}
	}
}
