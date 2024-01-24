﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RequestType1Code.  ISO2002 ID# _ZUOicNp-Ed-ak6NoX_4Aeg_979401735.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the request used to further detail the type of information that will be queried.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUOicNp-Ed-ak6NoX_4Aeg_979401735")]
[Description(@"Specifies the request used to further detail the type of information that will be queried.")]
[DerivedFrom(typeof(RequestTypeCode))]
public enum RequestType1Code
{
    /// <summary>
    /// Type is a request to release the pending transactions.
    /// Encoded/decoded by serializers as "RT01".
    /// </summary>
    [EnumMember(Value = "RT01")]
    [IsoId("_ZUOicdp-Ed-ak6NoX_4Aeg_979401766")]
    [Description(@"Type is a request to release the pending transactions.")]
    ReleasePending = RequestTypeCode.ReleasePending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type is a request to hold normal transactions.
    /// Encoded/decoded by serializers as "RT02".
    /// </summary>
    [EnumMember(Value = "RT02")]
    [IsoId("_ZUOictp-Ed-ak6NoX_4Aeg_979401797")]
    [Description(@"Type is a request to hold normal transactions.")]
    HoldNormal = RequestTypeCode.HoldNormal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type is a request to cancellation a transaction.
    /// Encoded/decoded by serializers as "RT03".
    /// </summary>
    [EnumMember(Value = "RT03")]
    [IsoId("_ZUOic9p-Ed-ak6NoX_4Aeg_979401827")]
    [Description(@"Type is a request to cancellation a transaction.")]
    Cancellation = RequestTypeCode.Cancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type is a request to change the sequence of the transactions.
    /// Encoded/decoded by serializers as "RT04".
    /// </summary>
    [EnumMember(Value = "RT04")]
    [IsoId("_ZUOidNp-Ed-ak6NoX_4Aeg_979401828")]
    [Description(@"Type is a request to change the sequence of the transactions.")]
    ReSequence = RequestTypeCode.ReSequence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type is a request to release the suspicious transactions.
    /// Encoded/decoded by serializers as "RT05".
    /// </summary>
    [EnumMember(Value = "RT05")]
    [IsoId("_ZUOiddp-Ed-ak6NoX_4Aeg_979401858")]
    [Description(@"Type is a request to release the suspicious transactions.")]
    ReleaseSuspicious = RequestTypeCode.ReleaseSuspicious, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RequestType1CodeMetadataExtensions
{
    private static readonly RequestType1CodeDropdownSource _dropdownSource = new RequestType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRequestType1CodeDropdownRow GetMetadata(this RequestType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


