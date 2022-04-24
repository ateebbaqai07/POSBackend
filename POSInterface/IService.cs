using POSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace POSInterface
{
    [ServiceContract]
    public interface IService<T> where T : class
    {
        [OperationContract]
        ResponseDTO<T> Add(RequestDTO<T> _RequestDTO);

        [OperationContract]
        ResponseDTO<T> GetData(RequestDTO<T> _RequestDTO);

        [OperationContract]
        ResponseDTO<T> Authorize(RequestDTO<T> _RequestDTO);

        [OperationContract]
        ResponseDTO<T> Update(RequestDTO<T> _RequestDTO);
    }
}
