﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementTimeRequest1.  ISO2002 ID# _QHyBEdp-Ed-ak6NoX_4Aeg_564730971.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the requested settlement time of the instruction.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementTimeRequest1
{
    #nullable enable
    
    /// <summary>
    /// Time by which the funds must be credited, with confirmation, to the CLS Bank's account at the central bank, expressed in Central European Time (CET).
    /// </summary>
    [DataMember]
    public required IsoISOTime CLSTime { get; init; } 
    
    #nullable disable
}
