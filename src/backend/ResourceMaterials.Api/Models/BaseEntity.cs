using System;
using System.Runtime.Serialization;

namespace ResourceMaterials.Api.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DataMember]
        public Guid Id { get; private set; }
        /// <summary>
        /// Наименование
        /// </summary>
        [DataMember]
        public string Name { get; private set; }
        /// <summary>
        /// Код внешней системы
        /// </summary>
        [DataMember]
        public string ExtCode { get; private set; }
        /// <summary>
        /// Код в системе
        /// </summary>
        [DataMember]
        public string Code { get; private set; }
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="code">Код</param>
        /// <param name="name">Наименование</param>
        /// <param name="extCode">Код внешней системы</param>
        public BaseEntity(string code, string extCode, string name)
        {
            Name = name;
            ExtCode = extCode;
            Code = code;
            Id = Guid.NewGuid();
        }
    }
}