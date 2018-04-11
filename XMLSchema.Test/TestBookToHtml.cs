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
	public class TestBookHtml
	{
		HtmlBuilder _builder;

		[TestInitialize]
		public void Init()
		{
			_builder = new HtmlBuilder(@"..\..\..\MP.06.AdvancedXML\BooksToHtml.xslt", @"http://library.by/catalog");
		}

		[TestMethod]
		public void TestTransfromer()
		{
			_builder.BuildHtml(@"..\..\..\MP.06.AdvancedXML\books.xml", "Report.html");
			Assert.IsTrue(File.Exists("Report.html"));
		}
	}
}
