using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSModel
{
    public class ResponseDTO<T>
    {
        public ResponseDTO()
        {
            ErrorMessages = new List<ErrorMessage>();
        }
        public T DTO { get; set; }
        public bool Result { get; set; }
        public string ResponseCode { get; set; }
        public List<ErrorMessage> ErrorMessages { get; set; }

    }

    public class ErrorMessage
    {
        public long ErrorCode { get; set; }
        public string Message { get; set; }
    }
}
