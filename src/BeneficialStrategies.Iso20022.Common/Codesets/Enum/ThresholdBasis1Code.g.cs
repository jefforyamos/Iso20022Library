﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ThresholdBasis1Code.  ISO2002 ID# _IRxt4BuOEeyhRdHRjakS2w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IRxt4BuOEeyhRdHRjakS2w")]
[Description(@"Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.")]
[DerivedFrom(typeof(ThresholdBasisCode))]
public enum ThresholdBasis1Code
{
    /// <summary>
    /// Basis is the total number of shares issued.
    /// Encoded/decoded by serializers as "AllIssuedShares".
    /// </summary>
    [EnumMember(Value = "ALSH")]
    [IsoId("_KOf5QRuOEeyhRdHRjakS2w")]
    [Description(@"Basis is the total number of shares issued.")]
    AllIssuedShares,
    
    /// <summary>
    /// Basis is the total number of shares represented at the meeting by attendees. 
    /// Encoded/decoded by serializers as "AllSharesRepresentedAtMeeting".
    /// </summary>
    [EnumMember(Value = "ALSM")]
    [IsoId("_KUwSQRuOEeyhRdHRjakS2w")]
    [Description(@"Basis is the total number of shares represented at the meeting by attendees. ")]
    AllSharesRepresentedAtMeeting,
    
    /// <summary>
    /// Basis is the total number of vote cast for a resolution.
    /// Encoded/decoded by serializers as "AllVoteCast".
    /// </summary>
    [EnumMember(Value = "ALVO")]
    [IsoId("_KbArQRuOEeyhRdHRjakS2w")]
    [Description(@"Basis is the total number of vote cast for a resolution.")]
    AllVoteCast,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ThresholdBasis1CodeMetadataExtensions
{
    private static readonly ThresholdBasis1CodeDropdownSource _dropdownSource = new ThresholdBasis1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IThresholdBasis1CodeDropdownRow GetMetadata(this ThresholdBasis1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


