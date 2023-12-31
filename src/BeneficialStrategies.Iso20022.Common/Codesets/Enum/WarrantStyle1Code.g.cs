﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WarrantStyle1Code.  ISO2002 ID# _Yg0vlNp-Ed-ak6NoX_4Aeg_-1700057033.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how an option can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yg0vlNp-Ed-ak6NoX_4Aeg_-1700057033")]
[Description(@"Defines how an option can be exercised.")]
[DerivedFrom(typeof(WarrantStyleCode))]
public enum WarrantStyle1Code
{
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as "American".
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_Yg0vldp-Ed-ak6NoX_4Aeg_1980293018")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American,
    
    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as "European".
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_Yg0vltp-Ed-ak6NoX_4Aeg_-1236653940")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European,
    
    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as "Bermudan".
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("_Yg0vl9p-Ed-ak6NoX_4Aeg_230494823")]
    [Description(@"Option that can be exercised on multiple discrete dates prior to, or on expiry date.")]
    Bermudan,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WarrantStyle1CodeMetadataExtensions
{
    private static readonly WarrantStyle1CodeDropdownSource _dropdownSource = new WarrantStyle1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWarrantStyle1CodeDropdownRow GetMetadata(this WarrantStyle1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


