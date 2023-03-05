using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
      class Program
    {
        static void Main(string[] args)
        {


// put GetGuest function into a variable
//call it
var guests = GetGuests();

//make a dictionary of the tables 
var tables = new Dictionary<string, List<Guest>>() 
{
    {"TABLE 1", new List<Guest>() },
    {"TABLE 2", new List<Guest>() },
};

//iterate through guests with a foreach loop

foreach(var guest in guests){
    //make a variable for table one occ
    var Table1Occupations = tables["TABLE 1"].Select(g => g.Occupation).ToList();
    //conditional logic, if table 1 occ contains current occupation add it two table two
    if(Table1Occupations.Contains(guest.Occupation))
    {
        tables["TABLE 2"].Add(guest);
    }
    //else add it to table 1
    else {
        tables["TABLE 1"].Add(guest);
    }
}





 static List<Guest> GetGuests()
 {
    return new List<Guest>()
  {
    new Guest
    {
      Name = "Marilyn Monroe",
      Occupation = "entertainer",
      Bio = "(1926 - 1962) American actress, singer, model"
    },
    new Guest
    {
      Name = "Abraham Lincoln",
      Occupation = "politician",
      Bio = "(1809 - 1865) US President during American civil war"
    },
    new Guest
    {
      Name = "Martin Luther King",
      Occupation = "activist",
      Bio = "(1929 - 1968)  American civil rights campaigner"
    },
    new Guest
    {
      Name = "Rosa Parks",
      Occupation = "activist",
      Bio = "(1913 - 2005)  American civil rights activist"
    },
    new Guest
    {
      Name = "Peter Sellers",
      Occupation = "entertainer",
      Bio = "(1925 - 1980) British actor and comedian"
    },
    new Guest
    {
      Name = "Alan Turing",
      Occupation = "computer scientist",
      Bio = "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
    },
    new Guest
    {
      Name = "Admiral Grace Hopper",
      Occupation = "computer scientist",
      Bio = "(1906–1992) - developed early compilers= FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
    },
    new Guest
    {
      Name = "Indira Gandhi",
      Occupation = "politician",
      Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
    }
  };
}




        }
    }
}