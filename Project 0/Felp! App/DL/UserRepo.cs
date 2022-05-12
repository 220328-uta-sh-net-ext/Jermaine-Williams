namespace DL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class UserRepo : IUserRepo
{
    public UserRepo()
    { }

    private string filePath = "../../../../DL/Database/";
    private string jsonString;

    public User AddUser(User newuser) //serialzation
    {
        var users = GetAllUsers();
        users.Add(newuser);
        var userString = JsonSerializer.Serialize<List<User>>(users, new JsonSerializerOptions { WriteIndented = true });
        try
        {
            File.WriteAllText(filePath, "Users.json" + jsonString);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Please check the path, " + ex.Message);
        }

        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check the file name, " + ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return newuser;
    }

    public List<User> GetAllUsers() //deserialzation
    {
        try
        {
            jsonString = File.ReadAllText(filePath + "Users.json");
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Please check the path, " + ex.Message);
        }

        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Please check the file name, " + ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        if (!string.IsNullOrEmpty(jsonString))
            return JsonSerializer.Deserialize<List<User>>(jsonString);
        else
            return null;
    }

    public bool IsDuplicate(User newuser)
    {
        throw new NotImplementedException();
    }
}

