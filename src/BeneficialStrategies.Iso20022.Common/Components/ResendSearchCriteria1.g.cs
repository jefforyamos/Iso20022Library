﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ResendSearchCriteria1.  ISO2002 ID# _jJzloO5NEeCisYr99QEiWA_840208955.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria to extract the message(s) which should be resent.
/// </summary>
public partial record ResendSearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Date of the business day of the requested messages the resend function is used for.
    /// </summary>
    public IsoISODate? BusinessDate { get; init; } 
    /// <summary>
    /// Independent counter for message sequence, which is available once per party technical address.|Specifies the identification sequence number for a specific couple sender/receiver.
    /// </summary>
    public IsoMax35Text? SequenceNumber { get; init; } 
    /// <summary>
    /// Unambiguously identifies the original business message, which was delivered by the business sender.
    /// </summary>
    public IsoMax35Text? OriginalMessageNameIdentification { get; init; } 
    /// <summary>
    /// String of characters that uniquely identifies the file, which was delivered by the sender.
    /// </summary>
    public IsoMax35Text? FileReference { get; init; } 
    /// <summary>
    /// Unique identification to unambiguously identify the recipient of the report message.
    /// </summary>
    public required PartyIdentification71Choice_ Recipient { get; init; } 
    
    #nullable disable
}
