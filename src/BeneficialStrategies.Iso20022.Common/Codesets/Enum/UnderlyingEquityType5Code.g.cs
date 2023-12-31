﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingEquityType5Code.  ISO2002 ID# __Zu0kIHBEeaalK9UbuVGFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type for a contract for equity derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__Zu0kIHBEeaalK9UbuVGFw")]
[Description(@"Specifies the type for a contract for equity derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV3Code))]
public enum UnderlyingEquityType5Code
{
    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Q7CIIYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is of other type.")]
    Other,
    
    /// <summary>
    /// Underlying is an exchange traded fund.
    /// Encoded/decoded by serializers as "ExchangeTradedFund".
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_RTu8AYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is an exchange traded fund.")]
    ExchangeTradedFund,
    
    /// <summary>
    /// Underlying is a share.
    /// Encoded/decoded by serializers as "Share".
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_SPsN8YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a share.")]
    Share,
    
    /// <summary>
    /// Underlying is a stock dividend.
    /// Encoded/decoded by serializers as "StockDividend".
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_Ta0kUYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a stock dividend.")]
    StockDividend,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnderlyingEquityType5CodeMetadataExtensions
{
    private static readonly UnderlyingEquityType5CodeDropdownSource _dropdownSource = new UnderlyingEquityType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnderlyingEquityType5CodeDropdownRow GetMetadata(this UnderlyingEquityType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


