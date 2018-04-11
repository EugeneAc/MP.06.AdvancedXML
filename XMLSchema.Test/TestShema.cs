using Microsoft.VisualStudio.TestTools.UnitTesting;
using MP._06.AdvancedXML;

namespace XMLSchema.Test
{
	[TestClass]
	public class TestShema
	{
		private CheckScema _xmlChecker;

		[TestInitialize]
		public void Init()
		{
			_xmlChecker = new CheckScema(@"..\..\..\MP.06.AdvancedXML\Books.xsd", "http://library.by/catalog");
		}

		[TestMethod]
		public void PositiveTestSchema()
		{
			Assert.IsTrue(_xmlChecker.FindBadLine(@"..\..\..\MP.06.AdvancedXML\Books.xml")==0);
		}

		[TestMethod]
		public void NegativeTestBadISBN()
		{
			Assert.IsTrue(_xmlChecker.FindBadLine(@"bookBadIsbn.xml") == 4);
		}

		[TestMethod]
		public void NegativeTestBadGenre()
		{
			Assert.IsTrue(_xmlChecker.FindBadLine(@"bookBadGenre.xml") == 7);
		}
	}
}
