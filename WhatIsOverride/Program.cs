using System;

namespace WhatIsOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent= new Parent();
            parent.Say();
            parent.Run();
            parent.Walk();

            Child child = new Child();
            child.Say();
            child.Run();
            child.Walk();
        }
    }
}