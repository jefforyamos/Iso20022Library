﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for QuoteRequestTypeCode.  ISO2002 ID# _ZX9L5Np-Ed-ak6NoX_4Aeg_336258243.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of quote request (e.g. manual vs. automatic) being generated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZX9L5Np-Ed-ak6NoX_4Aeg_336258243")]
[Description(@"Indicates the type of quote request (e.g. manual vs. automatic) being generated.")]
[Derivations(typeof(QuoteRequestType1Code))]
public enum QuoteRequestTypeCode
{
    /// <summary>
    /// Indicates the quote request has been generated by manual intervention.
    /// Encoded/decoded by serializers as "MANU".
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_ZX9L5dp-Ed-ak6NoX_4Aeg_336258244")]
    [Description(@"Indicates the quote request has been generated by manual intervention.")]
    Manual,
    
    /// <summary>
    /// Indicates the quote request has been generated automatically, by market activity or securities achieving a treshold.
    /// Encoded/decoded by serializers as "AUTO".
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_ZX9L5tp-Ed-ak6NoX_4Aeg_336258245")]
    [Description(@"Indicates the quote request has been generated automatically, by market activity or securities achieving a treshold.")]
    Automatic,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class QuoteRequestTypeCodeMetadataExtensions
{
    private static readonly QuoteRequestTypeCodeDropdownSource _dropdownSource = new QuoteRequestTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IQuoteRequestTypeCodeDropdownRow GetMetadata(this QuoteRequestTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


