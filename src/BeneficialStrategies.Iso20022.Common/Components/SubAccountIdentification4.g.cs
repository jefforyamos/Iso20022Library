﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification4.  ISO2002 ID# _VBAZy9p-Ed-ak6NoX_4Aeg_-1432964190.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
/// </summary>
public partial record SubAccountIdentification4
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IAccountIdentificationFormatChoice Identification { get; init; } 
    /// <summary>
    /// Indicates whether there is activity reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    public InvestmentFundTransactionsByFund1? TransactionOnSubAccount { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
