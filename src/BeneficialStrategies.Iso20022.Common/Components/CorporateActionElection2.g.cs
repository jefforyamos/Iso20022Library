﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionElection2.  ISO2002 ID# _UJ39ctp-Ed-ak6NoX_4Aeg_-1290336513.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about a corporate action election amendment request.
/// </summary>
public partial record CorporateActionElection2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required ICorporateActionOption1FormatChoice OptionType { get; init; } 
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required IsoExact3NumericText OptionNumber { get; init; } 
    /// <summary>
    /// New instructed securities quantity after the amendment.
    /// </summary>
    public required IUnitOrFaceAmount1Choice NewInstructedQuantity { get; init; } 
    /// <summary>
    /// The reason for the amendment request.
    /// </summary>
    public IsoMax350Text? Reason { get; init; } 
    
    #nullable disable
}
