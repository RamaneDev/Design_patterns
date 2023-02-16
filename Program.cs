using System;
using Design_patterns.AbstractFactroyPattern;
using Design_patterns.BuilderPattern;
using Design_patterns.Singleton;
using Design_patterns.Strategy;

namespace design_pattern;
class Program
{
    static void Main(string[] args)
    {
        #region use strategy pattern
        
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

        #endregion

        #region use singleton pattern  
           Logger logger = Logger.Instance;
           logger.Log("some logs");
        #endregion 
        
        #region use abstractFactory pattern

            ContinentFactory africa = new AfricaFactory();
            Ecosystem ecoAf = new Ecosystem(africa);
            ecoAf.Run();


            ContinentFactory aust = new AustraliaFactory();
            Ecosystem ecoAus = new Ecosystem(aust);
            ecoAus.Run();

        #endregion
    
        #region use builder pattern
            MenuDirector director = new MenuDirector();
            MenuBuilder BurgerBuilder = new BurgerMenuBuilder();
            director.Construct(BurgerBuilder);
            Menu burgerMenu = BurgerBuilder.GetResult();
        #endregion
    }
}
