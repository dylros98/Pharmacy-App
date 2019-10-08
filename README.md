How to set up the MySQL Database
================================

**If you've already got MySQL Server, MySQL for Visual Studio and Connector/NET, skip to step 3**
1. Download the MySQL installer from https://dev.mysql.com/downloads/installer/
2. Run installer and install at least the latest verisons of MySQL Server, MySQL for Visual Studio and Connector/NET
3. If it's not started already, start the MySQL service using the services app
4. In Visual Studio, enable the MySQL toolbar by View -> Toolbars -> MySQL, a dolphin icon should appear in the toolbar
5. Click the icon, go add new connection, input the user id and password you created when you installed MySQL and call the database PharmacyApp
6. If the query window hasn't appeared already, click the icon again which should bring it up, copy and paste the script from DatabaseScript.sql and run it (for first time run, delete the drop database line)
7. Lastly, put in your MySQL user id and password in the connectionstring property in DatabaseContext.cs

