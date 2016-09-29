using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgtWsProxy
{
    public class DgtResponse
    {
        public DgtResponseState State { get; set; }

        public string FileName { get; set; }

        public string FileContent { get; set; }
    }

    public enum DgtResponseState
    {
        Ok,
        Multipart,
        BadRequest
    }
}
