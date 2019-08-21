using System.Runtime.Serialization;

namespace ResourceMaterials.Api.Models.Types
{
    /// <summary>
    /// Тип характеристики
    /// </summary>
    public class CharacteristicType : BaseEntity
    {
        /// <summary>
        /// Описание
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        public CharacteristicType(string code, string extCode, string name) : base(code, extCode, name)
        {
        }
    }
}