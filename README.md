# Midterm-Calculator

<h2>Background</h2>
To work on this project as a team, it required a lot of communication between the two of us. We worked simultaneously via Zoom often utilizing the remote control function, researched the project with one another, and spoke through our coding. Github was utilized for committing code and having it saved somewhere other than our local machines and to give us the ability to track our changes.
<br>
Here are some of our meetings, and the CSV file is also in this repository:
<br>
![Zoom1](https://github.com/mm2288/Midterm-Calculator/blob/master/zoom1.png?raw=true)
<br>
Github repository with code: https://github.com/Patricio-B/MidtermCalculator/tree/master
<br>
We used three branches: master, patricio, and megan. Each of us worked in our individual branches, and would pull the changes from each other’s branches. Towards the end of the project, we made a mistake when committing, and in turn, used a new repository to show the final project. Welcome!

<h2>Design Patterns and Extras</h2>

<b>Events:</b> We used events to pass around the information the user gave to the calculator. The input is sent to the calculator with these events. 
<br>

https://www.completecsharptutorial.com/basic/c-multicast-delegates-tutorial-with-programming-example.php
<br>
https://www.intertech.com/c-sharp-tutorial-understanding-c-events/
<br>
<b>Event Aggregator:</b> Through our research of events, we found an event aggregator listed quite often. Therefore, we decided to implement it in our calculator, and it essentially allows us to chain our events together. Our EventAggregator.cs file is what displays our calculation, stores user input, and adds/removes the print calculation event. Although we did not utilize the aggregator completely, we were able to use bits and pieces of it to help us.
<br>
https://www.codeproject.com/Articles/866547/Publisher-Subscriber-pattern-with-Event-Delegate-a
<br>
<b>Interfaces:</b> We have several interfaces which manage our methods and classes. ICalculate gets the result from the calculator, ICreate creates the calculation for the user, and IOperation gets the result based on the operation provided from the user through events.
<br>
https://www.youtube.com/watch?v=nW_lpub6Pbw
<br>
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/
<br>
<b>Console Messages:</b> To keep our code following SOLID principles, we have a separate class which holds all the messages to be printed, and the correct method is called where it is needed in the code.
<br>
<b>Data Dictionary Mapping:</b> We used a dictionary to hold data pertaining to the operations, as it’s static and could be accessed easily. We mapped each option the user is given for an input (1. Addition, 2. Subtraction, etc.) and linked it to the operations class. We then check if the user’s input is the key (the number) and if so, we do the operation it is linked to. If not, we let the user know the input is incorrect and to try again. When we spoke about messages in class, we looked into it further, and found this method would work for us. It was mentioned in the Event Aggregator article, and we also used this resource:
<br>https://www.dotnetperls.com/dictionary
