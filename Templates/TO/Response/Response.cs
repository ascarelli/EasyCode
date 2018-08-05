using Prodesp.Gsnet.Core.TO.Response;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace [NAMESPACE].TO.Response
{
    [Serializable]
    [DataContract(Name = "[ENTITY]Response", Namespace = "[NAMESPACE].TO.Response")]
    public class [ENTITY]Response : SingleResponse<[ENTITY]ResponseData>
    {
        public [ENTITY]Response() : base()
        {
            this.Data = new [ENTITY]ResponseData();
        }
    }

    [Serializable]
    [DataContract(Name = "[ENTITY]ListaResponse", Namespace = "[NAMESPACE].TO.Response")]
    public class [ENTITY]ListaResponse : ListResponse<[ENTITY]ResponseData>
    {
        public [ENTITY]ListaResponse() : base()
        {
            this.Data = new List<[ENTITY]ResponseData>();
        }
    }
}
