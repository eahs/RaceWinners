using System.Collections.Generic;
using System.Threading.Tasks;
using RaceWinners.Models;

namespace RaceWinners;

/// <summary>
/// A <b>service</b> that supplies the race results to the rest of the program.
/// </summary>
/// <remarks>
/// <para>
/// A service is a class that does one focused job for other parts of a program. This
/// service's only job is to <i>get the data</i>. It does not print anything, and it does
/// not decide who wins — that is somebody else's job.
/// </para>
/// <para>
/// Any class that uses this service is said to <b>depend</b> on it, so the service is
/// called a <b>dependency</b>. Keeping data loading in its own class means that later we
/// could load the results from a file, a database, or a website by changing <i>only</i>
/// this class. The code that uses the data would not need to change at all.
/// </para>
/// </remarks>
public class DataService
{
    /// <summary>
    /// Gets the race results for every group.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This method is <c>async</c>, which means it can wait for slow work (like a network
    /// download) without freezing the program. By convention, async method names end in
    /// <c>Async</c>.
    /// </para>
    /// <para>
    /// It returns a <see cref="Task{TResult}"/> — a "promise" that a
    /// <see cref="List{T}"/> of <see cref="Group"/> objects will be ready later.
    /// Callers use the <c>await</c> keyword to wait for that list.
    /// </para>
    /// </remarks>
    /// <returns>A list with one <see cref="Group"/> for each class that ran the race.</returns>
    public async Task<List<Group>> GetGroupRanksAsync()
    {
        var groups = new List<Group>();

        // Pretend we are downloading this data over a network.
        // Task.Delay waits for 1000 milliseconds (1 second) without blocking the program.
        await Task.Delay(1000);

        // Add one Group object for each class.
        groups.Add(new Group
        {
            Name = "Class A",
            Ranks = new List<int> { 4, 9, 11, 12, 20 }
        });

        return groups;
    }
}
