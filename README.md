# FinalAPI

## Project Overview
FinalAPI is the capstone project for the API class. This project demonstrates how to build and interact with a simple RESTful API using ASP.NET Core. The API allows users to manage a collection of cars, supporting basic CRUD (Create, Read, Update, Delete) operations.

## Table of Contents
- [Prerequisites](#prerequisites)
- [How to Run](#how-to-run)
- [API Usage](#api-usage)
  - [GET Request](#get-request)
  - [POST Request](#post-request)
- [License](#license)
- [Issue Tracker](#issue-tracker)

## Prerequisites
Ensure you have the following installed:
- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Postman](https://www.postman.com/) or any tool to test HTTP requests

## How to Run
1. Clone this repository:
   ```bash
   git clone https://github.com/Cloudiiiii/FinalProg.git
   cd FinalProg
   ```
2. Run the API:
   ```bash
   dotnet run
   ```
3. The API will be accessible at:
   ```
   http://localhost:5075/api/cars
   ```

## API Usage

### GET Request
Retrieve a list of all cars:
- **Method:** `GET`
- **Endpoint:** `http://localhost:5075/api/cars`

**Example Response:**
```json
[
    {
        "id": 1,
        "make": "Dodge",
        "model": "Caravan",
        "year": 2010
    }
]
```

### POST Request
Add a new car:
- **Method:** `POST`
- **Endpoint:** `http://localhost:5075/api/cars`
- **Body (raw, JSON format):**
```json
{
  "make": "Dodge",
  "model": "Caravan",
  "year": 2010
}
```

**Example Response:**
```json
{
    "id": 1,
    "make": "Dodge",
    "model": "Caravan",
    "year": 2010
}
```

## License
This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). I chose this license because it allows others to freely use, modify, and distribute the code while requiring attribution and disallowing liability.

## Issue Tracker
Found a bug or have a feature request? Please submit an issue through the [GitHub Issues page](https://github.com/Cloudiiiii/FinalProg/issues).
