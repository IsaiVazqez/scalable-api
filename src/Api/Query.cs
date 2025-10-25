namespace Api;

public class Query
{
    public string Ping() => "pong from updated version 🚀";
    
    public string GetTimestamp() => DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss UTC");
    
    public string GetServerInfo() => $"Server running on {Environment.MachineName} - Version 2.0";
}