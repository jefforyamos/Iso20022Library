﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PriceMethod1Code.  ISO2002 ID# _aIreMNp-Ed-ak6NoX_4Aeg_-1724055266.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Price will be calculated after the close of the dealing period. An investor, therefore, does not know the exact buy or sell price.
    /// Encoded/decoded by serializers as "FORW".
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_aIreMdp-Ed-ak6NoX_4Aeg_-1724055265")]
    [Description(@"Price will be calculated after the close of the dealing period. An investor, therefore, does not know the exact buy or sell price.")]
    ForwardPrice = PriceMethodCode.ForwardPrice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is calculated at an earlier valuation point preceding the dealing period. An investor, therefore, knows the exact buy or sell price.
    /// Encoded/decoded by serializers as "HIST".
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_aIreMtp-Ed-ak6NoX_4Aeg_-1724055264")]
    [Description(@"Price is calculated at an earlier valuation point preceding the dealing period. An investor, therefore, knows the exact buy or sell price.")]
    HistoricalPrice = PriceMethodCode.HistoricalPrice, // same ordinal as derivation source for type conversions
    
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


