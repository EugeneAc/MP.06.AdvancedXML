<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:x="http://library.by/catalog">

  <xsl:template match="/">
    <html>
      <body>
        <h2>Current fonds by genre</h2>
        <h3>Coumputer</h3>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>Author</th>
            <th>Title</th>
            <th>Publish date</th>
            <th>Registrations date</th>
          </tr>
          <xsl:apply-templates select="/x:catalog/x:book[x:genre='Computer']"/>
          <tr>
            <td>
              Total
            </td>
            <td>
              <xsl:value-of select = "x:GetCounterValue('Computer')"/>
            </td>
          </tr>
        </table>

        <h3>Fantasy</h3>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>Author</th>
            <th>Title</th>
            <th>Publish date</th>
            <th>Registrations date</th>
          </tr>
          <xsl:apply-templates select="/x:catalog/x:book[x:genre='Fantasy']"/>
          <tr>
            <td>
              Total
            </td>
            <td>
              <xsl:value-of select = "x:GetCounterValue('Fantasy')"/>
            </td>
          </tr>
        </table>

        <h3>Romance</h3>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>Author</th>
            <th>Title</th>
            <th>Publish date</th>
            <th>Registrations date</th>
          </tr>
          <xsl:apply-templates select="/x:catalog/x:book[x:genre='Romance']"/>
          <tr>
            <td>
              Total
            </td>
            <td>
              <xsl:value-of select = "x:GetCounterValue('Romance')"/>
            </td>
          </tr>
        </table>

        <h3>Horror</h3>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>Author</th>
            <th>Title</th>
            <th>Publish date</th>
            <th>Registrations date</th>
          </tr>
          <xsl:apply-templates select="/x:catalog/x:book[x:genre='Horror']"/>
          <tr>
            <td>
              Total
            </td>
            <td>
              <xsl:value-of select = "x:GetCounterValue('Horror')"/>
            </td>
          </tr>
        </table>

        <h3>Science Fiction</h3>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th>Author</th>
            <th>Title</th>
            <th>Publish date</th>
            <th>Registrations date</th>
          </tr>
          <xsl:apply-templates select="/x:catalog/x:book[x:genre='Science Fiction']"/>
          <tr>
            <td>
              Total
            </td>
            <td>
              <xsl:value-of select = "x:GetCounterValue('Science Fiction')"/>
            </td>
          </tr>
        </table>
        <h4>
          Total books <xsl:value-of select = "x:GetCounterValue('TotalBooks')"/>
        </h4>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="x:book[x:genre='Computer']">
    <tr>
      <td>
        <xsl:value-of select="x:author"/>
      </td>
      <td>
        <xsl:value-of select="x:title"/>
      </td>
       <td>
        <xsl:value-of select="x:publish_date"/>
      </td>
      <td>
        <xsl:value-of select="x:registration_date"/>
      </td>
    </tr>
    <xsl:value-of select = "x:IncreaseCounter('Computer')"/>
    <xsl:value-of select = "x:IncreaseCounter('TotalBooks')"/>
  </xsl:template>

  <xsl:template match="x:book[x:genre='Fantasy']">
    <tr>
      <td>
        <xsl:value-of select="x:author"/>
      </td>
      <td>
        <xsl:value-of select="x:title"/>
      </td>
      <td>
        <xsl:value-of select="x:publish_date"/>
      </td>
      <td>
        <xsl:value-of select="x:registration_date"/>
      </td>
    </tr>
    <xsl:value-of select = "x:IncreaseCounter('Fantasy')"/>
    <xsl:value-of select = "x:IncreaseCounter('TotalBooks')"/>
  </xsl:template>

  <xsl:template match="x:book[x:genre='Romance']">
    <tr>
      <td>
        <xsl:value-of select="x:author"/>
      </td>
      <td>
        <xsl:value-of select="x:title"/>
      </td>
      <td>
        <xsl:value-of select="x:publish_date"/>
      </td>
      <td>
        <xsl:value-of select="x:registration_date"/>
      </td>
    </tr>
    <xsl:value-of select = "x:IncreaseCounter('Romance')"/>
    <xsl:value-of select = "x:IncreaseCounter('TotalBooks')"/>
  </xsl:template>

  <xsl:template match="x:book[x:genre='Horror']">
    <tr>
      <td>
        <xsl:value-of select="x:author"/>
      </td>
      <td>
        <xsl:value-of select="x:title"/>
      </td>
      <td>
        <xsl:value-of select="x:publish_date"/>
      </td>
      <td>
        <xsl:value-of select="x:registration_date"/>
      </td>
    </tr>
    <xsl:value-of select = "x:IncreaseCounter('Horror')"/>
    <xsl:value-of select = "x:IncreaseCounter('TotalBooks')"/>
  </xsl:template>

  <xsl:template match="x:book[x:genre='Science Fiction']">
    <tr>
      <td>
        <xsl:value-of select="x:author"/>
      </td>
      <td>
        <xsl:value-of select="x:title"/>
      </td>
      <td>
        <xsl:value-of select="x:publish_date"/>
      </td>
      <td>
        <xsl:value-of select="x:registration_date"/>
      </td>
    </tr>
    <xsl:value-of select = "x:IncreaseCounter('Science Fiction')"/>
    <xsl:value-of select = "x:IncreaseCounter('TotalBooks')"/>
  </xsl:template>

</xsl:stylesheet>
