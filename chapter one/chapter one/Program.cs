using System;

namespace chapter_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar g = new Guitar("ss", Builder.Fender, Type.Acoustic, "string", "string", 23);
            Guitar f = new Guitar("ss", Builder.Fender, Type.Electric, "string", "string", 23);
            
            // Console.WriteLine(g.GetBuilder() == f.GetBuilder());
        }
    }
}