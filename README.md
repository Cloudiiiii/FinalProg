# FinalAPI
 Final project for API class


### How to Run API
Use 
```dotnet run```
in the terminal
Then open postman and use this link http://localhost:5075/api/cars

### How to Use
### Example GET
Make sure it's set to ```GET``` and
Click ```Send``` with this link
http://localhost:5075/api/cars

### Expected Result
```
[
    {
        "id": 1,
        "make": "Dodge",
        "model": "Caravan",
        "year": 2010
    }
]
```

### Example POST
Dpuble check that this link is present http://localhost:5075/api/cars.
Make sure it's set to ```POST``` and then
click the ```Body``` tab under the link. Then select ```raw``` and paste this.


```
{
  "make": "Dodge",
  "model": "Caravan",
  "year": 2010
}
```

### Expected Result
```
{
    "id": 1,
    "make": "Dodge",
    "model": "Caravan",
    "year": 2010
}
```