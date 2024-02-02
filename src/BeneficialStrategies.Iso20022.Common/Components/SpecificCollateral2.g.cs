﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SpecificCollateral2.  ISO2002 ID# _u1WsobcREeabfchHYoktpA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Repurchase agreement where a single, pre defined, financial instrument is sold and repurchased.
/// </summary>
[DataContract]
[XmlType]
public partial record SpecificCollateral2
{
    #nullable enable
    
    /// <summary>
    /// Identification of collateral placed as security for repo.
    /// </summary>
    [DataMember]
    public required FinancialInstrument59 FinancialInstrumentIdentification { get; init; } 
    
    #nullable disable
}
