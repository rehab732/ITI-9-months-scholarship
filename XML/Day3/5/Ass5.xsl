<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">

<xsl:template match="CATALOG">
 <h1>MY CD COLLECTION</h1>
 <table border="2">
		<tbody>
			<tr bgcolor="green">
				<th>TITLE</th>
				<th>Artist</th>
				<th>Price</th>
			</tr>
			<xsl:for-each select="CD">
			<xsl:sort select="PRICE" order="descending" data-type="number"/>
		
		<tr>
			
		    <td ><xsl:value-of select="TITLE"/></td>
		    <td ><xsl:value-of select="ARTIST"/></td>
		    <td><xsl:value-of select="PRICE"/></td>
		    
		</tr>
		
		   
		</xsl:for-each>
		</tbody>
	</table>
</xsl:template>
</xsl:stylesheet>
