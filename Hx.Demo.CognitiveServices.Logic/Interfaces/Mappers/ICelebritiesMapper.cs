﻿using Hx.Demo.CognitiveServices.Logic.Models;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Hx.Demo.CognitiveServices.Logic.Interfaces.Mappers
{
    public interface ICelebritiesMapper
    {
        void Map(JToken container, List<Face> faces);
    }
}
