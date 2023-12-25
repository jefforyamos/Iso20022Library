﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ClosedStatusReasonCode.  ISO2002 ID# _tYawoE_vEeaB8-OWTiMVrQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the closed status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tYawoE_vEeaB8-OWTiMVrQ")]
[Description(@"Specifies the reason for the closed status.")]
public enum ClosedStatusReasonCode
{
    /// <summary>
    /// Account is closed, following an instruction from the client, or an authorised party, to close the account.
    /// </summary>
    [EnumMember(Value = "CLIN")]
    [IsoId("_zbGEwE_vEeaB8-OWTiMVrQ")]
    [Description(@"Account is closed, following an instruction from the client, or an authorised party, to close the account.")]
    CLIN,
    
    /// <summary>
    /// Account is closed, following an instruction from the account servicer to close the account.
    /// </summary>
    [EnumMember(Value = "ASIN")]
    [IsoId("_DB_hIE_wEeaB8-OWTiMVrQ")]
    [Description(@"Account is closed, following an instruction from the account servicer to close the account.")]
    ASIN,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ClosedStatusReasonCodeMetadataExtensions
{
    private static readonly ClosedStatusReasonCodeDropdownSource _dropdownSource = new ClosedStatusReasonCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IClosedStatusReasonCodeDropdownRow GetMetadata(this ClosedStatusReasonCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


