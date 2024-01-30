﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedAmount12.  ISO2002 ID# _gtlD0YokEeSaAcF2oE2GNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts of the withdrawal transaction.
/// </summary>
public partial record DetailedAmount12
{
    #nullable enable
    
    /// <summary>
    /// Amount to be dispensed by the ATM after the approval of the withdrawal transaction.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount AmountToDispense { get; init; } 
    /// <summary>
    /// Currency of the amount to dispense when different from the base currency of the ATM.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Withdrawal fees, accepted by the customer.
    /// </summary>
    public DetailedAmount13? Fees { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Amount of the donation.
    /// </summary>
    public DetailedAmount13? Donation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
