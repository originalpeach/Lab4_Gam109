using System;
using System.Collections.Generic;
using System.Linq;

public class userData
{
    public string Name { get; set; }
    public int Level { get; set; }

    public userData(string name, int level)
    {
        Name = name;
        Level = level;
    }
}

class Program
{
    static void Main()
    {
        List<userData> users = new List<userData>
        {
            new userData("Alice", 3),
            new userData("Bob", 5),
            new userData("Charlie", 2),
            new userData("David", 4)
        };

        var selectedUsers = users.Select(user => new { user.Name, user.Level });
        Console.WriteLine("Thông tin Name và Level của danh sách userData:");
        foreach (var user in selectedUsers)
        {
            Console.WriteLine($"Name: {user.Name}, Level: {user.Level}");
        }

        var sortedUsers = users.OrderByDescending(user => user.Level);
        Console.WriteLine("\nDanh sách userData sau khi sắp xếp theo thứ tự giảm dần Level:");
        foreach (var user in sortedUsers)
        {
            Console.WriteLine($"Name: {user.Name}, Level: {user.Level}");
        }
    }
}
