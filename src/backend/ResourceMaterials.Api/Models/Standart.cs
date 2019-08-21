using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ResourceMaterials.Api.Models.Types;

namespace ResourceMaterials.Api.Models
{
    /// <summary>
    /// Стандарт
    /// </summary>
    public class Standart : BaseEntity
    {
        /// <summary>
        /// Версия
        /// </summary>
        [DataMember]
        public string Version { get; private set; }
        /// <summary>
        /// Описание
        /// </summary>
        [DataMember]
        public string Descritpion { get; private set; }
        /// <summary>
        /// Тип
        /// </summary>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public StandartType Type { get; set; }
        public Standart(string code, string extCode, string name, string version, string descritpion) : base(code, extCode, name)
        {
            Version = version;
            Descritpion = descritpion;
        }
    }
}