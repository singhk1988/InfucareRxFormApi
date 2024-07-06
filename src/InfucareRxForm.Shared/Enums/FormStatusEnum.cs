using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace InfucareRxForm.Shared.Enums;

/// <summary>
/// Enum for the status of the form response.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FormStatusEnum
{
    /// <summary>
    /// The form response is in draft state.
    /// </summary>
    [EnumMember(Value = "Draft")]
    Draft,

    /// <summary>
    /// The form response is pending.
    /// </summary>
    [EnumMember(Value = "Pending")]
    Pending,

    /// <summary>
    /// The form response is currently being reviewed.
    /// </summary>
    [EnumMember(Value = "InReview")]
    InReview,

    /// <summary>
    /// The form response is completed.
    /// </summary>
    [EnumMember(Value = "Completed")]
    Completed
}