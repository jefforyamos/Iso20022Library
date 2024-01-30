﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails72.  ISO2002 ID# _oUNkYSW6EeOslcz0TJwprQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
public partial record SettlementDetails72
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    public IsoYesNoIndicator? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    public IPriorityNumeric1Choice? Priority { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    public ISettlementTransactionCondition7Choice? SettlementTransactionCondition { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    public ISettlingCapacity4Choice? SettlingCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification20? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public ISecuritiesRTGS1Choice? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    public IBeneficialOwnership1Choice? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    public ICashSettlementSystem1Choice? CashClearingSystem { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    public ITaxCapacityParty1Choice? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    public IMarketClientSide1Choice? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the foreign exchange standing instruction in place should apply.
    /// </summary>
    public IFXStandingInstruction1Choice? FXStandingInstruction { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    public IBlockTrade1Choice? BlockTrade { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    public IRestriction1Choice? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    public ISettlementSystemMethod1Choice? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    public INettingEligibility1Choice? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    public ICentralCounterPartyEligibility1Choice? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    public ITracking1Choice? Tracking { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    public IAutomaticBorrowing1Choice? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    
    #nullable disable
}
