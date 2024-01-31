﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType11Code.  ISO2002 ID# _Wl9_0A3oEeWc7_0KPiuk6w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Other C10.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wl9_0A3oEeWc7_0KPiuk6w")]
[Description(@"Commodity derivative base product code list for Other C10.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType11Code
{
    /// <summary>
    /// Commodity of other type C10.
    /// Encoded/decoded by serializers as "OTHC".
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_Xwy0MQ3oEeWc7_0KPiuk6w")]
    [Description(@"Commodity of other type C10.")]
    OtherC10 = AssetClassProductTypeCode.OtherC10, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductType11CodeMetadataExtensions
{
    private static readonly AssetClassProductType11CodeDropdownSource _dropdownSource = new AssetClassProductType11CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductType11CodeDropdownRow GetMetadata(this AssetClassProductType11Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


