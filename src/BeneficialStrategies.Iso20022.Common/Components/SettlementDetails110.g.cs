﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails110.  ISO2002 ID# _6SacnZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
public partial record SettlementDetails110
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction was executed with a high priority.
    /// </summary>
    public PriorityNumeric5Choice_? Priority { get; init; } 
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    public required SecuritiesTransactionType24Choice_ SecuritiesTransactionType { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade was to be settled.
    /// </summary>
    public SettlementTransactionCondition28Choice_[] SettlementTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether partial settlement was allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether there was change of beneficial ownership.
    /// </summary>
    public BeneficialOwnership5Choice_? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction was a block parent or child.
    /// </summary>
    public BlockTrade5Choice_? BlockTrade { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction was CCP (Central Counterparty) eligible.
    /// </summary>
    public CentralCounterPartyEligibility5Choice_? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    public CashSettlementSystem5Choice_? CashClearingSystem { get; init; } 
    /// <summary>
    /// Specifies the underlying business area/type of trade having caused the collateral movement.
    /// </summary>
    public ExposureType17Choice_? ExposureType { get; init; } 
    /// <summary>
    /// Specifies if an instruction was for a market side or a client side transaction.
    /// </summary>
    public MarketClientSide5Choice_? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction was eligible for netting.
    /// </summary>
    public NettingEligibility5Choice_? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether registration was to occur upon receipt.
    /// </summary>
    public Registration11Choice_? Registration { get; init; } 
    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// </summary>
    public RepurchaseType19Choice_? RepurchaseType { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    public Restriction6Choice_? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction was to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public SecuritiesRTGS5Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    public SettlingCapacity8Choice_? SettlingCapacity { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction was to be settled through the default or the alternate settlement system.
    /// </summary>
    public SettlementSystemMethod5Choice_? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    public TaxCapacityParty5Choice_? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification47? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Condition for automatic borrowing.
    /// </summary>
    public AutomaticBorrowing8Choice_? AutomaticBorrowing { get; init; } 
    /// <summary>
    /// Specifies whether physical settlement was executed using a letter of guarantee or if the physical certificates were used.
    /// </summary>
    public LetterOfGuarantee5Choice_? LetterOfGuarantee { get; init; } 
    /// <summary>
    /// Specifies whether securities were requested to be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public GenericIdentification47? SecuritiesSubBalanceType { get; init; } 
    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    public GenericIdentification47? CashSubBalanceType { get; init; } 
    
    #nullable disable
}
