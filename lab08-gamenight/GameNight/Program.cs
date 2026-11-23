/*
* Name: Angel Goldsmith
* Course: CSCI 1250, Section 001
* Assignment: Lab 08, Game Night
* Date: November 22, 2026
* Description: Keeps a game night leaderboard in three text files. Shows the
* season so far, records tonight's points, saves the new totals,
* and adds tonight's result to a history that grows every week.
*/

//constants
const string PLAYERS_FILE = "players.txt";
const string POINTS_FILE = "points.txt";
const string HISTORY_FILE = "history.txt";

//Didn't end up using, I know I'm supposed to, I just couldn't fit it into it
//const int MAX_POINTS = 20;

// Look for the data files next to Program.cs, however the program is started.
string projectFolder = Path.GetFullPath(
Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
Directory.SetCurrentDirectory(projectFolder);

//read files
string[] players = File.ReadAllLines(PLAYERS_FILE);
string[] points = File.ReadAllLines(POINTS_FILE);
string[] history = File.ReadAllLines(HISTORY_FILE);


//Part 3 - Game Night Leaderboard
System.Console.WriteLine("=== GAME NIGHT LEADERBOARD ===");

int nights = File.ReadAllLines(HISTORY_FILE).Length;

//Needs to only execute if the critea is reached, the other needs to only happen if the "if" loop doesn't run
if (nights == 0)
{
    System.Console.WriteLine("No nights played yet.");
}
else
{
    System.Console.WriteLine($"Nights played: {nights}");
//Needed to output the history for each line
    for (int i = 0; i < nights; i++)
    {
        System.Console.WriteLine(history[i]);
    }
}
nights ++;
System.Console.WriteLine($"Tonight is Night {nights}.");

System.Console.WriteLine(" ");


//Part 1 - The Standings

int leader = LeaderIndex(points);

System.Console.WriteLine("PLAYERS".PadRight(10) + "POINTS");
//Is needed to run for each player to show their name and points
for (int i = 0; i < players.Length; i++) // Use .Count if they are Lists
{
    System.Console.WriteLine(players[i].PadRight(10) + points[i]);
}
System.Console.WriteLine($"Leader: {players[leader]} with {points[leader]}");
System.Console.WriteLine("Season total: " + TotalPoints(points));

System.Console.WriteLine(" ");


//Part 2 - Game Night

int winnerScore = 0;
string winnerName = "";

//Is needed to run for each player, so they all can be awarded points
for (int i = 0; i < players.Length; i++) // Use .Count if they are Lists
{
    System.Console.Write("Points tonight for " + players[i] +": ");
    int tonight = Convert.ToInt32(Console.ReadLine());
//Is needed to run multiple times if the critea is met
    while (tonight < 0 || tonight > 20)
    {
        System.Console.WriteLine("Points must be from 0 to 20.");
        System.Console.Write("Points tonight for " + players[i] +": ");
        tonight = Convert.ToInt32(Console.ReadLine());
    }
    int season = Convert.ToInt32(points[i]) + tonight;
    points[i] = season.ToString();
//Is only needed to run if the critea is met
    if(tonight>winnerScore)
    {
        winnerScore = tonight;
        winnerName = players[i];
    }

}
System.Console.WriteLine($"Tonight's winner: {winnerName} with {winnerScore}");
File.WriteAllLines(POINTS_FILE, points);

System.Console.WriteLine(" ");

System.Console.WriteLine("Saved points.txt.");

//Part 3 - The History

string[] entry = { HistoryEntry(nights, winnerName, winnerScore) };
File.AppendAllLines(HISTORY_FILE, entry);
System.Console.WriteLine($"Added to history.txt: {HistoryEntry(nights, winnerName, winnerScore)}");


//methods
//Decides and returns how the leader is based on if their points are higher than the current leader's points
static int LeaderIndex(string[] points)
{
    int leader = 0;
    for (int i = 1; i < points.Length; i++)
    {
        if (int.Parse(points[i]) > int.Parse(points[leader]))
        {
            leader = i;
        }
    }
    return leader;
}

//Calculates the total points for the season
static int TotalPoints(string[] points)
{
    int totalPoint = 0;
    foreach(string point in points)
    {
        totalPoint += int.Parse(point);
    }
    return totalPoint;
}

//Returns the entry for the history file
static string HistoryEntry(int nights, string winnerName, int winnerScore)
{
    return $"Night {nights}: {winnerName} won with {winnerScore} points";
}