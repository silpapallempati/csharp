using System;
using System.Collections;
					
public class Program
{
	//Method to print values in Array	
	public void PrintArray(string[] arr)
		{
			foreach(string item in arr)
			{
				Console.WriteLine("\t{0}",item);
			}
			Console.WriteLine("\n");
		}
	
	public static void Main()
	{
		
		Program obj				=	new Program();
		string[] names  		=   {"Janet Parsons","Vaughn Lewis","Adonis Julius Archer","Shelby Nathan Yoder","Marin Alvarez","London Lindsey","Beau Tristan Bentley","Leo Gardner","Hunter Uriah Mathew Clarke","Mikayla Lopez","Frankie Conner Ritter"};
		string[] sortedNames 	= 	new string[names.Length];
		SortedList mySL			=	new SortedList();
		int i					=	0;
		
		//Print given Array of names
		Console.WriteLine("Given Array of Names:\n");
		obj.PrintArray(names);
		
		
		/*1. find last name of each value in the array by splitting the string based on space and append it to the begin of the name.
		2. Add this dervied value as the key of a Sorted List which by default sorts the data by key*/
		
		foreach(string name in names)
		{
			string[] splitName	=	name.Split(' ');
			string lastName		=	splitName[splitName.Length-1];
			string key			=	lastName+name;
			i					=	i+1;
			mySL.Add(key,name);
		}
		
		for ( int j = 0; j < mySL.Count; j++ )  {
         //Console.WriteLine( "\t{0}", mySL.GetByIndex(j));
			sortedNames[j]=(string)mySL.GetByIndex(j);
       }
		
		//Print Sorted Array of names
		Console.WriteLine("Sorted Array of Names:\n");
		obj.PrintArray(sortedNames);
			
		
	}
}
