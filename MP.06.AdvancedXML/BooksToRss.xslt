<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:x="http://library.by/catalog"
                xmlns="http://www.rssboard.org/rss-specification"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt"
                xmlns:user="urn:my-scripts"
                exclude-result-prefixes="x"
                version="1.0">

  <msxsl:script implements-prefix='user' language='CSharp'>
    <![CDATA[  
    public string BuildLink(string genre, string isbn) 
    {
    if (genre == "Computer" && !String.IsNullOrEmpty(isbn))
      return @"http://my.safaribooksonline.com/" + isbn.Replace("-","") ;
    return "";
    }]]>  
  </msxsl:script>

  <xsl:template match="/">
    <rss version="2.0">
      <xsl:text>&#xa;</xsl:text>
      <channel>
        <xsl:text>&#xa;</xsl:text>
        <title>My book catalog RSS</title>
        <xsl:text>&#xa;</xsl:text>
        <link>http://library.by/catalog</link>
        <xsl:text>&#xa;</xsl:text>
        <description>New books announced</description>
        <xsl:text>&#xa;</xsl:text>
        <xsl:apply-templates />
        <xsl:text>&#xa;</xsl:text>
      </channel>
    </rss>
    <xsl:text>&#xa;</xsl:text>
  </xsl:template>

  <xsl:template match="x:book">
    <item>
      <xsl:text>&#xa;</xsl:text>
      <title>
        <xsl:value-of select="x:title"/>
      </title>
      <link>
        <xsl:variable name="genre" select="x:genre" />
        <xsl:variable name="isbn" select="x:isbn" />
        <xsl:value-of select="user:BuildLink($genre, $isbn)"/>
      </link>
      <xsl:text>&#xa;</xsl:text>
      <description>
        <xsl:value-of select="x:description"/>
      </description>
      <xsl:text>&#xa;</xsl:text>
      
    </item>
  </xsl:template>
</xsl:stylesheet>