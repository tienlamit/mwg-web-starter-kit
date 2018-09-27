

using System;

namespace tgdd.service.BO
{
    [Serializable]
    public class ResultBo
    {
        public bool IsError { get; set; }
        public string Message { get; set; }
    }

    [Serializable]
    public class OrderResultBo
    {
        public long OrderId { get; set; }
        public bool IsError { get; set; }
        public string Message { get; set; }

        public OrderResultBo()
        {
            IsError = true;
            Message = string.Empty;
        }

        public OrderResultBo(string message)
        {
            Message = message;
        }
    }
}