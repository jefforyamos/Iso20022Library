﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Value.  ISO2002 ID# _SVDJ0dp-Ed-ak6NoX_4Aeg_-76711377.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
public partial record Value
{
    #nullable enable
    
    /// <summary>
    /// Specifies the amount in the base currency of the receiver.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount BaseCurrencyItem { get; init; } 
    /// <summary>
    /// Specifies the amount in another currency.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? AlternateCurrencyItem { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
