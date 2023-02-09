Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello Collections!")
        Console.WriteLine("")

    ' ==== Arrays ====
    ' Arrays are a homogenous collection of items stored in a contiguous memory space
    ' declare arrays by including () after the variable name
    dim fruits() as string = { "banana", "apple", "mango" }    
    dim fruits2(3) as String

    'arrays in vb ar zero based
    fruits(0) = "kiwi"
    fruits(1) = "strawberry"
    fruits(2) = "Orange"

    ' enhanced for loop aka for each that the is utilized to iterate over collections
    For Each fruit as STring In fruits
        Console.WriteLine(fruit)
    Next

    console.WriteLine("")
    console.WriteLine("")   

    ' ==== List ====
    ' Lists are ordered collection of homogenious items
    ' LIke arrays are also index based, but unlike arrys can dynamically change size
    dim students as New List (of String)
    students.add("Irving")
    students.add("Chase")
    students.add("Gavin")
    students.add("Amol")

    for Each student as String in students
        Console.WriteLine(student)
    Next    

    students(3) = "Amol Apte"

    Console.WriteLine(students(3))

    for Each student as String in students
        Console.WriteLine(student)
    Next    

    console.WriteLine("")
    console.WriteLine("")  

    ' === Dictionary ===
    ' Dictionary is a collection of key value pairs
    ' Access these values based on their keys

    dim gradeBook as new dictionary( of string, integer)
    gradeBook.Add("justin", 95)
    gradeBook.Add("marielle", 100)
    gradeBook.Add("coco", 200)

    console.WriteLine("")  

    Console.WriteLine("marielle got a grade of {0}" , gradeBook("marielle"))

    console.WriteLine("")  

    For Each grade As keyValuePair(of String, Integer) In gradeBook
        Console.writeLine("{0} got a grade of {1}", grade.Key, grade.Value)
    Next

    console.WriteLine("")  
    gradeBook.Remove("marielle")

    For Each grade As keyValuePair(of String, Integer) In gradeBook
        Console.writeLine("{0} got a grade of {1}", grade.Key, grade.Value)
    Next


    End Sub
End Module
