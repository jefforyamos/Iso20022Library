﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SideIndicatorCode.  ISO2002 ID# _uQQC4y5SEeK7-OZOLIksSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// To indicate either the reference for the Central Counterparty (CCP) leg or the reference for the client leg of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uQQC4y5SEeK7-OZOLIksSw")]
[Description(@"To indicate either the reference for the Central Counterparty (CCP) leg or the reference for the client leg of the transaction.")]
public enum SideIndicatorCode
{
    /// <summary>
    /// Clearing broker identification is for the client leg.
    /// Encoded/decoded by serializers as "CLNT".
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("_7nCd0C5SEeK7-OZOLIksSw")]
    [Description(@"Clearing broker identification is for the client leg.")]
    ClientLeg,
    
    /// <summary>
    /// Clearing broker identification is for the Central Counterparty (CCP) leg.
    /// Encoded/decoded by serializers as "CCPL".
    /// </summary>
    [EnumMember(Value = "CCPL")]
    [IsoId("_DcQGkC5TEeK7-OZOLIksSw")]
    [Description(@"Clearing broker identification is for the Central Counterparty (CCP) leg.")]
    CCPLeg,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SideIndicatorCodeMetadataExtensions
{
    private static readonly SideIndicatorCodeDropdownSource _dropdownSource = new SideIndicatorCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISideIndicatorCodeDropdownRow GetMetadata(this SideIndicatorCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


