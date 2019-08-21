using System;
using System.Runtime.Serialization;

namespace ResourceMaterials.Api.Models
{
    public class ResourceGroup : BaseEntity
    {
        /// <summary>
        /// Идентификатор предка
        /// </summary>
        [DataMember]
        public Guid? ParentId { get; private set; }
        public ResourceGroup(string code, string extCode, string name, Guid? parentId) : base(code, extCode, name)
        {
            ParentId = parentId;
        }
    }
}