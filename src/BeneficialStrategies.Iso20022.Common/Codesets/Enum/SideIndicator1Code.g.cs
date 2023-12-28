﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SideIndicator1Code.  ISO2002 ID# _R6yMsC5TEeK7-OZOLIksSw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// To indicate either the reference for the Central Counterparty (CCP) leg or the reference for the client leg of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_R6yMsC5TEeK7-OZOLIksSw")]
[Description(@"To indicate either the reference for the Central Counterparty (CCP) leg or the reference for the client leg of the transaction.")]
[DerivedFrom(typeof(SideIndicatorCode))]
public enum SideIndicator1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CCPLeg".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__vvtsS5UEeKwTrPDLMbLxA")]
    [Description(@"??")]
    CCPLeg,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ClientLeg".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("__z2xoS5UEeKwTrPDLMbLxA")]
    [Description(@"??")]
    ClientLeg,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SideIndicator1CodeMetadataExtensions
{
    private static readonly SideIndicator1CodeDropdownSource _dropdownSource = new SideIndicator1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISideIndicator1CodeDropdownRow GetMetadata(this SideIndicator1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


