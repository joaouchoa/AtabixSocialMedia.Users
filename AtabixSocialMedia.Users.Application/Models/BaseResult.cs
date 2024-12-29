using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtabixSocialMedia.Users.Application.Models
{
    public class BaseResult
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }

        public BaseResult(bool sucess = true, string message = "")
        {
            Sucess = sucess;
            Message = message;  
        }
    }

    public class BaseResult<T> : BaseResult
    {
        public T Data { get; set; }

        public BaseResult(T data, bool sucess = true, string message = "") : base (sucess, message)
        {
            Data = data;
        }
    }
}
