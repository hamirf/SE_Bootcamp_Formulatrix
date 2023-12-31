﻿using System.IO;
using System.Xml.Serialization;

public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
}

class Program
{
	static void Main()
	{
		//Serialize
		Person person = new Person { Name = "Bob", Age = 11 };
		XmlSerializer serializer = new XmlSerializer(typeof(Person));
		using (StreamWriter writer = new StreamWriter("person.xml"))
		{
			serializer.Serialize(writer, person);
		}

		// Deserialize
		Person deserializedPerson;
		using (StreamReader reader = new StreamReader("person.xml"))
		{
			deserializedPerson = (Person)serializer.Deserialize(reader);
		}

		Console.WriteLine($"Deserialized Person: {deserializedPerson?.Name}, {deserializedPerson.Age}");
	}
}
