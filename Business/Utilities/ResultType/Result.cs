using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.ResultType
{
    public class Result<T>:IResult<T>
    {
        public string Message { get; }
        public T Data { get; }
        public bool Success { get; }
        public Result(T data, bool success, string message)
        {
            Data = data;
            Success = success;
            Message = message;
        }
        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

    }
}
