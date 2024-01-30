﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingGroupInformation1.  ISO2002 ID# _RrBVYtp-Ed-ak6NoX_4Aeg_884871107.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identification, as assigned by the first instructing agent, to unambiguously identify the group of transactions.
/// </summary>
public partial record UnderlyingGroupInformation1
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
    /// Original channel used for the delivery of the message, to allow the receiver of the request to locate the payment with greater ease.
    /// </summary>
    public IsoMax35Text? OriginalMessageDeliveryChannel { get; init; } 
    
    #nullable disable
}
