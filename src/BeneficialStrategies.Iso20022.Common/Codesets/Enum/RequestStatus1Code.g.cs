﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RequestStatus1Code.  ISO2002 ID# _ZT7nidp-Ed-ak6NoX_4Aeg_783372839.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the coded status of invoice financing request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZT7nidp-Ed-ak6NoX_4Aeg_783372839")]
[Description(@"Specifies the coded status of invoice financing request.")]
[DerivedFrom(typeof(RequestStatusCode))]
public enum RequestStatus1Code
{
    /// <summary>
    /// Single Invoice/Instalment financing request has been financed.
    /// Encoded/decoded by serializers as "Financed".
    /// </summary>
    [EnumMember(Value = "FNCD")]
    [IsoId("_ZUFYgNp-Ed-ak6NoX_4Aeg_783372870")]
    [Description(@"Single Invoice/Instalment financing request has been financed.")]
    Financed,
    
    /// <summary>
    /// Single Invoice/Instalment financing request is in a pending status and more checks are ongoing.
    /// Encoded/decoded by serializers as "Pending".
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_ZUFYgdp-Ed-ak6NoX_4Aeg_783372871")]
    [Description(@"Single Invoice/Instalment financing request is in a pending status and more checks are ongoing.")]
    Pending,
    
    /// <summary>
    /// Single Invoice/Instalment financing request has not been financed.
    /// Encoded/decoded by serializers as "NotFinanced".
    /// </summary>
    [EnumMember(Value = "NTFD")]
    [IsoId("_ZUFYgtp-Ed-ak6NoX_4Aeg_783372900")]
    [Description(@"Single Invoice/Instalment financing request has not been financed.")]
    NotFinanced,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RequestStatus1CodeMetadataExtensions
{
    private static readonly RequestStatus1CodeDropdownSource _dropdownSource = new RequestStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRequestStatus1CodeDropdownRow GetMetadata(this RequestStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


