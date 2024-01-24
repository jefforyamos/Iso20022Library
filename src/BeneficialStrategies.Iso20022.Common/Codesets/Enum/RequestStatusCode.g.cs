﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RequestStatusCode.  ISO2002 ID# _ZUFYg9p-Ed-ak6NoX_4Aeg_1488265087.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the coded status of invoice financing request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZUFYg9p-Ed-ak6NoX_4Aeg_1488265087")]
[Description(@"Specifies the coded status of invoice financing request.")]
[Derivations(typeof(RequestStatus1Code))]
public enum RequestStatusCode
{
    /// <summary>
    /// Single Invoice/Instalment financing request has been financed.
    /// Encoded/decoded by serializers as "FNCD".
    /// </summary>
    [EnumMember(Value = "FNCD")]
    [IsoId("_ZUFYhNp-Ed-ak6NoX_4Aeg_1919546667")]
    [Description(@"Single Invoice/Instalment financing request has been financed.")]
    Financed,
    
    /// <summary>
    /// Single Invoice/Instalment financing request is in a pending status and more checks are ongoing.
    /// Encoded/decoded by serializers as "PDNG".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ZUFYhdp-Ed-ak6NoX_4Aeg_-809624912")]
    [Description(@"Single Invoice/Instalment financing request is in a pending status and more checks are ongoing.")]
    Pending,
    
    /// <summary>
    /// Single Invoice/Instalment financing request has not been financed.
    /// Encoded/decoded by serializers as "NTFD".
    /// </summary>
    [EnumMember(Value = "NTFD")]
    [IsoId("_ZUFYhtp-Ed-ak6NoX_4Aeg_-1950599515")]
    [Description(@"Single Invoice/Instalment financing request has not been financed.")]
    NotFinanced,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RequestStatusCodeMetadataExtensions
{
    private static readonly RequestStatusCodeDropdownSource _dropdownSource = new RequestStatusCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRequestStatusCodeDropdownRow GetMetadata(this RequestStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


