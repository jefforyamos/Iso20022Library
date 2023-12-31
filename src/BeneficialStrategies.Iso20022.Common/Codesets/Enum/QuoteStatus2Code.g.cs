﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QuoteStatus2Code.  ISO2002 ID# _ZYZ32dp-Ed-ak6NoX_4Aeg_-1173342394.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the status of a quote acknowledgement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZYZ32dp-Ed-ak6NoX_4Aeg_-1173342394")]
[Description(@"Identifies the status of a quote acknowledgement.")]
[DerivedFrom(typeof(QuoteStatusCode))]
public enum QuoteStatus2Code
{
    /// <summary>
    /// Indicates that all quotes are cancelled for a financial instrument's symbol.
    /// Encoded/decoded by serializers as "CancelSymbol".
    /// </summary>
    [EnumMember(Value = "SYMB")]
    [IsoId("_ZYjBwNp-Ed-ak6NoX_4Aeg_-1041278909")]
    [Description(@"Indicates that all quotes are cancelled for a financial instrument's symbol.")]
    CancelSymbol,
    
    /// <summary>
    /// Indicates that all quotes are cancelled for a specific security.
    /// Encoded/decoded by serializers as "CancelSecurity".
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_ZYjBwdp-Ed-ak6NoX_4Aeg_-1041278866")]
    [Description(@"Indicates that all quotes are cancelled for a specific security.")]
    CancelSecurity,
    
    /// <summary>
    /// Indicates that all quotes are cancelled for an underlying financial instrument.
    /// Encoded/decoded by serializers as "CancelUnderlying".
    /// </summary>
    [EnumMember(Value = "UNSY")]
    [IsoId("_ZYjBwtp-Ed-ak6NoX_4Aeg_-1041278806")]
    [Description(@"Indicates that all quotes are cancelled for an underlying financial instrument.")]
    CancelUnderlying,
    
    /// <summary>
    /// Indicates that all quotes are cancelled.
    /// Encoded/decoded by serializers as "CancelAll".
    /// </summary>
    [EnumMember(Value = "ALLE")]
    [IsoId("_ZYjBw9p-Ed-ak6NoX_4Aeg_-1041278771")]
    [Description(@"Indicates that all quotes are cancelled.")]
    CancelAll,
    
    /// <summary>
    /// Indicates that no quote can be computed or communicated.
    /// Encoded/decoded by serializers as "QuoteNotFound".
    /// </summary>
    [EnumMember(Value = "NQUO")]
    [IsoId("_ZYjBxNp-Ed-ak6NoX_4Aeg_-799316486")]
    [Description(@"Indicates that no quote can be computed or communicated.")]
    QuoteNotFound,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QuoteStatus2CodeMetadataExtensions
{
    private static readonly QuoteStatus2CodeDropdownSource _dropdownSource = new QuoteStatus2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQuoteStatus2CodeDropdownRow GetMetadata(this QuoteStatus2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


