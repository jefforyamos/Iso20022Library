﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDetails103.  ISO2002 ID# _5TJ-V5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of settlement of a transaction.
/// </summary>
public partial record SettlementDetails103
{
    #nullable enable
    
    /// <summary>
    /// Conditions under which the order/trade is to be settled.
    /// </summary>
    public ISettlementTransactionCondition21Choice? SettlementTransactionCondition { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Specifies whether registration should occur upon receipt.
    /// </summary>
    public IRegistration11Choice? Registration { get; init; } 
    /// <summary>
    /// Regulatory restrictions applicable to a security.
    /// </summary>
    public IRestriction6Choice? LegalRestrictions { get; init; } 
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    public ISecuritiesRTGS5Choice? SecuritiesRTGS { get; init; } 
    /// <summary>
    /// Specifies whether the settlement instruction is to be settled through the default or the alternate settlement system.
    /// </summary>
    public ISettlementSystemMethod5Choice? SettlementSystemMethod { get; init; } 
    /// <summary>
    /// Tax role capacity of the instructing party.
    /// </summary>
    public ITaxCapacityParty5Choice? TaxCapacity { get; init; } 
    /// <summary>
    /// Specifies the stamp duty type or exemption reason applicable to the settlement transaction.
    /// </summary>
    public GenericIdentification47? StampDutyTaxBasis { get; init; } 
    
    #nullable disable
}
