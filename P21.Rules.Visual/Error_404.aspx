<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error_404.aspx.cs" Inherits="P21.Rules.Visual.Error_404" %>

<%
    //var logger = new LoggingService(ConfigurationContext.Current, new HttpLogMessageFormatter());
    //logger.SetLoggerName("Page404");

    var url = HttpUtility.HtmlEncode(Request.Url.AbsoluteUri);
    //logger.Error("Page not found: {0}", url);
%>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />

    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="error404" runat="server">
        <div style ="padding: 15px">
            <div style="text-align: center">
                <div class="errorTitle">404 Error</div>
                <h1>Page not found</h1>
                <h3><%=Request.Url %></h3>
                <h4>The page you are looking for does not exist.  Please check the URL and try again.</h4>
            </div>
        </div>
    </form>
</body>
</html>
