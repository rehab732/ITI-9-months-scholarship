<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:fo="http://www.w3.org/1999/XSL/Format">
<xsl:template match="books">
<h2>Review = 3.5 : <xsl:value-of select="count(book[review = 3.5])" /> </h2>
<h2>Review = 4 : <xsl:value-of select="count(book[review = 4])" /> </h2>
</xsl:template>
</xsl:stylesheet>
