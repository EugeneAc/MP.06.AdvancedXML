using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP._06.AdvancedXML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLSchema.Test
{
	[TestClass]
	public class TestBookToRssTransformer
	{
		BookToRssTransformer _transformer;
		private CheckScema _xmlChecker;
		[TestInitialize]
		public void Init()
		{
			_transformer = new BookToRssTransformer(@"..\..\..\MP.06.AdvancedXML\BooksToRss.xslt");
			_xmlChecker = new CheckScema(@"..\..\..\MP.06.AdvancedXML\RssSchema.xsd", "http://www.rssboard.org/rss-specification");
		}

		[TestMethod]
		public void PositiveTestTransfromer()
		{
			_transformer.TransformXmlFile(@"..\..\..\MP.06.AdvancedXML\book.xml", "rss.xml");
			Assert.IsTrue(File.Exists("rss.xml"));
			Assert.IsTrue(_xmlChecker.FindBadLine(@"rss.xml") == 0);
		}

		[TestMethod]
		public void TestTransformerLinkGenereation()
		{
			_transformer.TransformXmlFile(@"..\..\..\MP.06.AdvancedXML\book.xml", "rss.xml");
			Assert.IsTrue(File.Exists("rss.xml"));
			Assert.IsTrue(_xmlChecker.FindBadLine(@"rss.xml") == 0);
			using (XmlReader reader = XmlReader.Create("rss.xml"))
			{
				while (reader.Read())
				{
					if (reader.Name=="link")
					{
						reader.Read(); // go to element value
						Assert.IsTrue(reader.Value.StartsWith(@"http://my.safaribooksonline.com/"));
						reader.Read(); // exit element
					}
				}
			}
		}

		[TestCleanup]
		public void Cleanup()
		{
			if (File.Exists("rss.xml"))
				File.Delete("rss.xml");
		}
	}
}
