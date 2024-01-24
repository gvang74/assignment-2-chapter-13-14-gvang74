[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/Qm1bV9T_)


Chapter_14_Introduction to LINQ_Language-Integrated Query(LINQ)
CPT_206_A80S

###:)
****************************************************************************************
LINQ-Query language built into C#. 
Used to query data from many other sources.

LINQ to OBJECTS - allows query data that are stored in collections; arrays and lists.
LINQ queries begin with a "from" clause; and usually end with a "select" clause
LINQ query can use either query sytax or method syntax.

LINQ query statement //(format): 
    var resultVariable = LINQquery;
        resultVariable - is a veriable 
        //(declaring to hold the results of the LINQ query).

Array to get "Values" statement //(greater then):
    var results = from item in numbers
                  where item > 100
                  select item;

foreach (loop) statement:
    foreach(item in numbers)
    //item is the name of an variable
    //number is the name of an arry

  Adding the values to a list box (after code executes):
      int[] numbers = { 4, 104, 2, 102 };
      var results = from item in numbers
      where item > 100
      select item;

  LINQ to query the data in a LIST:
      List<int> numbers = new List<int>() { 4, 104, 2, 102 };
      var results = from item in numbers
      where item > 100
      select item;
    foreach (var value in results)
    {
        resultsListBox.Item.Add(value);
    }

 LINQ queries returnresults as an IEnumberable<T>collection:
     IEnumberable<T> is an interface that defined in the .NET Frameowrk.

String Array:
    string [] names = {  ,   ,  ,  };
      var results = from item in names
      where String.Compare(item, "   ") < 0
      select item;
  foreach (var value in results)
      {
          MessageBoxShow(value);
      }

  Contact Class (stores name and number)
  //properties

  ____________________________________________________________________________________________________________
  In Tutorial 14-1...Completing the Student Roster Application

    Click displayAllButton for all student names to be displayed in the ListBox. 
    There's also searchTextBox with a searchButton (click).
    Click Exit to close program.

    In Design view (Form1):
      -searchTextBox
      -searchButton
      -studentListBox
      -displayAllButton
      -exitButton

  In Designer view: (The Student Class)

    -class student
      //properies
      //constructor 

  Complete Form1 code for Student Roster Application:

    -class Form1: Form
      List<Student> students = New List<Students>()
      {
          new Student ("     ", "      ");
          new Student ("     ", "      ");
          new Student ("     ", "      ");
      };


-OrderBy and OrderByDescending Methods
-Where Method
-Select Method
________________________________________________________________________________________________________________
In Tutorial 14-4...Completing the Phonelist Names Application'

*LINQ quert retieve all the names in the person table' display in ListBox*

Connect database
Creat LINQ to SQL classes
Write code to iterates over a table in the database

-PersonListBox
-CloseButton

-Add New Item to creat LINQ to SQL Classes
  -Object Relational Designer 
    -Person Class created in the Object Relational Designer
-Code program in Form1
  Create a data context object
      PhonelistDataContext db = new PhonelistDatContext();
  Code to "display" all name in ListBox
      foreach (Person intem in db.Persons)

 db. = PhonelistDataContext (statement) represents the database

 
