using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerroApp.GUI.Reponses
{
    public class ApiResponse<T>

    {
        public ApiResponse(T data)
        {
            Data = data;
        }

        public T Data { get; private set; }
    }
}
