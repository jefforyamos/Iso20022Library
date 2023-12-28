﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceProtectionScope2Code.  ISO2002 ID# _aI1PMdp-Ed-ak6NoX_4Aeg_-86829705.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of price protection the customer requires on their order. Defines the scope of the "related to" price of the peg or the scope of "related to" price of the discretion (for example, local, global etc).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aI1PMdp-Ed-ak6NoX_4Aeg_-86829705")]
[Description(@"Defines the type of price protection the customer requires on their order. Defines the scope of the ""related to"" price of the peg or the scope of ""related to"" price of the discretion (for example, local, global etc).")]
[DerivedFrom(typeof(PriceProtectionScopeCode))]
public enum PriceProtectionScope2Code
{
    /// <summary>
    /// Price protection is local (for example, Exchange, ECN, ATS).
    /// Encoded/decoded by serializers as "Local".
    /// </summary>
    [EnumMember(Value = "LOCA")]
    [IsoId("_aI1PMtp-Ed-ak6NoX_4Aeg_-40654570")]
    [Description(@"Price protection is local (for example, Exchange, ECN, ATS).")]
    Local,
    
    /// <summary>
    /// Price protection is national (across all national markets).
    /// Encoded/decoded by serializers as "National".
    /// </summary>
    [EnumMember(Value = "NATI")]
    [IsoId("_aI1PM9p-Ed-ak6NoX_4Aeg_-40654240")]
    [Description(@"Price protection is national (across all national markets).")]
    National,
    
    /// <summary>
    /// Price protection is global (across all markets).
    /// Encoded/decoded by serializers as "Global".
    /// </summary>
    [EnumMember(Value = "GLOB")]
    [IsoId("_aI1PNNp-Ed-ak6NoX_4Aeg_-40654239")]
    [Description(@"Price protection is global (across all markets).")]
    Global,
    
    /// <summary>
    /// Price protection is national (across all national markets) excluding local price protection.
    /// Encoded/decoded by serializers as "NationalExcludingLocal".
    /// </summary>
    [EnumMember(Value = "NAEL")]
    [IsoId("_aI1PNdp-Ed-ak6NoX_4Aeg_-40654215")]
    [Description(@"Price protection is national (across all national markets) excluding local price protection.")]
    NationalExcludingLocal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceProtectionScope2CodeMetadataExtensions
{
    private static readonly PriceProtectionScope2CodeDropdownSource _dropdownSource = new PriceProtectionScope2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceProtectionScope2CodeDropdownRow GetMetadata(this PriceProtectionScope2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


