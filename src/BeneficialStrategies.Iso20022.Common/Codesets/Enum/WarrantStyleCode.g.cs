﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for WarrantStyleCode.  ISO2002 ID# _Yg0vmNp-Ed-ak6NoX_4Aeg_2120180285.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how a warrant can be exercised.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yg0vmNp-Ed-ak6NoX_4Aeg_2120180285")]
[Description(@"Defines how a warrant can be exercised.")]
[Derivations(typeof(WarrantStyle1Code))]
// External derivations that should be provided by the proper interface are: 
public enum WarrantStyleCode
{
    /// <summary>
    /// Option that can be exercised on expiry date only.
    /// Encoded/decoded by serializers as "EURO".
    /// </summary>
    [EnumMember(Value = "EURO")]
    [IsoId("_Yg95gNp-Ed-ak6NoX_4Aeg_545175896")]
    [Description(@"Option that can be exercised on expiry date only.")]
    European,
    
    /// <summary>
    /// Option can be exercised before or on expiry date.
    /// Encoded/decoded by serializers as "AMER".
    /// </summary>
    [EnumMember(Value = "AMER")]
    [IsoId("_Yg95gdp-Ed-ak6NoX_4Aeg_609455502")]
    [Description(@"Option can be exercised before or on expiry date.")]
    American,
    
    /// <summary>
    /// Option that can be exercised on multiple discrete dates prior to, or on expiry date.
    /// Encoded/decoded by serializers as "BERM".
    /// </summary>
    [EnumMember(Value = "BERM")]
    [IsoId("_Yg95gtp-Ed-ak6NoX_4Aeg_-565735523")]
    [Description(@"Option that can be exercised on multiple discrete dates prior to, or on expiry date.")]
    Bermudan,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class WarrantStyleCodeMetadataExtensions
{
    private static readonly WarrantStyleCodeDropdownSource _dropdownSource = new WarrantStyleCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IWarrantStyleCodeDropdownRow GetMetadata(this WarrantStyleCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


