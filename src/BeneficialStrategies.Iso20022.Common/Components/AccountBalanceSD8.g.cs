﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountBalanceSD8.  ISO2002 ID# _doTs95EhEeajS_7NioJdVA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
public partial record AccountBalanceSD8
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Balance of all uncovered protect instructions across all options.
    /// </summary>
    public SignedQuantityFormat9? UncoveredProtectBalance { get; init; } 
    /// <summary>
    /// Position held in DTC segregated account also called account 18. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    public SignedQuantityFormat9? InvestmentUnpledgedBalance { get; init; } 
    /// <summary>
    /// Position held in DTC segregated account also called account 22. This position is not eligible for instruction processing but will be eligible for payment on mandatory events.
    /// </summary>
    public SignedQuantityFormat9? InvestmentPledgedBalance { get; init; } 
    /// <summary>
    /// Position held in DTC memo segregated account. This position is eligible for payment.
    /// </summary>
    public SignedQuantityFormat9? MemoSegregationBalance { get; init; } 
    
    #nullable disable
}
