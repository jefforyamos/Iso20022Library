﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTerms2.  ISO2002 ID# _QIrY5tp-Ed-ak6NoX_4Aeg_739233613.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the beneficiary's account information for the settlement of a purchase of goods or services.
/// </summary>
public partial record SettlementTerms2
{
    #nullable enable
    
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of an account owner, and posts the transaction into the account.
    /// </summary>
    public IFinancialInstitutionIdentification4Choice? CreditorAgent { get; init; } 
    /// <summary>
    /// Account to be credited as a result of an instruction.
    /// </summary>
    public required CashAccount7 CreditorAccount { get; init; } 
    
    #nullable disable
}
