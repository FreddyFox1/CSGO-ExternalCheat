namespace Engine.Globals
{
    public interface IMemory
    {
        /// <summary>
        /// Read process memory
        /// </summary>
        /// <typeparam name="T">Type of data to READ</typeparam>
        /// <param name="Adress">Adress RAM</param>
        /// <returns>Value from RAM Memory</returns>
        T ReadMemory<T>(int Adress) where T : struct;

        /// <summary>
        /// Write process memory
        /// </summary>
        /// <typeparam name="T">Type of data to WRITE</typeparam>
        /// <param name="Adress">Adress RAM</param>
        /// <param name="Value">Data</param>
        void WriteMemory<T>(int Adress, object Value) where T : struct;
    }
}