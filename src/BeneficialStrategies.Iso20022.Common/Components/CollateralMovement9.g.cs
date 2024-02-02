﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMovement9.  ISO2002 ID# _WPYN8ILaEeWrrO9HojbPQA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of collateral that will be delivered and the date to be reported.
/// </summary>
[DataContract]
[XmlType]
public partial record CollateralMovement9
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of collateral.
    /// </summary>
    [DataMember]
    public required CollateralType1Code CollateralType { get; init; } 
    /// <summary>
    /// Date by which the collateral movement must be executed.
    /// </summary>
    [DataMember]
    public IsoISODate? Date { get; init; } 
    
    #nullable disable
}
