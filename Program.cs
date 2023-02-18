using System;
using Design_patterns.AbstractFactroyPattern;
using Design_patterns.BuilderPattern;
using Design_patterns.Creational_Patterns.FactoryMethodPattern;
using Design_patterns.Creational_Patterns.ProtoType;
using Design_patterns.Singleton;
using Design_patterns.Strategy;
using Design_patterns.Structural_Patterns.AdapterPattern;
using Design_patterns.Structural_Patterns.CompositePattern;
using Design_patterns.Structural_Patterns.DecoratorPattern;

namespace design_pattern;
class Program
{
    static void Main(string[] args)
    {

       /*

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
      
        #region use prototype pattern

            ColorManager colormanager = new ColorManager();
            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);
            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);
            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;
       
       #endregion
      
     
        #region use factoryMethod pattern
          // Note: constructors call Factory Method
            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();
            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }           
         #endregion
       
       
        #region use Adapter pattern
          // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
            
        #endregion
         
    

       #region use composite pattern

            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));
            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);
            root.Add(new Leaf("Leaf C"));
            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            // Recursively display tree
            root.Display(1);

        
       #endregion
    
     */ 

     #region use decorator pattern

       // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();
            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();
        
     #endregion
    
    }
}
