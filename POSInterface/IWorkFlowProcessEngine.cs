using POSModel;
using POSRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSInterface
{
    public interface IWorkFlowProcessEngine<T> where T : class
    {
        ResponseDTO<T> GetData(IRepository<T> _Repository, RequestDTO<T> _RequestDTO);

        ResponseDTO<T> Add(IRepository<T> _Repository, RequestDTO<T> _RequestDTO);

        ResponseDTO<T> Update(IRepository<T> _Repository, RequestDTO<T> _RequestDTO);

        ResponseDTO<T> Authorize(IRepository<T> _Repository, RequestDTO<T> _RequestDTO);
    }
}
