Installation Instructions:

* Download solution from github (download zip option):

https://github.com/tthale34/EmployeeManagementASPAngular.git

* Unzip to your local machine
* Open folder : 
.        /EmployeeManagementASPAngular/EmployeeManagementASPAngular
* run the EmployeeManagementASPAngular.sln file
* Delete Migration folder under Solution Explorer
* Change SQL connection string on appsettings.json to your SQLExpress string
* Make sure the following packages are installed:
               packages\microsoft.entityframeworkcore.sqlserver\6.0.32\
               packages\microsoft.entityframeworkcore.tools\6.0.32\
               packages\pomelo.entityframeworkcore.mysql\6.0.3\
               packages\mysql.data\9.0.0\
* From the Menu bar > Build > Build
* Open Package Manager Console
* Run commands: 
            Add-Migration "Comments" -Context "ManagerContext"
            Update-Database -Context "ManagerContext"
            Add-Migration "Comments" -Context "EmployeeContext"
            Update-Database -Context "EmployeeContext"
* Run Project
* Open folder from command line :  
.    /EmployeeManagementASPAngular/EmployeeManangementApp

* Install Node.js (download and run install)
* Install Angular 16 (npm install -g @angular/cli@16)
* Run command : ng serve -o
* Project should open in your browser successfully.
