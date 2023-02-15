using System;
using Design_patterns.Strategy;

namespace design_pattern;
class Program
{
    static void Main(string[] args)
    {
        /*****  using the strategy pattern  *******/
        
            FullName[] namesFromDatabase = {}; // to populate
            string[] namesToMatch = {}; // to populate        

            NameImporter importer = new NameImporter(new ExactComparer());
            // match will use the Exact implementation of compare
            importer.Match(namesFromDatabase, namesToMatch); 
            
            importer = new NameImporter(new FuzzyComparer());
            // match will use the Fuzzy implementation of compare
            importer.Match(namesFromDatabase, namesToMatch); 

            importer = new NameImporter(new AbbreviationComparer());
            // match will use the Abbreviation implementation of compare
            importer.Match(namesFromDatabase, namesToMatch);

         /***** end of using the strategy pattern  *******/ 
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Console.WriteLine("Hello, World!");
    }
}
