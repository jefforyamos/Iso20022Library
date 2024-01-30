﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementReportingEntity1.  ISO2002 ID# _kLz1YEX7Eeegp_DADCe7HQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity in charge of the settlement reporting service.
/// </summary>
public partial record SettlementReportingEntity1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of settlement reporting entity
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    /// <summary>
    /// Identification of the settlement reporting entity.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    
    #nullable disable
}
