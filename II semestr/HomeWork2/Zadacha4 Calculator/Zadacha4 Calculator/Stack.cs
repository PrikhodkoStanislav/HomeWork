namespace StackNamespace
{
    public interface Stack
    {
        void Push(int value);

        int Pop();

        int Peek();

        bool IsEmpty();
    }
}
