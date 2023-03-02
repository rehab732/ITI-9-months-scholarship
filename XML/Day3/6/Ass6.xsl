<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
<xsl:template match="CATALOG">
<h1>MY CD COLLECTION</h1>
<table border="2">
	<tbody>
		<tr bgcolor="blue">
			<th>TITLE</th>
			<th>Artist</th>
		</tr>
		<xsl:for-each select="CD">
			<xsl:choose>
				<xsl:when test="PRICE &gt; 10">
				<tr>
					<td><xsl:value-of select="TITLE"/></td>
					<td style="background-color:red"><xsl:value-of select="ARTIST"/></td>
				</tr>
				
				</xsl:when>
				<xsl:otherwise>
				<tr>
					<td><xsl:value-of select="TITLE"/></td>
					<td style="background-color:green"><xsl:value-of select="ARTIST"/></td>
				</tr>
				</xsl:otherwise>
			</xsl:choose>
		
		
		   
		</xsl:for-each>
	</tbody>
</table>
</xsl:template>
</xsl:stylesheet>
