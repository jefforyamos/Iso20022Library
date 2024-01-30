﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails70.  ISO2002 ID# _bMtl4ST6EeOSHvJr_wacAw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
public partial record SettlementDetails70
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction was executed with a high priority.
    /// </summary>
    public IPriorityNumeric1Choice? Priority { get; init; } 
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    public required ISecuritiesTransactionType10Choice SecuritiesTransactionType { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade was to be settled.
    /// </summary>
    public ISettlementTransactionCondition12Choice? SettlementTransactionCondition { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether partial settlement was allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether there was change of beneficial ownership.
    /// </summary>
    public IBeneficialOwnership1Choice? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction was a block parent or child.
    /// </summary>
    public IBlockTrade1Choice? BlockTrade { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction was CCP (Central Counterparty) eligible.
    /// </summary>
    public ICentralCounterPartyEligibility1Choice? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    public ICashSettlementSystem1Choice? CashClearingSystem { get; init; } 
    /// <summary>
    /// Specifies the underlying business area/type of trade having caused the collateral movement.
    /// </summary>
    public IExposureType10Choice? ExposureType { get; init; } 
    /// <summary>
    /// Specifies if an instruction was for a market side or a client side transaction.
    /// </summary>
    public IMarketClientSide1Choice? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction was eligible for netting.
    /// </summary>
    public INettingEligibility1Choice? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether registration was to occur upon receipt.
    /// </summary>
    public IRegistration1Choice? Registration { get; init; } 
    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// </summary>
    public IRepurchaseType3Choice? RepurchaseType { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    public IRestriction1Choice? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction was to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public ISecuritiesRTGS1Choice? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    public ISettlingCapacity4Choice? SettlingCapacity { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction was to be settled through the default or the alternate settlement system.
    /// </summary>
    public ISettlementSystemMethod1Choice? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    public ITaxCapacityParty1Choice? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification20? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    public IAutomaticBorrowing1Choice? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether physical settlement was executed using a letter of guarantee or if the physical certificates were used.
    /// </summary>
    public ILetterOfGuarantee1Choice? LetterOfGuarantee { get; init; } 
    /// <summary>
    /// Specifies whether securities were requested to be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public GenericIdentification20? SecuritiesSubBalanceType { get; init; } 
    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public GenericIdentification20? CashSubBalanceType { get; init; } 
    
    #nullable disable
}
