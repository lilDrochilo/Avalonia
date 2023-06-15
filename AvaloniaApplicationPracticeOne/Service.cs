using AvaloniaApplicationPracticeOne.Models;

namespace AvaloniaApplicationPracticeOne;

public class Service
{

    private static Mix? _db;

    public static Mix GetDbContext()
    {
        if (_db == null)
        {
            _db = new Mix();
        }
        return _db;
    }
}