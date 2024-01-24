﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceProtectionScope1Code.  ISO2002 ID# _aIreNtp-Ed-ak6NoX_4Aeg_-529859319.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of price protection the customer requires on their order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIreNtp-Ed-ak6NoX_4Aeg_-529859319")]
[Description(@"Defines the type of price protection the customer requires on their order.")]
[DerivedFrom(typeof(PriceProtectionScopeCode))]
public enum PriceProtectionScope1Code
{
    /// <summary>
    /// Price protection is local (for example, Exchange, ECN, ATS).
    /// Encoded/decoded by serializers as "LOCA".
    /// </summary>
    [EnumMember(Value = "LOCA")]
    [IsoId("_aIreN9p-Ed-ak6NoX_4Aeg_-469828845")]
    [Description(@"Price protection is local (for example, Exchange, ECN, ATS).")]
    Local = PriceProtectionScopeCode.Local, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price protection is national (across all national markets).
    /// Encoded/decoded by serializers as "NATI".
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_aIreONp-Ed-ak6NoX_4Aeg_-469828551")]
    [Description(@"Price protection is national (across all national markets).")]
    National = PriceProtectionScopeCode.National, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price protection is global (across all markets).
    /// Encoded/decoded by serializers as "GLOB".
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_aI1PMNp-Ed-ak6NoX_4Aeg_-469828498")]
    [Description(@"Price protection is global (across all markets).")]
    Global = PriceProtectionScopeCode.Global, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceProtectionScope1CodeMetadataExtensions
{
    private static readonly PriceProtectionScope1CodeDropdownSource _dropdownSource = new PriceProtectionScope1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceProtectionScope1CodeDropdownRow GetMetadata(this PriceProtectionScope1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


