﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionBalanceDetails4.  ISO2002 ID# _R9gMiNp-Ed-ak6NoX_4Aeg_-783579312.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Eligible and not eligible balance of securities for a corporate action event.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionBalanceDetails4
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [DataMember]
    public required Quantity3Choice_ TotalEligibleBalance { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [DataMember]
    public required BalanceFormat1Choice_ UninstructedBalance { get; init; } 
    /// <summary>
    /// Provides information about the total instructed balance.
    /// </summary>
    [DataMember]
    public required InstructedBalanceDetails1 TotalInstructedBalanceDetails { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? BlockedBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? BorrowedBalance { get; init; } 
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? CollateralInBalance { get; init; } 
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? CollateralOutBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? OnLoanBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? OutForRegistrationBalance { get; init; } 
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? SettlementPositionBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? StreetPositionBalance { get; init; } 
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? TradeDatePositionBalance { get; init; } 
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? InTransshipmentBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? RegisteredBalance { get; init; } 
    /// <summary>
    /// Position that account holders should return to the account servicer to participate in the event or to fulfil their obligation for the event to be complete, for example, return of securities for late announced drawing.
    /// </summary>
    [DataMember]
    public SignedQuantityFormat2? ObligatedBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [DataMember]
    public ValueList<PendingBalance1> PendingDeliveryBalance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [DataMember]
    public ValueList<PendingBalance1> PendingReceiptBalance { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
