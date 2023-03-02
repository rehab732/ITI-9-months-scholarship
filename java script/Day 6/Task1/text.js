/*
Need to implement all functions to apply its output on the paragraph 
*/


//change font
function ChangeFont(fontname) {
    document.getElementById("PAR").style.fontFamily = fontname;
}
//text alignment
function ChangeAlign(direction) {
    document.getElementById("PAR").style.textAlign = direction;

}
//Change line Height
function ChangeHeight(hight) {
    document.getElementById("PAR").style.lineHeight = hight;
}

//Change Letter Space
function ChangeLSpace(letterspace) {
    document.getElementById("PAR").style.letterSpacing = letterspace;

}
//Change Indent
function ChangeIndent(textn)
{
    document.getElementById("PAR").style.textIndent=textn;
}
//Change Transform
function ChangeTransform(transtype)
{
    document.getElementById("PAR").style.textTransform=transtype;

}
//Change Decoration
function ChangeDecorate(deco)
{
    document.getElementById("PAR").style.textDecoration=deco;
}
//Change Border
function ChangeBorder(border)
{
    document.getElementById("PAR").style.borderStyle=border;
}
//Change Border Color
function ChangeBorderColor(color)
{
    document.getElementById("PAR").style.borderColor=color;
}