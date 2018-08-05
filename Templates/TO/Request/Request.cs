using Prodesp.Gsnet.Core.TO.Request;
using System;
using System.Runtime.Serialization;

namespace [NAMESPACE].TO.Request
{
    [Serializable]
    [DataContract(Name = "[ENTITY]", Namespace = "[NAMESPACE].TO.Request")]
    public class [ENTITY] : SingleRequest<[ENTITY]RequestData>
    {
        public [ENTITY]() : base()
        {
            this.Data = new [ENTITY]RequestData();
        }
    }
}
