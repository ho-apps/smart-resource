using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ResourceMaterials.Api.Models.Types;
using System.Runtime.Serialization;

namespace ResourceMaterials.Api.Models
{
    /// <summary>
    /// Ресурс
    /// </summary>
    public class Resource : BaseEntity
    {
        /// <summary>
        /// Тип
        /// </summary>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ResourceType Type { get; set; }

        public Resource(string code, string extCode, string name) : base(code, extCode, name)
        {
        }
    }
}