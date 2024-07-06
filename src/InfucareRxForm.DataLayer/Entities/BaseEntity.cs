namespace InfucareRxForm.DataLayer.Entities;

/// <summary>
/// Represents a base entity with common properties.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Gets or sets the date and time when the entity was created <see cref="DateTime"/>.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was last modified <see cref="DateTime"/>.
    /// </summary>
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who created the entity.
    /// </summary>
    public long? CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the user who last modified the entity.
    /// </summary>
    public long? ModifiedBy { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the entity is marked as deleted.
    /// </summary>
    public bool IsDeleted { get; set; }
}
