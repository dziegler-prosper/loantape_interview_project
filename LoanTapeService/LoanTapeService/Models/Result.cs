using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanTapeService.Models
{
    public class Result<T>
    {
        public Result()
        {
            Errors = new List<string>();
        }

        public bool IsSuccess => !Errors.Any();

        public List<string> Errors { get; set; }

        public T Data { get; set; }
    }
}
