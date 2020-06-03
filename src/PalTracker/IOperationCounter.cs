using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalTracker
{
    public interface IOperationCounter<T>
    {
        void Increment(TrackedOperation operation);

        IDictionary<TrackedOperation, int> GetCounts { get; }

        string Name { get; }
    }
}