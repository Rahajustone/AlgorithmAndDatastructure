using System;
namespace Algorithms.Princeton.Unuversity.Stack;

public interface IStack<T>
{
    void Push(T item);
    T Pop();
    bool IsEmpty();
}
