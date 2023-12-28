﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceMethod1Code.  ISO2002 ID# _aIreMNp-Ed-ak6NoX_4Aeg_-1724055266.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of pricing calculation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIreMNp-Ed-ak6NoX_4Aeg_-1724055266")]
[Description(@"Specifies the type of pricing calculation method.")]
[DerivedFrom(typeof(PriceMethodCode))]
public enum PriceMethod1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ForwardPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aIreMdp-Ed-ak6NoX_4Aeg_-1724055265")]
    [Description(@"??")]
    ForwardPrice,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HistoricalPrice".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aIreMtp-Ed-ak6NoX_4Aeg_-1724055264")]
    [Description(@"??")]
    HistoricalPrice,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PriceMethod1CodeMetadataExtensions
{
    private static readonly PriceMethod1CodeDropdownSource _dropdownSource = new PriceMethod1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPriceMethod1CodeDropdownRow GetMetadata(this PriceMethod1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

