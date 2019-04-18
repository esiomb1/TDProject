<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
* {
  box-sizing: border-box;
}

body {
  font-family: Arial, Helvetica, sans-serif;
}

/* Style the header */
header {
  background-color: hotpink;
  padding: 30px;
  text-align: center;
  font-size: 35px;
  color: white;
}

/* Container for flexboxes */
section {
  display: -webkit-flex;
  display: flex;
}

/* Style the navigation menu */
nav {
  -webkit-flex: 1;
  -ms-flex: 1;
  flex: 1;
  background: pink;
  padding: 20px;
}

/* Style the list inside the menu */
nav ul {
  list-style-type: none;
  padding: 0;
}

/* Style the content */
article {
  -webkit-flex: 3;
  -ms-flex: 3;
  flex: 3;
  background-color: #f1f1f1;
  padding: 10px;
}



/* Responsive layout - makes the menu and the content (inside the section) sit on top of each other instead of next to each other */
    @media (max-width: 600px) {
        section {
            -webkit-flex-direction: column;
            flex-direction: column;
        }

        h2 {
            color: pink;
            text-align: center;
        }
    }
</style>
</head>
<body>





<header>
  <h2>CEOHAIRUK</h2>
</header>
    
<section>
  <nav>
    <ul>
      <li><a href="MainPage.aspx">Home</a></li>
      <li><a href="CEOGallery.aspx">CEOGallery</a></li>
      <li><a href="AppointmentPage.aspx">AppointmentPage</a></li>
      <li><a href="Login.aspx">Login</a></li>
      <li><a href="SignUp.aspx">SignUp</a></li>
    </ul>
  </nav>
  
 

<footer>
  <p>Footer</p>
</footer>

      

</body>
</html>


</head>
<body>
    
        <div>
        </div>
    </form>
</body>
</html>
