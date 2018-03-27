# NetFlipster

## Your goal

Are you ready to be the new **Netlfix**? Yes?
Si, let's go! But, brace yourself, hackers are comming!

## Constraints

Only the file with the entry point function (the file "Main") can be
modified.

## The app

The app is a simple command-line application.
It relies on a in-memory database.
Note: only the file named "Main" should be edited.


## Use cases

Time to go! As your PO, here are a set of use cases that should be implemented:

### Sign up 

**As** customer  
**I want** register
**In order to** have access to Netflux2

Example of output from command line of your application:
```
Registration ---- 
Name:
tom
Password:
pouce
```

### Sign in

**As** customer  
**I want** login  
**In order to** book movies 

Example:
```
Connection ---
Name:
tom
Password:
pouce
You are connected as tom
```

### List movies

**As** customer  
**I want** list available movies
**In order to** which movies are bookable

Example
```
Films:
H1)	Harry Potter and the Philosopher's Stone 
...
```

### Book movies

**As** customer  
**I want** to book a movie
**In order to** watch it

Example
```
Selection: 
H1
Quantity:
1
Your command of 1 DVD ( Harry Potter and the Philosopher's Stone ) will be sent soon
```

### Display the price of a movie

**As** customer  
**I want** to have access to reductions
**In order to** pay less

**Given** a quantity of DVD
**When** the price is calculated
**Then** a 7€/DVD should be proposed given the user buys one more DVD

Example
```
Number of DVDs : 2, final price : 8€ x 2 DVD = 16€, If you take one more : 7€ * 3 DVD = 21€
```




