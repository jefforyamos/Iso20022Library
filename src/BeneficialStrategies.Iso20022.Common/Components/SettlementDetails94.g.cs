﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails94.  ISO2002 ID# _RcXn_TqEEeWVrPy0StzzSg.
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
public partial record SettlementDetails94
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [DataMember]
    public SecuritiesTransactionType21Choice_? SecuritiesTransactionType { get; init; } 
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    [DataMember]
    public ValueList<SettlementTransactionCondition16Choice_> SettlementTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether there is change of beneficial ownership.
    /// </summary>
    [DataMember]
    public BeneficialOwnership4Choice_? BeneficialOwnership { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
    /// </summary>
    [DataMember]
    public CentralCounterPartyEligibility4Choice_? CCPEligibility { get; init; } 
    /// <summary>
    /// Specifies the reason of a delivery return.
    /// </summary>
    [DataMember]
    public DeliveryReturn3Choice_? DeliveryReturnReason { get; init; } 
    /// <summary>
    /// Specifies the category of cash clearing system, for example, cheque clearing.
    /// </summary>
    [DataMember]
    public CashSettlementSystem4Choice_? CashClearingSystem { get; init; } 
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the collateral movement.
    /// </summary>
    [DataMember]
    public ExposureType16Choice_? ExposureType { get; init; } 
    /// <summary>
    /// Specifies whether the forex standing instruction in place should apply.
    /// </summary>
    [DataMember]
    public FXStandingInstruction4Choice_? FXStandingInstruction { get; init; } 
    /// <summary>
    /// Specifies if an instruction is for a market side or a client side transaction.
    /// </summary>
    [DataMember]
    public MarketClientSide4Choice_? MarketClientSide { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is eligible for netting.
    /// </summary>
    [DataMember]
    public NettingEligibility4Choice_? NettingEligibility { get; init; } 
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    [DataMember]
    public Registration9Choice_? Registration { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    [DataMember]
    public Restriction5Choice_? LegalRestrictions { get; init; } 
    /// <summary>
    /// Role of a party in the settlement of the transaction.
    /// </summary>
    [DataMember]
    public SettlingCapacity7Choice_? SettlingCapacity { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    [DataMember]
    public TaxCapacityParty4Choice_? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    [DataMember]
    public GenericIdentification30? StampDutyTaxBasis { get; init; } 
    /// <summary>
    /// Specifies whether the loan and/or collateral is tracked.
    /// </summary>
    [DataMember]
    public Tracking4Choice_? Tracking { get; init; } 
    /// <summary>
    /// Specifies whether physical settlement may be executed using a letter of guarantee or if the physical certificates should be used.
    /// </summary>
    [DataMember]
    public LetterOfGuarantee4Choice_? LetterOfGuarantee { get; init; } 
    /// <summary>
    /// Specifies whether, for a securities lending/borrowing settlement transaction, the lender will instruct the return leg as agreed with the borrower.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? ReturnLeg { get; init; } 
    /// <summary>
    /// Specifies whether a third party is allowed to modify or cancel the transaction.
    /// </summary>
    [DataMember]
    public ModificationCancellationAllowed4Choice_? ModificationCancellationAllowed { get; init; } 
    /// <summary>
    /// Specifies whether securities should be included in the pool of securities eligible for collateral purposes.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? EligibleForCollateral { get; init; } 
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [DataMember]
    public GenericIdentification30? SecuritiesSubBalanceType { get; init; } 
    /// <summary>
    /// Specifies the cash sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [DataMember]
    public GenericIdentification30? CashSubBalanceType { get; init; } 
    
    #nullable disable
}
