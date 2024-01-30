﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Reference10.  ISO2002 ID# _Q_qrR9p-Ed-ak6NoX_4Aeg_-1068514335.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional references linked to the order modification request.
/// </summary>
public partial record Reference10
{
    #nullable enable
    
    /// <summary>
    /// Client order identification of the previous non-rejected order (not the initial order of the day) when cancelling or replacing an order.
    /// </summary>
    public required IsoMax35Text OriginalClientOrderIdentification { get; init; } 
    /// <summary>
    /// TransactionTime of the last state change that occurred to the original order. The original order modification time is provided as an optional field in the order modification request to identify that the state of the order has not changed since the request was issued.
    /// </summary>
    public IsoISODateTime? OriginalOrderModificationTime { get; init; } 
    
    #nullable disable
}
