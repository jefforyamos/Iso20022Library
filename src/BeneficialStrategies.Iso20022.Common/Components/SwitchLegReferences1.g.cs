﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SwitchLegReferences1.  ISO2002 ID# _RGg6Idp-Ed-ak6NoX_4Aeg_-513972542.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a switch leg that is rejected or repaired.
/// </summary>
[DataContract]
[XmlType]
public partial record SwitchLegReferences1
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [DataMember]
    public required IsoMax35Text RedemptionLegIdentification { get; init; } 
    /// <summary>
    /// Unique technical identifier for an instance of a leg within a switch.
    /// </summary>
    [DataMember]
    public required IsoMax35Text SubscriptionLegIdentification { get; init; } 
    /// <summary>
    /// Additional information about the reason for the rejection of a leg.
    /// </summary>
    [DataMember]
    public IsoMax350Text? LegRejectionReason { get; init; } 
    /// <summary>
    /// Elements from the original switch order that have been repaired so that the switch order can be accepted.
    /// </summary>
    [DataMember]
    public RepairedConditions3? RepairedConditions { get; init; } 
    /// <summary>
    /// Account identification of the switch leg that is rejected or repaired.
    /// </summary>
    [DataMember]
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Financial instrument identification of the switch leg that is rejected or repaired.
    /// </summary>
    [DataMember]
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    
    #nullable disable
}
