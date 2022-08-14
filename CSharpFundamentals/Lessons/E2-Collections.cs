using System;
using System.Collections.Generic;

public class Collection
{
    // List
    void ListTest()
    {
        List<byte> ageOfStudents = new List<byte>();
        ageOfStudents.Add(22);
    }

    // Stack

    void TestStack()
    {
        // LIFO
        Stack<string> plates = new Stack<string>();
        plates.Push("Plate 1");
        plates.Push("Plate 2");
        plates.Push("Plate 3");
        plates.Push("Plate 4");

        plates.Pop();
    }

    // Queue

    void TestQueue()
    {
        // Fifo
        Queue<string> patientLine = new Queue<string>();
        patientLine.Enqueue("PAIINET 1");
        patientLine.Enqueue("PAIINET 3");
        patientLine.Enqueue("PAIINET 4");
        patientLine.Enqueue("PAIINET 5");

        patientLine.Dequeue();
    }

    // Dictionary
    // Dictonary Ma key chai duplicate hunu vaiena hai

    void TestDictionary() {
        Dictionary<string, long> population = new Dictionary<string, long>();
        population.Add("Nepal", 30000000);
        population.Add("India",7000000000); 

        population.Remove("China");
     }
}
