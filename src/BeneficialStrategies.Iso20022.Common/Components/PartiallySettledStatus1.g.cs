﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartiallySettledStatus1.  ISO2002 ID# _RLuxWdp-Ed-ak6NoX_4Aeg_736788368.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is partially settled.
/// </summary>
public partial record PartiallySettledStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the partially settled status.
    /// </summary>
    public required SettledStatusReason1Code Reason { get; init; } 
    /// <summary>
    /// Reason for the partially settled status.
    /// </summary>
    public required IsoExtended350Code ExtendedReason { get; init; } 
    /// <summary>
    /// Proprietary identification of the reason for the partially settled status in the report.
    /// </summary>
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    /// <summary>
    /// Additional information about the partially settled status reason.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
