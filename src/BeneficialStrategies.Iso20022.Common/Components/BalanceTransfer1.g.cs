﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceTransfer1.  ISO2002 ID# _5yEaVA_QEeejZrQVdmNFGg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that enables any payments made in connection with the fulfilment of an account switch to be reconciled by the relevant account servicer with the associated request.
/// </summary>
public partial record BalanceTransfer1
{
    #nullable enable
    
    /// <summary>
    /// Reference that enables the creditor to reconcile a payment received through a different payment channel with the payment request.
    /// </summary>
    public BalanceTransferReference1? BalanceTransferReference { get; init; } 
    /// <summary>
    /// Contains details of the clearance and settlement method chosen to make the appropriate payment from account servicer to account servicer in order to transfer the positive or negative closing balance of the old account to the new account.
    /// </summary>
    public ISettlementMethod1Choice? BalanceTransferMethod { get; init; } 
    /// <summary>
    /// Maximum value that the new account servicer will pay to the old account servicer when the closing balance on the old account is negative.
    /// </summary>
    public BalanceTransferFundingLimit1? BalanceTransferFundingLimit { get; init; } 
    
    #nullable disable
}
