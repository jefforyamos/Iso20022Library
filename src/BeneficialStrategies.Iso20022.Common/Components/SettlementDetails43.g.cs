﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails43.  ISO2002 ID# _A1IGoNokEeC60axPepSq7g_1106734346.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementDetails43
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the trade is to be settled as principal or netted off against another trade.
    /// </summary>
    [DataMember]
    public required SettlementTransactionType1Choice_ SettlementTransactionType { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? HoldIndicator { get; init; } 
    /// <summary>
    /// Specifies whether the transaction is to be executed with a high priority.
    /// </summary>
    [DataMember]
    public PriorityNumeric3Choice_? Priority { get; init; } 
    /// <summary>
    /// Specifies if the Electronic Trade Confirmation (ETC) service provider is to generate or not a settlement instruction.
    /// </summary>
    [DataMember]
    public SettlementInstructionGeneration1Choice_? SettlementInstructionGeneration { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [DataMember]
    public ValueList<SettlementTransactionCondition11Choice_> SettlementTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [DataMember]
    public BeneficialOwnership3Choice_? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [DataMember]
    public BlockTrade3Choice_? BlockTrade { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [DataMember]
    public CentralCounterPartyEligibility3Choice_? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, eg, cheque clearing.
    /// </summary>
    [DataMember]
    public CashSettlementSystem3Choice_? CashClearingSystem { get; init; } 
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [DataMember]
    public ExposureType9Choice_? ExposureType { get; init; } 
    /// <summary>
    /// Specifies whether the forex standing instruction in place should apply.
    /// </summary>
    [DataMember]
    public FXStandingInstruction3Choice_? FXStandingInstruction { get; init; } 
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [DataMember]
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [DataMember]
    public MarketClientSide3Choice_? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [DataMember]
    public NettingEligibility3Choice_? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [DataMember]
    public Registration6Choice_? Registration { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [DataMember]
    public RepurchaseType11Choice_? RepurchaseType { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [DataMember]
    public Restriction3Choice_? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [DataMember]
    public SecuritiesRTGS3Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [DataMember]
    public SettlingCapacity3Choice_? SettlingCapacity { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [DataMember]
    public SettlementSystemMethod3Choice_? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [DataMember]
    public TaxCapacityParty3Choice_? TaxCapacity { get; init; } 
    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? StampDutyIndicator { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [DataMember]
    public GenericIdentification38? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [DataMember]
    public Tracking3Choice_? Tracking { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    [DataMember]
    public AutomaticBorrowing5Choice_? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [DataMember]
    public LetterOfGuarantee3Choice_? LetterOfGuarantee { get; init; } 
    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ReturnLeg { get; init; } 
    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    [DataMember]
    public ModificationCancellationAllowed3Choice_? ModificationCancellationAllowed { get; init; } 
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    
    #nullable disable
}
