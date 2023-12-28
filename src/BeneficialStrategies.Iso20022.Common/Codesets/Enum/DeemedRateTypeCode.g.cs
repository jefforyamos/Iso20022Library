﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DeemedRateTypeCode.  ISO2002 ID# _wNAYIJSkEeeh5JjedkaA_g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of a deemed rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_wNAYIJSkEeeh5JjedkaA_g")]
[Description(@"Specifies the type of a deemed rate.")]
public enum DeemedRateTypeCode
{
    /// <summary>
    /// Deemed rate of interest proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as "DEIT".
    /// </summary>
    [EnumMember(Value = "DEIT")]
    [IsoId("_LmfRwJSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of interest proceeds attributed to the security holder.")]
    DeemedInterestProceeds,
    
    /// <summary>
    /// Deemed rate of dividend proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as "DEDI".
    /// </summary>
    [EnumMember(Value = "DEDI")]
    [IsoId("_Qgj_EJSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of dividend proceeds attributed to the security holder.")]
    DeemedDividendProceeds,
    
    /// <summary>
    /// Deemed rate of fund proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as "DEFP".
    /// </summary>
    [EnumMember(Value = "DEFP")]
    [IsoId("_U-XAEJSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of fund proceeds attributed to the security holder.")]
    DeemedFundProceeds,
    
    /// <summary>
    /// Deemed rate of royalties proceeds attributed to the security holder.
    /// Encoded/decoded by serializers as "DERY".
    /// </summary>
    [EnumMember(Value = "DERY")]
    [IsoId("_cXd7oJSlEeeh5JjedkaA_g")]
    [Description(@"Deemed rate of royalties proceeds attributed to the security holder.")]
    DeemedRoyaltiesProceeds,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DeemedRateTypeCodeMetadataExtensions
{
    private static readonly DeemedRateTypeCodeDropdownSource _dropdownSource = new DeemedRateTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDeemedRateTypeCodeDropdownRow GetMetadata(this DeemedRateTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


