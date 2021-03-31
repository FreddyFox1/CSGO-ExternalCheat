namespace Engine.Globals
{
    public interface IMemory
    {
        void ReadMemory<T>(int Adress);
        void WriteMemory<T>(int Adress, object Value);
    }
}