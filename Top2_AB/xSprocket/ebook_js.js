<!--
// Handle all the FSCommand messages in a Flash movie.
function querystring_DoFSCommand(command, args) {
	var querystringObj = isInternetExplorer ? document.all.querystring : document.querystring;
	//
	// Place your code here.
	//
}

var browserName=navigator.appName; 
var resizable = true;
var isMacIE = false;
if (browserName=="Microsoft Internet Explorer") { 
	if (navigator.appVersion.indexOf("Mac")!=-1) {
	//alert("IE Mac");
		isMacIE = true;
	} else {
		//alert("IE Win");
	}
} else if (browserName=="Netscape" && navigator.appVersion.indexOf("Win")!=-1) { 
	//alert("Netscape Win");
} else { 
	//alert("All other browsers");
}

if (!isMacIE) {
	document.write("<style>	body, html { height: 100% }</style>");
}


function openQT(mName, mW, mH) {
	if (mW == null){
		mW = 320;
	}
	if (mH == null){
		mH = 256;
	}
	newWindowqt = window.open("", "","toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbars=no, resizable=yes, width=" + mW + ", height=" + mH + ";"); 
	newWindowqt.document.write('<html><head><title>quicktimemovie<\/title><\/head><body bgcolor="#000000" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0"><embed src="' + mName + '" width="100%" height="100%" ');
	newWindowqt.document.write('bgcolor="000000" pluginspage="http://www.apple.com/quicktime/download/" ');
	newWindowqt.document.write('autoplay="true" controller="true" ');
	newWindowqt.document.write('scale="aspect"></embed><\/body><\/html>');
}


function getQueryValue(name) {
  var value = "";
  if ( (i=location.search.indexOf('?'+name))==-1 && (i=location.search.indexOf('&'+name,3))==-1 )
    return null;
  else
    i += name.length+2;
  if ( (j=location.search.indexOf("&",i))!=-1 )
    value = location.search.substring(i,j);
  else
    value = location.search.substring(i,location.search.length);
  for ( i=0; i<value.length; i++ )
    if ( value.charAt(i)=='+' )
     value = value.substring(0,i)+' '+value.substring(i+1,value.length);
  return unescape(value);
}
// Hook for Internet Explorer.
if (navigator.appName && navigator.appName.indexOf("Microsoft") != -1 && navigator.userAgent.indexOf("Windows") != -1 && navigator.userAgent.indexOf("Windows 3.1") == -1) {
	document.write('<script language=\"VBScript\"\>\n');
	document.write('On Error Resume Next\n');
	document.write('Sub querystring_FSCommand(ByVal command, ByVal args)\n');
	document.write('	Call querystring_DoFSCommand(command, args)\n');
	document.write('End Sub\n');
	document.write('</script\>\n');
}
function getHTMLName() {
	var s = location.pathname.split('/');
	return s[s.length-1];
}


var popUpWin=0;
function popUpWindow(URLStr, left, top, width, height, resizable) {
  if (popUpWin) {
    if(!popUpWin.closed) popUpWin.close();
  }
	if (isMacIE) {
		width -= 16;
		height -= 16;
	}
  popUpWin = open(URLStr, '_blank','toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbar=no,resizable,copyhistory=yes,width='+width+',height='+height+',left='+left+',top='+top+',screenX='+left+',screenY='+top+'');
}
function isMacIE () {
	return (navigator.platform.indexOf("Mac") != -1 && document.all); 
} // --> 
function doThePopup(htmlpage) {
	popUpWindow(htmlpage+"?chapter="+getQueryValue("chapter")+"&page="+getQueryValue("page")+"&anchory="+getQueryValue("anchory"),25,25,960,720,1);
}
function gotoPage(htmlpage,p,x,y) {
	if (htmlpage == '') {
		htmlpage = getHTMLName();	
	}
	popUpWindow(htmlpage+"?page="+p+"&anchorx="+x+"&anchory="+y,25,25,960,720,1);
}
function gotoPage_newpopup(htmlpage,p,x,y,w,h) {
	if (htmlpage == '') {
		htmlpage = getHTMLName();	
	}
	popUpWindow(htmlpage+"?page="+p+"&anchorx="+x+"&anchory="+y,25,25,w,h,1);
}



-->