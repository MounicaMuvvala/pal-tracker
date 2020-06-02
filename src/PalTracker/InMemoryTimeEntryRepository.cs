using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace PalTracker
{
    public class InMemoryTimeEntryRepository : ITimeEntryRepository
    {       
        IDictionary<long, TimeEntry> repo = new Dictionary<long, TimeEntry>();
        public bool Contains(long id) => repo.ContainsKey(id);

        public TimeEntry Create(TimeEntry timeEntry)
        {
            var id= repo.Count + 1;
            timeEntry.Id = id;
            repo.Add(id, timeEntry);
            return timeEntry;
        }

        public void Delete(long id)
        {
            if(repo.ContainsKey(id))
            {
                repo.Remove(id);
            }
        }

        public TimeEntry Find(long id) => repo[id];

        public IEnumerable<TimeEntry> List() => repo.Values;
        public TimeEntry Update(long id, TimeEntry timeEntry)
        {
            timeEntry.Id = id;            
            repo[id] = timeEntry;
            return timeEntry;
        }
    }
}
