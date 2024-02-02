﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMovement11.  ISO2002 ID# _sWEhdYpIEeaNTaanBSMWmg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the collateral movement direction that is a delivery and optionally a return.
/// </summary>
[DataContract]
[XmlType]
public partial record CollateralMovement11
{
    #nullable enable
    
    /// <summary>
    /// Provides the collateral movement direction that is a delivery only.
    /// </summary>
    [DataMember]
    public required Collateral16 Deliver { get; init; } 
    /// <summary>
    /// Provides the collateral movement direction that is a return only.
    /// </summary>
    [DataMember]
    public Collateral17? Return { get; init; } 
    
    #nullable disable
}
