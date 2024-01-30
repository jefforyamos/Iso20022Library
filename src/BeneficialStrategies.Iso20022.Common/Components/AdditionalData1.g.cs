﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalData1.  ISO2002 ID# _3GIqg-kFEemeDPHh-U9b6w.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional data.
/// </summary>
public partial record AdditionalData1
{
    #nullable enable
    
    /// <summary>
    /// Type of information.
    /// </summary>
    public IsoMax35Text? Type { get; init; } 
    /// <summary>
    /// Value of a specific type of data.
    /// </summary>
    public IsoMax2048Text? Value { get; init; } 
    
    #nullable disable
}
