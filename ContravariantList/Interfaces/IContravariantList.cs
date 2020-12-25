namespace ContravariantList.Interfaces
{
    public interface IContravariantList<in T>
    {
        int Count { get; }
        void Push(T entity);
    }
}