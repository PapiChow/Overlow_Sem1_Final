using System;



public class User
{
    public string username;
    public string password;
    public User(string un, string pw)
    {
        username = un;
        password = pw;
    }
}

public class Admin : User
{
    public Admin(string un, string pw) : base(un, pw)
    {
        username = un;
        password = pw;
    }
}

public class Guest : User
{
    public Guest(string un, string pw) : base(un, pw)
    {
        username = un;
        password = pw;
    }
}

public class Calculator
{
    public Calculator()
    {
    }
    public float Add(params float[] numbers)
    {
        float answer = 1;
        foreach (float number in numbers)
        {
            answer += number;
        }
        return answer;
    }

    public float Subtract(params float[] numbers)
    {
        float answer = 1;
        foreach (float number in numbers)
        {
            answer -= number;
        }
        return answer;
    }

    public float Multiply(params float[] numbers)
    {
        float answer = 1;
        foreach (float number in numbers)
        {
            answer *= number;
        }
        return answer;
    }

    public float Divide(float a, float b)
    {
        float answer = a / b;
        return answer;
    }
}

