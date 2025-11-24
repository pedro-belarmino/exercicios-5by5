string filePath = "exemplo.txt";
string directoryPath = "C:\\Projects\\Files";

StreamReader sr = new StreamReader(filePath);


try
{
    if (!Directory.Exists(directoryPath))
    {
        Directory.CreateDirectory(directoryPath);
    }
} catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Message);
}


var fullPath = Path.Combine(directoryPath, filePath);



using (sr)
{
    string content = sr.ReadToEnd();
    Console.WriteLine(content);
    sr.Close();
}

    StreamWriter writer = new StreamWriter(filePath, append: true);
    writer.WriteLine("e isso aiiii como a gente achou que ia seeeerr a vida tao simples eh boa quase sempre");
    writer.Close();





StreamReader srr = new StreamReader(filePath);


using (srr)
{
    string content = srr.ReadToEnd();
    Console.WriteLine(content);
    srr.Close();
}