﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashAsset1.  ISO2002 ID# _e2IPAEyHEeir2sRRVd9XhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a cash asset.
/// </summary>
public partial record CashAsset1
{
    #nullable enable
    
    /// <summary>
    /// Type of cash asset.
    /// </summary>
    public required ICashAssetType1Choice CashAssetType { get; init; } 
    /// <summary>
    /// Additional information about the cash asset.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    #nullable disable
}
