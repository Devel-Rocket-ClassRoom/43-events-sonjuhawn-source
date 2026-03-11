using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

class GameEventArgs: EventArgs
{
    public string EventName {  get; }
    public object Data {  get; }

    public GameEventArgs(string eventName, object data)
    {
        EventName = eventName;
        Data = data;
    }
}

static class EventManager
{
    private static string eventname;
    private static object data;

    public static event EventHandler<GameEventArgs> OnGameEvent;


    public static void TriggerEvent(string eventName, object data = null)
    {
        OnGameEvent?.Invoke(eventName, e);
    }
}

class ScoreSystem
{
    public void Score(string eventName, object data)
    {
        if(eventName == "ScoreChanged")
        {
            Console.WriteLine($"점수 변경: {data}점");
        }
    }
}

class AchievementSystem
{
    public void Achievement(string eventName, object data)
    {
        if (eventName == "Achievement")
        {
            Console.WriteLine($"업적 달성: {data}");
        }
    }
}

class SoundSystem
{
    public void Sound(string eventName, object data)
    {
        Console.WriteLine($"[Sound] 이벤트: {eventName}");
    }
}