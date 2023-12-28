﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassDetailedSubProductType5Code.  ISO2002 ID# _76AdsA2eEeW72qLtWESimw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Electricity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_76AdsA2eEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Electricity.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType5Code
{
    /// <summary>
    /// Commodity attribute of type base load.
    /// Encoded/decoded by serializers as "BaseLoad".
    /// </summary>
    [EnumMember(Value = "BSLD")]
    [IsoId("_q8_4EQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type base load.")]
    BaseLoad,
    
    /// <summary>
    /// Commodity attribute of type financial transmission rights.
    /// Encoded/decoded by serializers as "FinancialTransmissionRights".
    /// </summary>
    [EnumMember(Value = "FITR")]
    [IsoId("_sAsJsQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type financial transmission rights.")]
    FinancialTransmissionRights,
    
    /// <summary>
    /// Commodity attribute of type peak load.
    /// Encoded/decoded by serializers as "PeakLoad".
    /// </summary>
    [EnumMember(Value = "PKLD")]
    [IsoId("_ueY7MQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type peak load.")]
    PeakLoad,
    
    /// <summary>
    /// Commodity attribute of type off-peak.
    /// Encoded/decoded by serializers as "OffPeak".
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_Vb9FgWs3EeW9oI9ZdgWHPQ")]
    [Description(@"Commodity attribute of type off-peak.")]
    OffPeak,
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_WDhb0ms3EeW9oI9ZdgWHPQ")]
    [Description(@"Commodity attribute of other type.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassDetailedSubProductType5CodeMetadataExtensions
{
    private static readonly AssetClassDetailedSubProductType5CodeDropdownSource _dropdownSource = new AssetClassDetailedSubProductType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassDetailedSubProductType5CodeDropdownRow GetMetadata(this AssetClassDetailedSubProductType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


