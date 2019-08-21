using ResourceMaterials.Api.Models.Types;
using System.Runtime.Serialization;

namespace ResourceMaterials.Api.Models
{
    /// <summary>
    /// Характеристика
    /// </summary>
    public class Characteristic : BaseEntity
    {
        /// <summary>
        /// Тип характеристики
        /// </summary>
        [DataMember]
        public CharacteristicType Type { get; private set; }

        public Characteristic(string code, string extCode, string name, CharacteristicType type) : base(code, extCode, name)
        {
            Type = type;
        }
    }
}