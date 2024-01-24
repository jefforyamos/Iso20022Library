﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalTypeCode.  ISO2002 ID# _71JA8ECGEeeXpbqDpLawug.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of terminal under the control of the card acceptor used for the card transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_71JA8ECGEeeXpbqDpLawug")]
[Description(@"Type of terminal under the control of the card acceptor used for the card transaction.")]
[Derivations(typeof(TerminalType1Code))]
public enum TerminalTypeCode
{
    /// <summary>
    /// Automated Teller Machine
    /// Encoded/decoded by serializers as "ATMT".
    /// </summary>
    [EnumMember(Value = "ATMT")]
    [IsoId("_CyLEgECHEeeXpbqDpLawug")]
    [Description(@"Automated Teller Machine")]
    ATM,
    
    /// <summary>
    /// Point of Sale terminal.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_GY-zIECHEeeXpbqDpLawug")]
    [Description(@"Point of Sale terminal.")]
    POS,
    
    /// <summary>
    /// Mobile or tablet used as a Point of Sale terminal
    /// Encoded/decoded by serializers as "MPOS".
    /// </summary>
    [EnumMember(Value = "MPOS")]
    [IsoId("_K_CYQECHEeeXpbqDpLawug")]
    [Description(@"Mobile or tablet used as a Point of Sale terminal")]
    mPOS,
    
    /// <summary>
    /// Other type defined at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_QkQ7YECHEeeXpbqDpLawug")]
    [Description(@"Other type defined at national level")]
    OtherNational,
    
    /// <summary>
    /// Other private type of terminal.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_VOi5MECHEeeXpbqDpLawug")]
    [Description(@"Other private type of terminal.")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalTypeCodeMetadataExtensions
{
    private static readonly TerminalTypeCodeDropdownSource _dropdownSource = new TerminalTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalTypeCodeDropdownRow GetMetadata(this TerminalTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


