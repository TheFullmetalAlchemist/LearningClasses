using System;
using System.Security.Cryptography.X509Certificates;

namespace LearnClasses
{
    public class Program{
    public static void Main(string[] args){
        var dbmigrate = new Dbmigrate(new Logger());

        var logger = new Logger();
        var installer = new Installer(logger);
        dbmigrate.Migrate();
        installer.Install();
        
    }
    }
    public class Dbmigrate{
        private readonly Logger _logger;
        public Dbmigrate(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate(){
            _logger.Log("We are migrating using logger");
        }
    }

    public class Installer{
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger=logger;
        }
        public void Install(){
            _logger.Log("We are installing using logger");
        }
    }
    public class Logger{
        public void Log(string message){
            System.Console.WriteLine(message);
        }
    }

}   