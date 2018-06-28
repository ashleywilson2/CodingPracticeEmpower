using System;
using System.Collections.Generic;
using System.Text;

namespace BeerOlympics
{
    interface IDatabase
    {
        void Create(Contestant contestant);
        Contestant Read(int id);
        void Update(Contestant contestant);
        void Delete(int id);
        IEnumerable<Contestant> GetAllContestants();
    }
}
