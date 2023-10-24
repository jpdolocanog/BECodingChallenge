# BE Coding Challenge by Jayride: API for Candidate Information, Location Data and Listings
by John Paul Dolocanog

## Overview
This is a WEB API that provides three main functionalities:

1. **Candidate Information**:
   - **Endpoint**: `/candidate`
   - Returns candidate information:
      ```json
      { 
        "name": "test", 
        "phone": "test" 
      } 

2. **Location Data**:
   - **Endpoint**: `/Location`
   - Takes an IP address as input and returns the corresponding city location.
   - Utilizes a free IP/Location API [ipstack](https://ipstack.com/product).

3. **Listings Filter**:
   - **Endpoint**: `/Listings`
   - Takes the number of passengers as a parameter.
   - Calls an external search endpoint from [Jayride](https://jayridechallengeapi.azurewebsites.net/api/QuoteRequest) to get listing data.
   - Filters listings based on passenger support and calculates the total price.
   - Returns the filtered and sorted results by total price.
  
## Usage
How to use the API:

### Task 1: Candidate Information
- **Endpoint**: `/candidate`
- Send a GET request to this endpoint to receive the candidate information.
- Example Request:
  ```http
  GET http://localhost:5258/candidate
   ```

### Task 2: Location Data
- **Endpoint**: `/Location`
- Send a GET request to /Location with an IP address as a query parameter.
- Example Request:
  ```http
  GET http://localhost:5258/Location?ipAddress=158.62.55.63
   ```

### Task 3: Listings Filter
- **Endpoint**: `/Listings`
- Send a GET request to /Listings with the number of passengers as a query parameter.
- Example Request:
  ```http
  GET http://localhost:5258/Listings?passengerCount=2
   ```
