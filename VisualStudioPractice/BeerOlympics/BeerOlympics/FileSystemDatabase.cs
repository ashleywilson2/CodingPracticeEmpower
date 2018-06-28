using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace BeerOlympics
{
    public class FileSystemDatabase : IDatabase
    {
        private readonly string rootPath;

        public FileSystemDatabase(string path)
        {
            rootPath = path;
        }

        public void Add(Contestant contestant)
        {
            var contJson = JsonConvert.SerializeObject(contestant);
            var fileName = contestant.Name + ".txt";
            File.WriteAllText(rootPath + @"\" + fileName, contJson);
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public Contestant Read(string name)
        {
            var fileName = contestant.Name + ".txt";
            throw new NotImplementedException();
        }

        public void Update(Contestant contestant)
        {
            throw new NotImplementedException();
        }

        private readonly string GenerateFileName()
    }
}
