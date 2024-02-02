﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesSubBalanceTypeAndQuantityBreakdown1.  ISO2002 ID# _vZcQEP8IEeCKBMQETXEXKQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity breakdown information for a specific securities balance.
/// </summary>
[DataContract]
[XmlType]
public partial record SecuritiesSubBalanceTypeAndQuantityBreakdown1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the securities sub balance type indicator (example restriction type for a market infrastructure).
    /// </summary>
    [DataMember]
    public required SecuritiesBalanceType3Choice_ Type { get; init; } 
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series.
    /// </summary>
    [DataMember]
    public ValueList<QuantityBreakdown12> QuantityBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
