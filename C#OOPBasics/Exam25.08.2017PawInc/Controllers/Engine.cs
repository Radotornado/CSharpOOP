using System;

public class Engine
{
    private PawIncManager manager;

    public Engine()
    {
        this.manager = new PawIncManager();
    }

    public void Start()
    {
        var command = Console.ReadLine();

        while (command != "Paw Paw Pawah")
        {
            if (command == "CastrationStatistics")
            {
                Console.WriteLine(this.manager.PrintCastrationCentersStat());

                command = Console.ReadLine();
                continue;
            }

            var cmdArgs = command.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            var name = cmdArgs[1];
            int age;
            string adoptionCenterName;

            switch (cmdArgs[0])
            {
                case "RegisterCleansingCenter": 
                    this.manager.RegisterCleansingCenter(name);
                    break;
                case "RegisterAdoptionCenter":
                    this.manager.RegisterAdoptionCenter(name);
                    break;
                case "RegisterCastrationCenter":
                    this.manager.RegisterCastrationCenter(name);
                    break;
                case "RegisterDog": 
                    age = int.Parse(cmdArgs[2]);
                    var learnedCommands = int.Parse(cmdArgs[3]);
                    adoptionCenterName = cmdArgs[4];
                    this.manager.RegisterDog(name, age, learnedCommands, adoptionCenterName);
                    break;
                case "RegisterCat":
                    age = int.Parse(cmdArgs[2]);
                    var intelligenceCoefficient = int.Parse(cmdArgs[3]);
                    adoptionCenterName = cmdArgs[4];
                    this.manager.RegisterCat(name, age, intelligenceCoefficient, adoptionCenterName);
                    break;
                case "SendForCleansing": 
                    adoptionCenterName = cmdArgs[1];
                    var cleansingCenterName = cmdArgs[2];
                    this.manager.SendForCleansing(adoptionCenterName, cleansingCenterName);
                    break;
                case "Cleanse": 
                    this.manager.Cleanse(name);
                    break;
                case "Adopt":
                    this.manager.Adopt(name);
                    break;
                case "Castrate":
                    this.manager.Castrate(name);
                    break;
                case "SendForCastration": 
                    adoptionCenterName = cmdArgs[1];
                    var castrationCenterName = cmdArgs[2];
                    this.manager.SendForCastration(adoptionCenterName, castrationCenterName);
                    break;
                default:
                    break;
            }

            command = Console.ReadLine();
        }

        Console.Write(this.manager);
    }
}

