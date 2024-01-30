﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatementOfInvestmentFundTransactions1.  ISO2002 ID# _U2krYNp-Ed-ak6NoX_4Aeg_1424253677.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a statement of investment fund transactions.
/// </summary>
public partial record StatementOfInvestmentFundTransactions1
{
    #nullable enable
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    public required Pagination MessagePagination { get; init; } 
    /// <summary>
    /// General information related to the investment fund statement of transactions that is being cancelled.
    /// </summary>
    public Statement5? StatementGeneralDetails { get; init; } 
    /// <summary>
    /// Information related to an investment account of the statement that is being cancelled.
    /// </summary>
    public InvestmentAccount12? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Creation/cancellation of investment units on the books of the fund or its designated agent, as a result of executing an investment fund order.
    /// </summary>
    public InvestmentFundTransactionsByFund1? TransactionOnAccount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    public required SubAccountIdentification4 SubAccountDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
