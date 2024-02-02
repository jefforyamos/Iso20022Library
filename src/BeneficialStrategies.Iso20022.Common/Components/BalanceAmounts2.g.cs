﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceAmounts2.  ISO2002 ID# _SVywsdp-Ed-ak6NoX_4Aeg_-1968542123.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts linked to a securities balance, for example, holding value.
/// </summary>
[DataContract]
[XmlType]
public partial record BalanceAmounts2
{
    #nullable enable
    
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    [DataMember]
    public required AmountAndDirection6 HoldingValue { get; init; } 
    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    [DataMember]
    public AmountAndDirection6? BookValue { get; init; } 
    /// <summary>
    /// Difference between holding value and the book value.
    /// </summary>
    [DataMember]
    public AmountAndDirection6? UnrealisedGainLoss { get; init; } 
    
    #nullable disable
}
