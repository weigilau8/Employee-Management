Creating a CRUD project using Visual Studio Mac
Used MySQL as Database

-> Install Visual Studio Mac 2022 v17.6.14
Got it from here
https://download.macupdate.com/app/mac/59553/visual-studio/download

-> Install MySQL
Got it from here MySQL version 8.0.41 armm for Apple Silicon
https://dev.mysql.com/downloads/mysql/8.0.html

-> Install dotnet
Got it from here
https://dotnet.microsoft.com/en-us/download

Since Visual Studio mac and windows have difference, 
i applied Manual application on installing Dependencies and it only uses dot net 8.
not supported on dot net 9

Once you create a "New Project"
install this on your Project via terminal

This package is to connect for the Mysql
-> dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.0

-> dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.0
-> dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0

