using Newtonsoft.Json.Linq;


try
{
    string jsonFilePath = "lines.json";

    if (File.Exists(jsonFilePath))
    {
        string jsonString = File.ReadAllText(jsonFilePath);
        string json = jsonString;

        JObject jsonObject = JObject.Parse(json);

        JArray linesArray = (JArray)jsonObject["lines"];

        Console.WriteLine("line | text");
        foreach (JObject lineObject in linesArray)
        {
            int lineNumber = (int)lineObject["coordinate"];
            string lineText = (string)lineObject["description"];

            Console.WriteLine(lineNumber + " " + lineText);
        }
    }
    else
    {
        Console.WriteLine("The " + jsonFilePath + " file could not be found.");
    }
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}



