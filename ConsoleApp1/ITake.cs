namespace Program
{
    public interface ITake
    {
        bool TakeSmth(string message, out bool choice, bool force = false);
    }
}