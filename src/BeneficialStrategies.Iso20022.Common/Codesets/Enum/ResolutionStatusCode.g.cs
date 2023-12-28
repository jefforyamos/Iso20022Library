﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ResolutionStatusCode.  ISO2002 ID# _ZU0_aNp-Ed-ak6NoX_4Aeg_1388201869.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of a resolution in a meeting agenda.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZU0_aNp-Ed-ak6NoX_4Aeg_1388201869")]
[Description(@"Specifies the status of a resolution in a meeting agenda.")]
public enum ResolutionStatusCode
{
    /// <summary>
    /// Meeting resolution has to be voted for by the participants to a general meeting.
    /// Encoded/decoded by serializers as "ACTV".
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZU-JUNp-Ed-ak6NoX_4Aeg_1419601443")]
    [Description(@"Meeting resolution has to be voted for by the participants to a general meeting.")]
    Active,
    
    /// <summary>
    /// Meeting resolution has been withdrawn.
    /// Encoded/decoded by serializers as "WDRA".
    /// </summary>
    [EnumMember(Value = "WDRA")]
    [IsoId("_ZU-JUdp-Ed-ak6NoX_4Aeg_1710508898")]
    [Description(@"Meeting resolution has been withdrawn.")]
    Withdrawn,
    
    /// <summary>
    /// Meeting resolution has been rejected.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_XE0YYF63EeSjaerr_EM7AQ")]
    [Description(@"Meeting resolution has been rejected.")]
    Rejected,
    
    /// <summary>
    /// Meeting resolution has been accepted.
    /// Encoded/decoded by serializers as "ACPT".
    /// </summary>
    [EnumMember(Value = "ACPT")]
    [IsoId("_eBOw4F63EeSjaerr_EM7AQ")]
    [Description(@"Meeting resolution has been accepted.")]
    Accepted,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ResolutionStatusCodeMetadataExtensions
{
    private static readonly ResolutionStatusCodeDropdownSource _dropdownSource = new ResolutionStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IResolutionStatusCodeDropdownRow GetMetadata(this ResolutionStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


