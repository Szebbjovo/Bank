# Bank
!! this is a school project, and feel fre to inspitare from it !!

#Setup

#1. First thing to do, u have to install the sql server

Dowloand and install , the official microsoft tools:
SQL manager studio:
https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15
https://www.microsoft.com/en-us/sql-server/sql-server-downloads

#2. Create the project in visual studio and install the nugget package and enable the migration:

1.create a project including the Entity Framework(not the core version)
type in to the package console: 
PM> install-EntityFramework

and enable the migrations
PM> enable-migrations

#2. setup the connection string

-go in the App.config file:

write on the bottm : 

    <connectionStrings>
        <add name="--TYPE THE NAME OF YOUR DATABASE" connectionString="data source=--TYPE YOUR SERVER ADDRESS--; initial catalog=vasbank; integrated security=true"
            providerName="System.Data.SqlClient" />
    </connectionStrings>
    
#3. Run the program, first time u have to register users, and after that u can test the other functions

Note: the admin mod can be accesd by typing the "ADMIN" as the username, and "ferko" as the password


Hope you find intresting my work, and wish me luck to get a good grad :)))
