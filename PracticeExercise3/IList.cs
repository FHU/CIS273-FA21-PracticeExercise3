using System;
namespace PracticeExercise3
{
    public interface IList<T>
    {
        // TODO
        int Length { get; }

        // TODO
        bool IsEmpty { get; }

        // TODO
        T First { get; }
        // TODO
        T Last { get; }

        // TODO
        // Add i to end of list
        void Append(T item);

        // TODO
        // Add i to beginning of list
        void Prepend(T item);

        // TODO
        // Insert new value after first instance of exisiting value
        // If existing value isn't found, then append to list.
        void InsertAfter(T newValue, T existingValue);

        // TODO
        void InsertAt(T newValue, int index);

        // TODO
        int FirstIndexOf(T existingValue);

        // TODO
        void Remove(T value);

        // TODO
        void RemoveAt(int index);

        // TODO
        void Clear();

        // TODO
        IList<T> Reverse();
    }
}
