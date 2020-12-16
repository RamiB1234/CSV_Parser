# CSV_Parser

## Introduction
A web API app that is built with ASP.NET Core 2.1 MVC that has a HTTP `POST` endpoint to receive a csv file, process it and returns the result in JSON format.

## Features
- Provides an HTTP end-point (POST) which the front-end will consume to provide file
- Parse the content of the CSV file and model it to a list of an object of type `Product.cs`
- Evalute the list and return the top product name and rating in JSON format

## Tech Details
- Project is written in `ASP.NET Core 2.1 MVC` framework. Where I applied `MVC Pattern`. There is no view component since it's an API project
- I implemented unit testing to test the [Evaluate](https://github.com/RamiB1234/CSV_Parser/blob/master/CSV_Parser/Infrastructure/ProductEvaluator.cs) method

## Installation/How to use
- Clone the repository
- Open the `.sln` with `visual studio 2017` or higher with `ASP.NET CORE2.1` framework installed
- Run the project by pressing `CTRL` + `F5`
- Test the API by sending a POST request using [Postman](https://www.postman.com/downloads/) or similar tool
- The test csv should be in a similar structure to [this one](https://github.com/RamiB1234/CSV_Parser/blob/master/CSV_Parser/file.csv)

## CSV file structure

```
id,product_name,customer_avrage_rating
132,"Massoub gift card",5
154,"Kebdah gift card",3.2
12,"Fatayer gift card",1.8
```

## Postman Result
We can see the JSON result after triggering the POST request

![Screen-shot](https://github.com/RamiB1234/CSV_Parser/blob/master/Screenshots%20for%20README/postman.PNG)

## Unit Test Result

![Screen-shot](https://github.com/RamiB1234/CSV_Parser/blob/master/Screenshots%20for%20README/UnitTest.PNG)
