﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentDetails29.  ISO2002 ID# _yV_1kaOAEeeDTpy0mhI4TQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
[DataContract]
[XmlType]
public partial record FinancialInstrumentDetails29
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [DataMember]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [DataMember]
    public FinancialInstrumentAttributes92? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Identification of the sub-balance.
    /// </summary>
    [DataMember]
    public ValueList<IntraPositionDetails45> SubBalance { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
