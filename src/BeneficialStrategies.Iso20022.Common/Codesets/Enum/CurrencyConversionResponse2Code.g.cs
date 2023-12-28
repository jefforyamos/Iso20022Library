﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CurrencyConversionResponse2Code.  ISO2002 ID# _QOgoAa4ZEeW_TaP-ygI0SQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Result of a requested currency conversion.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QOgoAa4ZEeW_TaP-ygI0SQ")]
[Description(@"Result of a requested currency conversion.")]
[DerivedFrom(typeof(CurrencyConversionResponseCode))]
public enum CurrencyConversionResponse2Code
{
    /// <summary>
    /// Dynamic currency conversion may be offered to the cardholder.
    /// Encoded/decoded by serializers as "Allowed".
    /// </summary>
    [EnumMember(Value = "ODCC")]
    [IsoId("_QZPRUa4ZEeW_TaP-ygI0SQ")]
    [Description(@"Dynamic currency conversion may be offered to the cardholder.")]
    Allowed,
    
    /// <summary>
    /// The card is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as "InvalidCard".
    /// </summary>
    [EnumMember(Value = "ICRD")]
    [IsoId("_QZPRVa4ZEeW_TaP-ygI0SQ")]
    [Description(@"The card is not valid for dynamic currency conversion.")]
    InvalidCard,
    
    /// <summary>
    /// Dynamic currency conversion service cannot be offered for this card product.
    /// Encoded/decoded by serializers as "InvalidProduct".
    /// </summary>
    [EnumMember(Value = "IPRD")]
    [IsoId("_QZPRWa4ZEeW_TaP-ygI0SQ")]
    [Description(@"Dynamic currency conversion service cannot be offered for this card product.")]
    InvalidProduct,
    
    /// <summary>
    /// Exchange rates are not available.
    /// Encoded/decoded by serializers as "NoRate".
    /// </summary>
    [EnumMember(Value = "IRAT")]
    [IsoId("_QZPRW64ZEeW_TaP-ygI0SQ")]
    [Description(@"Exchange rates are not available.")]
    NoRate,
    
    /// <summary>
    /// Dynamic currency conversion is not available for other reason.
    /// Encoded/decoded by serializers as "NotAvailable".
    /// </summary>
    [EnumMember(Value = "NDCC")]
    [IsoId("_QZPRXa4ZEeW_TaP-ygI0SQ")]
    [Description(@"Dynamic currency conversion is not available for other reason.")]
    NotAvailable,
    
    /// <summary>
    /// The ATM manager is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as "InvalidATMManager".
    /// </summary>
    [EnumMember(Value = "IAMG")]
    [IsoId("_Ulf2Ya4ZEeW_TaP-ygI0SQ")]
    [Description(@"The ATM manager is not valid for dynamic currency conversion.")]
    InvalidATMManager,
    
    /// <summary>
    /// The ATM is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as "InvalidATM".
    /// </summary>
    [EnumMember(Value = "IATM")]
    [IsoId("_UsWsUa4ZEeW_TaP-ygI0SQ")]
    [Description(@"The ATM is not valid for dynamic currency conversion.")]
    InvalidATM,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CurrencyConversionResponse2CodeMetadataExtensions
{
    private static readonly CurrencyConversionResponse2CodeDropdownSource _dropdownSource = new CurrencyConversionResponse2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICurrencyConversionResponse2CodeDropdownRow GetMetadata(this CurrencyConversionResponse2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


