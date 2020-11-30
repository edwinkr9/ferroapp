using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FerroApp.ConsumeApis.Responses
{
    public class ApiResponse<T>
    {
        public ApiResponse(T data)
        {
            this.Data = data;
        }

        public T Data { get; private set; }
    }
}
