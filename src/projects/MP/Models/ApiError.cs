using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Models
{
    internal class ApiError
    {
        public static ApiError Create(string message, string detail) => new ApiError(message, detail);         

        public ApiError(string message, string detail)
        {
            IsError = true;
            Message = message;
            Detail = detail;
        }

        public bool IsError { get; set; }
        
        public string Message { get; set; }

        public string Detail { get; set; }
    }
}
