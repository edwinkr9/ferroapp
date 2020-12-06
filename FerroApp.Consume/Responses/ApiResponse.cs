using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FerroApp.Consume.Models
{
    public class ApiResponse <T>
    {
            public ApiResponse(T data)
            {
                this.Data = data;
            }

            public T Data { get; private set; }

        internal void Wait()
        {
            throw new NotImplementedException();
        }
    }

}

