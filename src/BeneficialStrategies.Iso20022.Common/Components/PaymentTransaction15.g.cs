﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction15.  ISO2002 ID# _VYshBdp-Ed-ak6NoX_4Aeg_-1954007689.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
public partial record PaymentTransaction15
{
    #nullable enable
    
    /// <summary>
    /// Amount of money to be transferred between the debtor and creditor before bank transaction charges.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the first agent expects the cash to be available to the final agent.
    /// </summary>
    public IsoISODate? SettlementDate { get; init; } 
    /// <summary>
    /// Choice between types of payment instrument, ie, cheque, credit transfer or investment account.
    /// </summary>
    public IPaymentInstrument7Choice? PaymentInstrument { get; init; } 
    
    #nullable disable
}
