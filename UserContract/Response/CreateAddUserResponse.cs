﻿using Contracts.Enums;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Response
{
    public class CreateAddUserResponse
    {
            public string Name { get; set; }
            public string SurName { get; set; }
            public string IdCard { get; set; }
            public string Email { get; set; }

        [JsonProperty("userType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserType UserType { get; set; }
        
    }
}
