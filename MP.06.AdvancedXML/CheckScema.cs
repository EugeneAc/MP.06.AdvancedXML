using System.Xml;
using System.Xml.Schema;

namespace MP._06.AdvancedXML
{
    public class CheckScema
    {
		private XmlReaderSettings _settings;

		public CheckScema(string xmlSchemaPath, string xmlNameSpace)
		{
			_settings = new XmlReaderSettings();
			_settings.Schemas.Add(xmlNameSpace, xmlSchemaPath);
			_settings.ValidationFlags = _settings.ValidationFlags | XmlSchemaValidationFlags.ReportValidationWarnings;
			_settings.ValidationType = ValidationType.Schema;
		}

		/// <summary>
		/// Finds line number which breakes XML schema
		/// </summary>
		/// <param name="xmlFilePath"></param>
		/// <returns>If bad line found returns line number, else returns 0</returns>
		public int FindBadLine(string xmlFilePath)
		{
			var errorLineNumber = 0;
			_settings.ValidationEventHandler +=
				delegate (object sender, ValidationEventArgs e)
				{
					errorLineNumber = e.Exception.LineNumber;
				};

			XmlReader reader = XmlReader.Create(xmlFilePath, _settings);
			while (reader.Read());
			reader.Close();
			return errorLineNumber;
		}
    }
}
