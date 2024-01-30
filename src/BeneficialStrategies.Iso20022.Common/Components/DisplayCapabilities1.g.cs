﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DisplayCapabilities1.  ISO2002 ID# _TGJWZgEcEeCQm6a_G2yO_w_-976075927.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The capabilities of the display components performing the transaction.
/// </summary>
public partial record DisplayCapabilities1
{
    #nullable enable
    
    /// <summary>
    /// Type of display (for example merchant or cardholder).
    /// </summary>
    public required UserInterface2Code DisplayType { get; init; } 
    /// <summary>
    /// Number of lines of the display component.
    /// </summary>
    public required IsoMax3NumericText NumberOfLines { get; init; } 
    /// <summary>
    /// Number of columns of the display component.
    /// </summary>
    public required IsoMax3NumericText LineWidth { get; init; } 
    
    #nullable disable
}
