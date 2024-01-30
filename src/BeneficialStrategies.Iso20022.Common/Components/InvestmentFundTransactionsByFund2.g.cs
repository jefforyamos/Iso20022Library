﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentFundTransactionsByFund2.  ISO2002 ID# _Scf1qNp-Ed-ak6NoX_4Aeg_-1907610515.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Investment fund transactions for a specific financial instrument.
/// </summary>
public partial record InvestmentFundTransactionsByFund2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    public required ISecurityIdentification3Choice Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Additional information about a financial instrument to help identify the instrument.
    /// </summary>
    public IsoMax35Text? SupplementaryIdentification { get; init; } 
    /// <summary>
    /// Form, ie, ownership, of the security, eg, registered or bearer.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, 'Class A', 'Class 2'.
    /// </summary>
    public IsoMax35Text? ClassType { get; init; } 
    /// <summary>
    /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
    /// </summary>
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    /// <summary>
    /// Process of buying, selling, switching or transferring fund units.
    /// </summary>
    public InvestmentFundTransaction3? TransactionDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Balance of the financial instrument for this specific statement page.
    /// </summary>
    public PaginationBalance1? BalanceByPage { get; init; } 
    
    #nullable disable
}
