using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. List goal names");
            Console.WriteLine("4. List goal details");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoalNames();
                    break;
                case "4":
                    ListGoalDetails();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    private void ListGoalNames()
    {
        Console.WriteLine("Goal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, 3: Checklist): ");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter goal target: ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter goal bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < _goals.Count)
        {
            _score += _goals[choice].RecordEvent();
            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void SaveGoals()
    {
        Console.WriteLine("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        Console.WriteLine("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(':');
                string[] attributes = parts[1].Split(',');

                switch (parts[0])
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(attributes[0], attributes[1], int.Parse(attributes[2]))
                        {
                            
                        });
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(attributes[0], attributes[1], int.Parse(attributes[2])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(attributes[0], attributes[1], int.Parse(attributes[2]),
                            int.Parse(attributes[4]), int.Parse(attributes[5]))
                        {
                            AmountCompleted = int.Parse(attributes[3])
                        });
                        break;
                }
            }
        }
        Console.WriteLine("Goals loaded.");
    }
}
