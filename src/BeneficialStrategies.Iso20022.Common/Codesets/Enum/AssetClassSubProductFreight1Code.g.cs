﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassSubProductFreight1Code.  ISO2002 ID# _kHVf0NDvEeS8V88MH4oPOQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code list for freight related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kHVf0NDvEeS8V88MH4oPOQ")]
[Description(@"Code list for freight related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductFreight1Code
{
    /// <summary>
    /// Commodity of type dry freight.
    /// Encoded/decoded by serializers as "Dry".
    /// </summary>
    [EnumMember(Value = "DRYF")]
    [IsoId("_pxgg4UDbEeWOL-OsSq2h6w")]
    [Description(@"Commodity of type dry freight.")]
    Dry,
    
    /// <summary>
    /// Commodity of type wet freight.
    /// Encoded/decoded by serializers as "Wet".
    /// </summary>
    [EnumMember(Value = "WETF")]
    [IsoId("_q4LOAUDbEeWOL-OsSq2h6w")]
    [Description(@"Commodity of type wet freight.")]
    Wet,
    
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_mmQ5MafvEeW_OId9wS8dsQ")]
    [Description(@"Commodity of other type.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassSubProductFreight1CodeMetadataExtensions
{
    private static readonly AssetClassSubProductFreight1CodeDropdownSource _dropdownSource = new AssetClassSubProductFreight1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassSubProductFreight1CodeDropdownRow GetMetadata(this AssetClassSubProductFreight1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


