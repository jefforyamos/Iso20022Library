﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarginCalculation1.  ISO2002 ID# _-dwqLKMOEeCojJW5vEuTEQ_1443454160.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the total margin amount, the collateral amount on deposit and the total minimum requirement that used to calculate the margin result, either an excess or a deficit.
/// </summary>
[DataContract]
[XmlType]
public partial record MarginCalculation1
{
    #nullable enable
    
    /// <summary>
    /// Total margin requirement (expressed in the reporting currency) that must be provided by the clearing member to the central counterparty. This is the total requirement calculated to cover the initial margin and the variation margin.
    /// </summary>
    [DataMember]
    public required AmountAndDirection20 TotalMarginAmount { get; init; } 
    /// <summary>
    /// Provides details on the valuation of the collateral on deposit.
    /// </summary>
    [DataMember]
    public ValueList<Collateral6> CollateralOnDeposit { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Minimum requirement (expressed in the reporting currency) for a participant if their requirement falls below a specific amount set by the central counterparty.
    /// </summary>
    [DataMember]
    public IsoActiveCurrencyAndAmount? MinimumRequirementDeposit { get; init; } 
    /// <summary>
    /// Provide details on the margin result taking into consideration the total margin amount and the minimum requirements deposit.
    /// </summary>
    [DataMember]
    public MarginResult1Choice_? MarginResult { get; init; } 
    
    #nullable disable
}
