﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails143.  ISO2002 ID# _rVekIazwEeeBIMhGLpLUsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementDetails143
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction is on hold/blocked/frozen.
    /// </summary>
    [DataMember]
    public HoldIndicator6? HoldIndicator { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [DataMember]
    public ValueList<SettlementTransactionCondition16Choice_> SettlementTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [DataMember]
    public required SecuritiesTransactionType37Choice_ SecuritiesTransactionType { get; init; } 
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [DataMember]
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [DataMember]
    public GenericIdentification30? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [DataMember]
    public SecuritiesRTGS4Choice_? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [DataMember]
    public Registration9Choice_? Registration { get; init; } 
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [DataMember]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [DataMember]
    public ExposureType16Choice_? ExposureType { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [DataMember]
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [DataMember]
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies whether the rate is fixed, variable or a forfeit.
    /// </summary>
    [DataMember]
    public RepurchaseType22Choice_? RepurchaseType { get; init; } 
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [DataMember]
    public MarketClientSide6Choice_? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is a block parent or child.
    /// </summary>
    [DataMember]
    public BlockTrade4Choice_? BlockTrade { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [DataMember]
    public Restriction5Choice_? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    [DataMember]
    public SettlementSystemMethod4Choice_? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [DataMember]
    public NettingEligibility4Choice_? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [DataMember]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [DataMember]
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; } 
    /// <summary>
    /// Specifies whether partial settlement is allowed.
    /// </summary>
    [DataMember]
    public SettlementTransactionCondition5Code? PartialSettlementIndicator { get; init; } 
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    
    #nullable disable
}
