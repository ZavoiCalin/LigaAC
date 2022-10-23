using System;

/*Construiește două clase: o clasă “Student” care moștenește o clasă “Persoană” și
încearcă să construiești un Catalog (array/vector) care să conțină mai multe
obiecte de tip Student.

○ Un Student are: medie_generala, nume_facultate;
○ O Persoană are: nume, prenume, varsta;
○ Construiește și o metodă (funcție) în interiorul clasei “Student” care să
schimbe media generală a studentului.
*/

public class Person
{
	protected String nume, prenume;
	protected int varsta;
	
}

public class Student : Person
{
	private float medie_generala;
	private String nume_facultate;
	
	public void schimbaMed(float med)
	{
		medie_generala = med;
	}
	
	public float getMed()
	{
		return medie_generala;
	}
	
}

public class Catalog
{
	Student [] studenti;
}

					
public class Program
{
	public static void Main()
	{
		Student s = new Student();
		
		Console.WriteLine(s.getMed() + "\n");
		
		s.schimbaMed(10.5f);
		
		Console.WriteLine(s.getMed());
	}
}
