﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restion.Interfaces
{
    public interface IJsonSerializer
    {
        string Serialize<T>(T obj);

        Task<string> SerializeAsync<T>(T obj);

        T Deserialize<T>(string json);

        Task<T> DeserializeAsync<T>(string json);
    }
}
