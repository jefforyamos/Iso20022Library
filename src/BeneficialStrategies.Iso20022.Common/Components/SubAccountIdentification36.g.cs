﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification36.  ISO2002 ID# _2-lV4Qf9EeSaceXTzyiZRg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account to or from which a securities entry is made.
/// </summary>
public partial record SubAccountIdentification36
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required AccountIdentificationFormatChoice_ Identification { get; init; } 
    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    public InvestmentFundTransactionsByFund3[] TransactionOnSubAccount { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
