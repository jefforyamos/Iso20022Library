﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RepoCallRequestStatus1Code.  ISO2002 ID# _ZS5Ftdp-Ed-ak6NoX_4Aeg_-1000214572.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies additional information about the status of the repurchase agreement call processed instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZS5Ftdp-Ed-ak6NoX_4Aeg_-1000214572")]
[Description(@"Specifies additional information about the status of the repurchase agreement call processed instruction.")]
[DerivedFrom(typeof(RepoCallRequestStatusCode))]
public enum RepoCallRequestStatus1Code
{
    /// <summary>
    /// Repurchase agreement call request is acknowledged/accepted.
    /// Encoded/decoded by serializers as "CACK".
    /// </summary>
    [EnumMember(Value = "CACK")]
    [IsoId("_ZS5Fttp-Ed-ak6NoX_4Aeg_-1000214541")]
    [Description(@"Repurchase agreement call request is acknowledged/accepted.")]
    AcknowledgedAccepted = RepoCallRequestStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Repuchase agreement call request is denied.
    /// Encoded/decoded by serializers as "DEND".
    /// </summary>
    [EnumMember(Value = "DEND")]
    [IsoId("_ZS5Ft9p-Ed-ak6NoX_4Aeg_-1000214284")]
    [Description(@"Repuchase agreement call request is denied.")]
    Denied = RepoCallRequestStatusCode.Denied, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RepoCallRequestStatus1CodeMetadataExtensions
{
    private static readonly RepoCallRequestStatus1CodeDropdownSource _dropdownSource = new RepoCallRequestStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRepoCallRequestStatus1CodeDropdownRow GetMetadata(this RepoCallRequestStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


