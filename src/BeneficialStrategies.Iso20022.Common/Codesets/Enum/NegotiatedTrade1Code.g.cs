﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NegotiatedTrade1Code.  ISO2002 ID# _aNJuhNp-Ed-ak6NoX_4Aeg_1326174786.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the trade is negotiated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNJuhNp-Ed-ak6NoX_4Aeg_1326174786")]
[Description(@"Specifies whether the trade is negotiated.")]
[DerivedFrom(typeof(NegotiatedTradeCode))]
public enum NegotiatedTrade1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Negotiated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aNJuhdp-Ed-ak6NoX_4Aeg_1840573471")]
    [Description(@"??")]
    Negotiated,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "NotNegotiated".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aNJuhtp-Ed-ak6NoX_4Aeg_1840573506")]
    [Description(@"??")]
    NotNegotiated,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Unknown".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aNJuh9p-Ed-ak6NoX_4Aeg_1840573524")]
    [Description(@"??")]
    Unknown,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NegotiatedTrade1CodeMetadataExtensions
{
    private static readonly NegotiatedTrade1CodeDropdownSource _dropdownSource = new NegotiatedTrade1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INegotiatedTrade1CodeDropdownRow GetMetadata(this NegotiatedTrade1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


