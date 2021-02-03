﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Shared 
{ 
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } 
    }
}
