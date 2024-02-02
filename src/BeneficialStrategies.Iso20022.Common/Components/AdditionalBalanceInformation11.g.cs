﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalBalanceInformation11.  ISO2002 ID# _vs6AsQ0tEeK9as54HthO0w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Subbalances providing additional information on a specific position but that is not to be accounted for in the building of the aggregate balance, for example, registered.
/// </summary>
[DataContract]
[XmlType]
public partial record AdditionalBalanceInformation11
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [DataMember]
    public required SubBalanceType6Choice_ SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [DataMember]
    public required SubBalanceQuantity3Choice_ Quantity { get; init; } 
    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    [DataMember]
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [DataMember]
    public ValueList<QuantityBreakdown23> QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
