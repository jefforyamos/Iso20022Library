﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalGroupHeader2.  ISO2002 ID# _sm76wFkyEeGeoaLUQk__nA_-556027435.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the original group, to which the message refers.
/// </summary>
public partial record OriginalGroupHeader2
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    public PaymentReturnReason1? ReturnReasonInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
