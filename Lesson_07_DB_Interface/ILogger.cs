namespace Lesson_07_DB_Interface
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
