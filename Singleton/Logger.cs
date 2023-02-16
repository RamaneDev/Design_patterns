using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Singleton
{
    public class Logger
    {
        FileStream logStream {set; get;}
        StreamWriter streamWriter { get; set; }
        private static object _handle = new object();
        private static Logger _instance = null; 
        private Logger()
        {
            logStream = File.Open("some path// ", FileMode.Create);
            streamWriter = new StreamWriter(logStream);
        }

        public void Log(string message)
        {
            streamWriter.Write(message);
            streamWriter.Write(Environment.NewLine);
        }

         ~Logger() 
         {
             try
             {
                streamWriter.Close();
                streamWriter.Dispose();
             }
             catch (System.Exception)
             {                
                throw;
             }         
         
         }

         // Gets the logger instance...
         // double-checked locking pattern !
         // lazy initialization (static)
         public static Logger Instance
         {
            get 
            {
                lock (_handle)
                {
                    if(_instance == null)
                    {
                        _instance = new Logger();
                    }
                }

                return _instance;
            }
         }  
        
    }
}
