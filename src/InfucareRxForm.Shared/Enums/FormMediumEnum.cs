using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace InfucareRxForm.Shared.Enums;

/// <summary>
/// Enum for the medium through which the form response was sent.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FormMedium
{
    /// <summary>
    /// The form response was sent digitally.
    /// </summary>
    [EnumMember(Value = "Digital")]
    Digital,

    /// <summary>
    /// The form response was sent via mail.
    /// </summary>
    [EnumMember(Value = "Mail")]
    Mail
}