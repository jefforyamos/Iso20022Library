﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeemedRateType1Code.  ISO2002 ID# _moeRYJSlEeeh5JjedkaA_g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a deemed rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_moeRYJSlEeeh5JjedkaA_g")]
[Description(@"Specifies the type of a deemed rate.")]
[DerivedFrom(typeof(DeemedRateTypeCode))]
public enum DeemedRateType1Code
{
    /// <summary>
    /// Deemed rate of dividend proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as "DEDI".
    /// </summary>
    [EnumMember(Value = "DEDI")]
    [IsoId("_qLgTQZSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of dividend proceeds attributed to the security holder.")]
    DeemedDividendProceeds = DeemedRateTypeCode.DeemedDividendProceeds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deemed rate of fund proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as "DEFP".
    /// </summary>
    [EnumMember(Value = "DEFP")]
    [IsoId("_qaYcwZSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of fund proceeds attributed to the security holder.")]
    DeemedFundProceeds = DeemedRateTypeCode.DeemedFundProceeds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deemed rate of interest proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as "DEIT".
    /// </summary>
    [EnumMember(Value = "DEIT")]
    [IsoId("_qfvd4ZSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of interest proceeds attributed to the security holder.")]
    DeemedInterestProceeds = DeemedRateTypeCode.DeemedInterestProceeds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deemed rate of royalties proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as "DERY".
    /// </summary>
    [EnumMember(Value = "DERY")]
    [IsoId("_qm4AoZSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of royalties proceeds attributed to the security holder.")]
    DeemedRoyaltiesProceeds = DeemedRateTypeCode.DeemedRoyaltiesProceeds, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeemedRateType1CodeMetadataExtensions
{
    private static readonly DeemedRateType1CodeDropdownSource _dropdownSource = new DeemedRateType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeemedRateType1CodeDropdownRow GetMetadata(this DeemedRateType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


