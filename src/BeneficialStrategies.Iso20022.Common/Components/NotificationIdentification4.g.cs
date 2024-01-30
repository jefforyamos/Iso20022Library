﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NotificationIdentification4.  ISO2002 ID# _cfrdR5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the identification and the creation date of a notification.
/// </summary>
public partial record NotificationIdentification4
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the last notification document (message) assigned by the sender of the document.
    /// </summary>
    public required IsoRestrictedFINXMax16Text Identification { get; init; } 
    /// <summary>
    /// Date and time at which the last notification document (message) was created by the sender.
    /// </summary>
    public IDateAndDateTimeChoice? CreationDateTime { get; init; } 
    
    #nullable disable
}
