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
		    var badlinenumber = _xmlChecker.FindBadLine(@"..\..\..\MP.06.AdvancedXML\Books.xml");
		    var message = "Test OK";
		    if (badlinenumber != 0)
		    {
		        message = "Bad input xml, line № " + badlinenumber;
		    }

            Assert.IsTrue(badlinenumber == 0, message);
		}

		[TestMethod]
		public void NegativeTestBadISBN()
		{
		    var badlinenumber = _xmlChecker.FindBadLine(@"bookBadIsbn.xml");
            Assert.IsTrue(badlinenumber == 4);
		}

		[TestMethod]
		public void NegativeTestBadGenre()
		{
		    var badlinenumber = _xmlChecker.FindBadLine(@"bookBadGenre.xml");
            Assert.IsTrue(badlinenumber == 7);
		}

	    [TestMethod]
	    public void NegativeTestBadDate()
	    {
	        var badlinenumber = _xmlChecker.FindBadLine(@"booksBadDate.xml");
            Assert.IsTrue(badlinenumber == 9);
	    }

	    [TestMethod]
	    public void NegativeTestBadUniqness()
	    {
            var badlinenumber = _xmlChecker.FindBadLine(@"booksBadUniq.xml");
            Assert.IsTrue(badlinenumber == 17);
	    }
    }
}
