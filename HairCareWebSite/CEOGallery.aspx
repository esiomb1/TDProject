<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CEOGallery.aspx.cs" Inherits="CEOGallery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The CEO Gallery</title>
</head>
<body>
    <h1> All of my work up to date</h1>

    <p> Half up Half down sew in</p>
    <img src="H:\TDProject-master\halfuphalfdown.jpg"alt="Client with a half up half down hairstyle"
        style="width:250px;height:250px;" />

    <p>The blonde one</p>
    <img src ="H:\TDProject-master\blonde.jpg" alt="Client with a blonde frontal wig installation"
        style="width:250px;height:250px;" />

    <p> A detailed tutorial on how to ahcieve this wig
        <video width="420" height="345" controls>
        <source src="tutorial.mov" type="video/mov">
        </video>

    </p>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
