using System;
using System.Collections.Generic;
using Design_patterns.AbstractFactroyPattern;
using Design_patterns.Behavioral_Patterns.ChainOfResponsibility;
using Design_patterns.Behavioral_Patterns.Command;
using Design_patterns.Behavioral_Patterns.Interpreter;
using Design_patterns.Behavioral_Patterns.Iterator;
using Design_patterns.Behavioral_Patterns.Mediator;
using Design_patterns.Behavioral_Patterns.Observer;
using Design_patterns.Behavioral_Patterns.State;
using Design_patterns.Behavioral_Patterns.TemplateMethod;
using Design_patterns.Behavioral_Patterns.Visitor;
using Design_patterns.BuilderPattern;
using Design_patterns.Creational_Patterns.FactoryMethodPattern;
using Design_patterns.Creational_Patterns.ProtoType;
using Design_patterns.Singleton;
using Design_patterns.Strategy;
using Design_patterns.Structural_Patterns.AdapterPattern;
using Design_patterns.Structural_Patterns.Bridge;
using Design_patterns.Structural_Patterns.CompositePattern;
using Design_patterns.Structural_Patterns.DecoratorPattern;
using Design_patterns.Structural_Patterns.Facade;
using Design_patterns.Structural_Patterns.Flyweight;
using Design_patterns.Structural_Patterns.ProxyPattern;

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


      #region 
       
            Proxy proxy = new Proxy();
            proxy.Request();
      #endregion
     
        

      #region  use Facade pattern       
        Facade facade = new Facade();
        facade.MethodA();
        facade.MethodB();
      #endregion

      


      #region use bridge pattern
         ShapeAbstraction Circle = new ConcreteShape("Circle");
         Circle.PenAbstraction = new ConcretePen("bleu");
         Circle.Draw();
  
         // change the pen color to black
  
         Circle.PenAbstraction = new ConcretePen();
         Circle.Draw();
  
  
         // change the pen color to red
  
         Circle.PenAbstraction = new ConcretePen("red");
         Circle.Draw();
  
#endregion
    

     
           #region use Flyweight pattern
            CharacterFactory factory = new CharacterFactory();
            Client client = new Client(factory);
            factory.DesplayFactoryObjectCount();
            client.AddCharacter('A');
            client.AddCharacter('B');
            factory.DesplayFactoryObjectCount();   // at this level count is 2
            client.AddCharacter('A');
            factory.DesplayFactoryObjectCount();   // at this level also a count shoud be 2
                                                   // because we have already 'A' object in the Factory
  
            client.DisplayCharacters();
#endregion

     
        #region use chainOfResponsibility pattern
              Handler h1 = new ConcreteHandler1();
              Handler h2 = new ConcreteHandler2();
              Handler h3 = new ConcreteHandler3();
              h1.SetSuccessor(h2);
              h2.SetSuccessor(h3);
              // Generate and process request
              int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
              foreach (int request in requests)
              {
                  h1.HandleRequest(request);
              }   
        #endregion
  


#region use command pattern
              Receiver receiver = new Receiver();
              Command command = new ConcreteCommand(receiver);
              Invoker invoker = new Invoker();
              // Set and execute command
              invoker.SetCommand(command);
              invoker.ExecuteCommand();
#endregion


#region use interpreter pattern
              string roman = "MCMXXVIII";
              Context context = new Context(roman);
              // Build the 'parse tree'
              List<Expression> tree = new List<Expression>();
              tree.Add(new ThousandExpression());
              tree.Add(new HundredExpression());
              tree.Add(new TenExpression());
              tree.Add(new OneExpression());
              // Interpret
              foreach (Expression exp in tree)
              {
                  exp.Interpret(context);
              }
              Console.WriteLine("{0} = {1}",
                  roman, context.Output);

                  #endregion
  
     


          #region use iterator pattern
              ConcreteAggregate a = new ConcreteAggregate();
              a[0] = "Item A";
              a[1] = "Item B";
              a[2] = "Item C";
              a[3] = "Item D";
              // Create Iterator and provide aggregate
              AbstractIterator i = a.CreateIterator();
              Console.WriteLine("Iterating over collection:");
              object item = i.First();
              while (item != null)
              {
                  Console.WriteLine(item);
                  item = i.Next();
              }
          #endregion
    
      
           #region use mediator pattern
             ConcreteMediator m = new ConcreteMediator();
             ConcreteColleague1 c1 = new ConcreteColleague1(m);
             ConcreteColleague2 c2 = new ConcreteColleague2(m);
             m.Colleague1 = c1;
             m.Colleague2 = c2;
             c1.Send("How are you?");
             c2.Send("Fine, thanks");
           #endregion
 
            #region use Observer pattern
              ConcreteSubject s = new ConcreteSubject();
              s.Attach(new ConcreteObserver(s, "X"));
              s.Attach(new ConcreteObserver(s, "Y"));
              s.Attach(new ConcreteObserver(s, "Z"));
              // Change subject and notify observers
              s.SubjectState = "ABC";  // this set will call Notify Automatically (see Subject Abstract class)
              //s.Notify();
        
            #endregion
     



        #region use state pattern
                     // Setup context in a state
              var context = new Design_patterns.Behavioral_Patterns.State.Context(new ConcreteStateA());
              // Issue requests, which toggles state
              context.Request();
              context.Request();
              context.Request();
              context.Request();
        #endregion
       
        
  


#region use TemplateMethod pattern
              AbstractTemplateMethod aA = new ConcreteTemplateMethodA();
              aA.TemplateMethod();
              AbstractTemplateMethod aB = new ConcreteTemplateMethodB();
              aB.TemplateMethod();
#endregion
     
           */  


           
#region use visitor pattern
              // Setup structure
              ObjectStructure o = new ObjectStructure();
              o.Attach(new ConcreteElementA());
              o.Attach(new ConcreteElementB());
              // Create visitor objects
              ConcreteVisitor1 v1 = new ConcreteVisitor1();
              ConcreteVisitor2 v2 = new ConcreteVisitor2();
              // Structure accepting visitors
              o.Accept(v1);
              o.Accept(v2);
#endregion

      }

}
