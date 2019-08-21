using System;
using System.Runtime.Serialization;

namespace ResourceMaterials.Api.Models
{
    /// <summary>
    /// Единица измерения
    /// </summary>
    public class Measure : BaseEntity
    {
        /// <summary>
        /// Точность
        /// </summary>
        [DataMember]
        public long Accuracy { get; private set; }
        /// <summary>
        /// Идентификатор предка
        /// </summary>
        [DataMember]
        public Guid? ParentId { get; private set; }
        /// <summary>
        /// Описание
        /// </summary>
        [DataMember]
        public string Description { get; private set; }
        
        public Measure(string code, string extCode, long accuracy, Guid? parentId, string name, string description) : base(code, extCode, name)
        {
            Accuracy = accuracy;
            ParentId = parentId;
            Description = description;
        }
    }
}