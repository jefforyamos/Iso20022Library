﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection31.  ISO2002 ID# _nAYJZfNBEeCuA5Tr22BnwA_-22079.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[DataContract]
[XmlType]
public partial record AmountAndDirection31
{
    #nullable enable
    
    /// <summary>
    /// Currency and value.
    /// </summary>
    [DataMember]
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [DataMember]
    public ShortLong1Code? ShortLongIndicator { get; init; } 
    
    #nullable disable
}
