using System;
using System.Collections;
					
public class Program
{
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
		
		Program obj=new Program();
		string[] names = {"Alan Mattew","Rob Allison","Mike Benny","Peter Allison","Patrick Ben Allison"};
		SortedList mySL= new SortedList();
		int i=0;
		
		Console.WriteLine("Given Array:\n");
		obj.PrintArray(names);
		
		foreach(string name in names)
		{
			string[] splitName=name.Split(' ');
			string lastName=splitName[splitName.Length-1];
			string key=lastName+name;
			i=i+1;
			mySL.Add(key,name);
		}
		
		Console.WriteLine("Sorted Array:\n");
		for ( int j = 0; j < mySL.Count; j++ )  {
         Console.WriteLine( "\t{0}", mySL.GetByIndex(j));
       }
		
	}
}
