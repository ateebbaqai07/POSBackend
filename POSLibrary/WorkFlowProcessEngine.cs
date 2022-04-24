using POSInterface;
using POSModel;
using POSRepository.Interface;
using System;
using System.Transactions;

namespace POSLibrary
{
    public class WorkFlowProcessEngine<T> : IWorkFlowProcessEngine<T> where T : class
    {
        //public static ResponseDTO GetData(IRepository<T> _Repository, RequestDTO<T> _RequestDTO)
        //{
        //    return _Repository.Add(_RequestDTO);
        //}

        public ResponseDTO<T> Authorize(IRepository<T> _Repository, RequestDTO<T> _RequestDTO)
        {
            ResponseDTO<T> resp = new ResponseDTO<T>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    resp = _Repository.Authorize(_RequestDTO);
                }
            }
            catch (Exception ex)
            {
                //Log Exception
                resp.Result = false;

            }
            return resp;
        }

        public ResponseDTO<T> Add(IRepository<T> _Repository, RequestDTO<T> _RequestDTO)
        {
            ResponseDTO<T> resp = new ResponseDTO<T>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    resp = _Repository.Add(_RequestDTO);
                    if (resp.Result)
                    {
                        scope.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                //Log Exception
                resp.Result = false;

            }
            return resp;
        }

        public ResponseDTO<T> GetData(IRepository<T> _Repository, RequestDTO<T> _RequestDTO)
        {
            ResponseDTO<T> resp = new ResponseDTO<T>();
            try
            {
                resp = _Repository.Get(_RequestDTO);
            }
            catch (Exception ex)
            {
                //Log Exception
                resp.Result = false;
            }
            return resp;
        }

        public ResponseDTO<T> Update(IRepository<T> _Repository, RequestDTO<T> _RequestDTO)
        {
            ResponseDTO<T> resp = new ResponseDTO<T>();
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    resp = _Repository.Update(_RequestDTO);
                    if (resp.Result)
                    {
                        scope.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                //Log Exception
                resp.Result = false;

            }
            return resp;
        }
    }
}