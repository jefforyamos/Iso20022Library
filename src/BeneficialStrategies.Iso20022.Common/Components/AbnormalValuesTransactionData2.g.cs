﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AbnormalValuesTransactionData2.  ISO2002 ID# _x6yxOVyGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information about derivatives that were received on the day of generation of the report with action type ‘New’, ‘Position component’, ‘Modification’ or ‘Correction’ whose notional amount is greater than a threshold for that class of derivatives.
/// </summary>
public partial record AbnormalValuesTransactionData2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a transaction.
    /// </summary>
    public required TradeTransactionIdentification24 TransactionIdentification { get; init; } 
    /// <summary>
    /// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
    /// </summary>
    public NotionalAmountLegs5? NotionalAmount { get; init; } 
    /// <summary>
    /// Indicates for each leg of the transaction the total notional quantity of the underlying asset for the term of the transaction.
    /// </summary>
    public NotionalQuantityLegs5? NotionalQuantity { get; init; } 
    
    #nullable disable
}
