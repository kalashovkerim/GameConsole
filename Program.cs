namespace ConsoleApp1;

public class Program
{
    public static void Main()
    {
        using ModelContext context = new();

        var GameModels = context.Model.ToList();

        var newModel = new Model()
        {
            Style = GameStyle.Shooter,
            GameName = "Fortnite"
        };

        GameModels.Add(newModel);

        foreach (var item in GameModels)
        {
            Console.WriteLine($"{item.GameName}\n{item.Style}\n{item.ReleaseDate}");
        }

        context.SaveChanges();

    }
}
