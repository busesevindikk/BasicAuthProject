using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserType
    {
        [EnumMember(Value = "student")]
        Student = 1,

        [EnumMember(Value = "teacher")]
        Teacher = 2
    }
}
