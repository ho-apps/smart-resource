using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ResourceMaterials.Api.Models.Types;

namespace ResourceMaterials.Api.Models
{
    public class ResourceGroupType : BaseEntity
    {
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ResourceType GroupType { get; set; }
        public ResourceGroupType(string code, string extCode, string name) : base(code, extCode, name)
        {
        }
    }
}