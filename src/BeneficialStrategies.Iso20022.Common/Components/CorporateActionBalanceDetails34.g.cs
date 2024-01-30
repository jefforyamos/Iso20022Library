﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionBalanceDetails34.  ISO2002 ID# _chWQ75KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Eligible and not eligible balance of securities for a corporate action event.
/// </summary>
public partial record CorporateActionBalanceDetails34
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    public IQuantity22Choice? TotalEligibleBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    public IBalanceFormat7Choice? BlockedBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    public IBalanceFormat7Choice? BorrowedBalance { get; init; } 
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    public IBalanceFormat7Choice? CollateralInBalance { get; init; } 
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    public IBalanceFormat7Choice? CollateralOutBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    public IBalanceFormat7Choice? OnLoanBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    public IBalanceFormat7Choice? PendingDeliveryBalance { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    public IBalanceFormat7Choice? PendingReceiptBalance { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    public IBalanceFormat7Choice? OutForRegistrationBalance { get; init; } 
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    public IBalanceFormat7Choice? SettlementPositionBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    public IBalanceFormat7Choice? StreetPositionBalance { get; init; } 
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    public IBalanceFormat7Choice? TradeDatePositionBalance { get; init; } 
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    public IBalanceFormat7Choice? InTransshipmentBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    public IBalanceFormat7Choice? RegisteredBalance { get; init; } 
    
    #nullable disable
}
