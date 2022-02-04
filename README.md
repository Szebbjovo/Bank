# Bank

ITS NOT DONE


#Feature
--You can add members by register them
    -Monye take out
    -Money add
    -Delete my account
   
--Admin mod (as an employee)


![loggggdf](https://user-images.githubusercontent.com/78962708/151859909-74420011-fc31-49f3-84a9-a0dddd3b9a85.JPG)



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

-go in the App.c

![Capture](https://user-images.githubusercontent.com/78962708/151858608-c926f3e7-2255-4d56-9b38-3febc7505acf.JPG)


onfig file:

write on the bottm : 

    <connectionStrings>
        <add name="--TYPE THE NAME OF YOUR DATABASE" connectionString="data source=--TYPE YOUR SERVER ADDRESS--; initial catalog=vasbank; integrated security=true"
            providerName="System.Data.SqlClient" />
    </connectionStrings>
    
 ![sql manager](https://user-images.githubusercontent.com/78962708/151858565-b791c20c-574f-4a35-8f29-3eb01ce821e4.JPG)

    
#3. Run the program, first time u have to register users, and after that u can test the other functions

Note: the admin mod can be accesd by typing the "ADMIN" as the username, and "ferko" as the password







