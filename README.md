# Interstellar-Energy-Payment-Portal
###Link to live site:  http://interstellarfinancingportal.apphb.com/
 
<img src=”~/Screenshots/HomeScreen”></img>

####Also see the repository for the Interstellar Financing API: https://github.com/ChrisGrindereng/Intersteller-Financing-API

###Technologies
- C# ASP.Net MVC, Razor Views, Bootstrap, jQuery, CSS, Html, JSON RESTful API, SQL server

###Use
- This site is intended to be an example of a payment/financing portal to provide users access to instant financing approvals for energy systems, such as solar.
- Users are guided through the site making the process of imputing information, selecting options, submitting approval simple to use. 
- The send data from the user as a Http Post request to a separate backend application the Interstellar Financing API which performs calculations using an algorithm to return an approval status to the Interstellar financing portal.
<img src=”~/Screenshots/ProjectOverviewScreen”></img>

###Challenges 
- The main challenge of this application came down to data modeling. With site containing 10 different views, 2 separate forms, and 2 different object selections the application required extensive data modeling to keep all this information well organized and as modular as possible.  
- I ultimately separated models into 3 categories: database models for the site, models for the API call and view models. This structure allowed me to effectively store the information I needed while easily manipulate view data and send up the API call. 
<img src=”~/Screenshots/DataStructureScreen”></img>

###Tools 
- Newtonsoft.Json was a key to serializing and de-serializing JSON for the API call and response to the Financing API. 
<img src=”~/Screenshots/NewtonsoftScreen”></img>
- Using async methods was also imperative to correctly make that call to the API.
<img src=”~/Screenshots/AsyncJSONScreen”></img>

###Minimum Viable Product (Version 1)
 - User Log In with email. 
 - Dashboard Layout will allow for easy navigation.
 - User will fill out form providing information.
 - User will be given multiple system and installation options to choose from. 
 - User will choose financing options including selecting down payment amount as well as monthly payment amounts.
 - Once user selects all options they will submit approval for financing from Interstellar Lender. 
 - After this information has been submitted the user will receive an approval status and be prompted to continue. 

###Contributions to be added (for Version2)
- Adding greater complexity to the financing model. This will allow for increasing the number of options on the final financing form and allow the user to further tailor their financing options.  
<img src=”~/Screenshots/ProjectFinancingScreen”></img>
