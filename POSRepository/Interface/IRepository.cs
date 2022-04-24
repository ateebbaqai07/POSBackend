using POSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSRepository.Interface
{
    public interface IRepository<T> where T : class
    {
        public ResponseDTO<T> Get(RequestDTO<T> requestDTO);
        public ResponseDTO<List<T>> GetObjectList(RequestDTO<T> requestDTO);
        public ResponseDTO<T> Add(RequestDTO<T> requestDTO);
        public ResponseDTO<T> Authorize(RequestDTO<T> requestDTO);
        public ResponseDTO<T> Update(RequestDTO<T> requestDTO);
        public ResponseDTO<T> Delete(RequestDTO<T> requestDTO);
    }
}
