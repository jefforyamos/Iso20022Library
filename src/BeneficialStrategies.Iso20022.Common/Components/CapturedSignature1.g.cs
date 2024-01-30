﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CapturedSignature1.  ISO2002 ID# _dY9X8NxGEeioifFt1dhnJA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides all information related to a handwritten signature capture.
/// </summary>
public partial record CapturedSignature1
{
    #nullable enable
    
    /// <summary>
    /// Format of the image.
    /// </summary>
    public required IsoMax35Text ImageFormat { get; init; } 
    /// <summary>
    /// Data of the image.
    /// </summary>
    public IsoMax2MBBinary? ImageData { get; init; } 
    /// <summary>
    /// URL or name of the image.
    /// </summary>
    public IsoMax500Text? ImageReference { get; init; } 
    /// <summary>
    /// Additional information for the image.
    /// </summary>
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
