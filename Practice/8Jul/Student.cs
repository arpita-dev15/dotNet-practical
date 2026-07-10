//Class= A class is a logical entity, it defines properties and functions that the obj will have
//Stores value of similar data
//eg. home appliances, electronics
//{} = logic,block of code
//() = parameters or properties define
//[] = to define size (array)

using System;
using System.ComponentModel;

class Student {

    public int rollno;
    public String name;
    public String institute;
    public long dob;
    public String branch;
    public char gender;
    public float height;

    public Student(int r, String n, String i,long d, String b, char g, float h)
    {
        rollno = r;
        name = n;
        institute = i;
        dob = d;
        branch = b;
        gender = g;
        height = h;
    }
    public void display() {
        Console.WriteLine(rollno+" "+name+" "+institute+" "+dob+
        " "+branch+" "+height);
    }
}