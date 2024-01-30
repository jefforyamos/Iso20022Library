﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountingStatementOfHoldings1.  ISO2002 ID# _UxD5R9p-Ed-ak6NoX_4Aeg_-1253958762.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an accounting statement of holdings.
/// </summary>
public partial record AccountingStatementOfHoldings1
{
    #nullable enable
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    public required Pagination MessagePagination { get; init; } 
    /// <summary>
    /// General information related to the custody statement of holdings that is being cancelled.
    /// </summary>
    public Statement4? StatementGeneralDetails { get; init; } 
    /// <summary>
    /// The safekeeping or investment account of the statement that is being cancelled.
    /// </summary>
    public SafekeepingAccount1? AccountDetails { get; init; } 
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    public AggregateBalanceInformation2? BalanceForAccount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    public SubAccountIdentification2? SubAccountDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    public TotalValueInPageAndStatement? TotalValues { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
