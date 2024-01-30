﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalNotification5.  ISO2002 ID# _sg1SwlkyEeGeoaLUQk__nA_-453347482.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the original notification and to provide the status.
/// </summary>
public partial record OriginalNotification5
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original sender, to unambiguously identify the original notification to receive message.
    /// </summary>
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    /// <summary>
    /// Identification of the original notification.
    /// </summary>
    public required IsoMax35Text OriginalNotificationIdentification { get; init; } 
    /// <summary>
    /// Specifies the status of the notification in a coded form.
    /// </summary>
    public NotificationStatus3Code? NotificationStatus { get; init; } 
    /// <summary>
    /// Further details of the notification status.
    /// </summary>
    public IsoMax140Text? AdditionalStatusInformation { get; init; } 
    /// <summary>
    /// Identifies the original notification item and provides the status.
    /// </summary>
    public OriginalNotificationReference3? OriginalNotificationReference { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
