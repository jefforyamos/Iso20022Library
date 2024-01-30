﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceInquiryRequest6.  ISO2002 ID# _PD2PQXG1Ee2TbaNWBpRZpQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies data element nexessary to request balance information.
/// </summary>
public partial record BalanceInquiryRequest6
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; } 
    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    public LoyaltyAccountRequest3? LoyaltyAccountRequest { get; init; } 
    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    public StoredValueRequest6? StoredValueAccountRequest { get; init; } 
    
    #nullable disable
}
