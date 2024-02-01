﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OnLoanBalance.  ISO2002 ID# _3Aqo2aIQEeS6IulNYwkZBg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionUnallocatedBalanceSD2Choice;

/// <summary>
/// Quantity of securities in the sub-balance.
/// </summary>
public partial record OnLoanBalance : CorporateActionUnallocatedBalanceSD2Choice_
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required FinancialInstrumentQuantity15Choice_ Quantity { get; init; } 
    #nullable disable
}
