<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error_500.aspx.cs" Inherits="P21.Rules.Visual.Error_500" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="error" runat="server">
        <div style ="padding: 15px">
            <div style="text-align: center">
                <div class="errorTitle">500 Error</div>
                <h1>Server error occured</h1>
                <h3><%=Request.Url %></h3>
                <h4>We encountered a server side error trying to load the page.  Please review the logs for the error details.</h4>
            </div>
        </div>
    </form>
</body>
</html>
