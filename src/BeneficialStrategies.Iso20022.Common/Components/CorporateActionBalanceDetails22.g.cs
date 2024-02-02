﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionBalanceDetails22.  ISO2002 ID# _5N4a5SqdEeObprHJy8Zrxg.
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
public partial record CorporateActionBalanceDetails22
{
    #nullable enable
    
    /// <summary>
    /// Balance to which the payment applies (less or equal to the total eligible balance).
    /// </summary>
    [DataMember]
    public required BalanceFormat1Choice_ ConfirmedBalance { get; init; } 
    /// <summary>
    /// Total balance of securities eligible for this corporate action event. The entitlement calculation is based on this balance.
    /// </summary>
    [DataMember]
    public TotalEligibleBalanceFormat1? TotalEligibleBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are blocked.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? BlockedBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that have been borrowed from another party.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? BorrowedBalance { get; init; } 
    /// <summary>
    /// Balance of securities that belong to a third party and that are held for the purpose of collateralisation.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? CollateralInBalance { get; init; } 
    /// <summary>
    /// Balance of securities that belong to the safekeeping account indicated within this message, and are deposited with a third party for the purpose of collateralisation.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? CollateralOutBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that have been loaned to a third party.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? OnLoanBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are pending delivery.
    /// </summary>
    [DataMember]
    public ValueList<BalanceFormat3Choice_> PendingDeliveryBalance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Balance of financial instruments that are pending receipt.
    /// </summary>
    [DataMember]
    public ValueList<BalanceFormat3Choice_> PendingReceiptBalance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Balance of financial instruments currently being processed by the institution responsible for registering the new beneficial owner (or nominee).
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? OutForRegistrationBalance { get; init; } 
    /// <summary>
    /// Balance of securities representing only settled transactions; pending transactions not included.
    /// </summary>
    [DataMember]
    public ValueList<BalanceFormat3Choice_> SettlementPositionBalance { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Balance of financial instruments that remain registered in the name of the prior beneficial owner.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? StreetPositionBalance { get; init; } 
    /// <summary>
    /// Balance of securities based on trade date, for example, includes all pending transactions in addition to the balance of settled transactions.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? TradeDatePositionBalance { get; init; } 
    /// <summary>
    /// Balance of physical securities that are in the process of being transferred from one depository/agent to another.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? InTransshipmentBalance { get; init; } 
    /// <summary>
    /// Balance of financial instruments that are registered (in the name of a nominee name or of the beneficial owner).
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? RegisteredBalance { get; init; } 
    /// <summary>
    /// Balance that has been affected by the process run through the event.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? AffectedBalance { get; init; } 
    /// <summary>
    /// Balance that has not been affected by the process run through the event.
    /// </summary>
    [DataMember]
    public BalanceFormat1Choice_? UnaffectedBalance { get; init; } 
    
    #nullable disable
}
