using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    // Save entry in CSV format (quotes handle commas safely)
    public string ToCsv()
    {
        return $"\"{_date}\",\"{_prompt}\",\"{_response}\"";
    }

    public static Entry FromCsv(string line)
    {
        string[] parts = line.Split("\",\"");
        string date = parts[0].Trim('"');
        string prompt = parts[1].Trim('"');
        string response = parts[2].Trim('"');
        return new Entry(date, prompt, response);
    }

    public string Date => _date;
}
