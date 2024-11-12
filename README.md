This is a .Net server app, which enables the user to make virtual stock trades and track their value.
The project requires a connection string to a database, I am currently hosting in Azure App Service and using an Azure SQL database.
The API being used is the RapidAPI twelvedata quote API:
https://rapidapi.com/twelve-data1-twelve-data-default/api/twelve-data1/playground/apiendpoint_2d125704-6e3e-4be1-a561-70705e199ef7.
To get the quote service working, you will need to subscribe to the API (free option available) and enter the host and API Key as environment variables.
