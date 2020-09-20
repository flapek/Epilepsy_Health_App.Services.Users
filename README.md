# Epilepsy_Health_App.Services.Users

## What is Epilepsy_Health_App.Services.Users?

Epilepsy_Health_App.Services.Users is the microservice being part of [Epilepsy_Health_App](https://github.com/flapek/Epilepsy_Health_App) solution.

Branch             |Build status                                                  
|-------------------|-----------------------------------------------------
|master             |[![Build Status](https://travis-ci.org/flapek/Epilepsy_Health_App.Services.Users.svg?branch=master)](https://travis-ci.org/flapek/Epilepsy_Health_App.Services.Users)
|develop            |[![Build Status](https://travis-ci.org/flapek/Epilepsy_Health_App.Services.Users.svg?branch=develop)](https://travis-ci.org/flapek/Epilepsy_Health_App.Services.Users)

## How to start the application?

Service can be started locally via `dotnet run` command (executed in the `/src/Epilepsy_Health_App.Services.Users.Api` directory) or by running `./Scripts/start.sh` shell script in the root folder of repository.

By default, the service will be available under http://localhost:5002 and https://localhost:6002.

You can also start the service via Docker, either by building a local Dockerfile: 

`docker build -t epilepsy_health_app.services.Users .` 

## What HTTP requests can be sent to the microservice API?

You can find the list of all HTTP requests in [Epilepsy_Health_App.Services.Users.rest](https://github.com/flapek/Epilepsy_Health_App.Services.Users/blob/master/Epilepsy_Health_App.Services.Users.rest) file placed in the root folder of the repository.
This file is compatible with [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) plugin for [Visual Studio Code](https://code.visualstudio.com). 