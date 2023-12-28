﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QuoteRequestType1Code.  ISO2002 ID# _ZX9L4dp-Ed-ak6NoX_4Aeg_244698019.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the type of quote request (e.g. manual vs. automatic) being generated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZX9L4dp-Ed-ak6NoX_4Aeg_244698019")]
[Description(@"Indicates the type of quote request (e.g. manual vs. automatic) being generated.")]
[DerivedFrom(typeof(QuoteRequestTypeCode))]
public enum QuoteRequestType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Manual".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZX9L4tp-Ed-ak6NoX_4Aeg_582708572")]
    [Description(@"??")]
    Manual,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Automatic".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZX9L49p-Ed-ak6NoX_4Aeg_582708614")]
    [Description(@"??")]
    Automatic,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QuoteRequestType1CodeMetadataExtensions
{
    private static readonly QuoteRequestType1CodeDropdownSource _dropdownSource = new QuoteRequestType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQuoteRequestType1CodeDropdownRow GetMetadata(this QuoteRequestType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

