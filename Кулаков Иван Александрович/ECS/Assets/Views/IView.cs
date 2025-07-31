using Entitas;

public interface IView<T> where T : IEntity
{
  T Entity { get; set; }
}
