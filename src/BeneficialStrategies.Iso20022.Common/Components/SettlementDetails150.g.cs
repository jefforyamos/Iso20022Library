﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails150.  ISO2002 ID# _qxYEka3MEeey8N0JWnVPUw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
public partial record SettlementDetails150
{
    #nullable enable
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    public ISettlementTransactionCondition16Choice? SettlementTransactionCondition { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    public ISettlingCapacity7Choice? SettlingCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification30? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public ISecuritiesRTGS4Choice? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    public IRegistration9Choice? Registration { get; init; } 
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    public IBeneficialOwnership4Choice? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    public ICashSettlementSystem4Choice? CashClearingSystem { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    public ITaxCapacityParty4Choice? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    public IRepurchaseType22Choice? RepurchaseType { get; init; } 
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    public IMarketClientSide6Choice? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    public IBlockTrade4Choice? BlockTrade { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    public IRestriction5Choice? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    public ISettlementSystemMethod4Choice? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    public INettingEligibility4Choice? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    public ICentralCounterPartyEligibility4Choice? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    public ILetterOfGuarantee4Choice? LetterOfGuarantee { get; init; } 
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    
    #nullable disable
}
