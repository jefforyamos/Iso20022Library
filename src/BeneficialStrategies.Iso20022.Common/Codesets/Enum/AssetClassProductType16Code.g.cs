﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AssetClassProductType16Code.  ISO2002 ID# _ON6osU7KEe2PGo0mhYCh1g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Commodity derivative base product code list for Index.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ON6osU7KEe2PGo0mhYCh1g")]
[Description(@"Commodity derivative base product code list for Index.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
public enum AssetClassProductType16Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Index".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aDo5gU7KEe2PGo0mhYCh1g")]
    [Description(@"??")]
    Index,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AssetClassProductType16CodeMetadataExtensions
{
    private static readonly AssetClassProductType16CodeDropdownSource _dropdownSource = new AssetClassProductType16CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAssetClassProductType16CodeDropdownRow GetMetadata(this AssetClassProductType16Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


