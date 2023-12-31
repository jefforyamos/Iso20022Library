﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TotalDetailsCode.  ISO2002 ID# _uDmwIN6SEeiwsev40qZGEQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uDmwIN6SEeiwsev40qZGEQ")]
[Description(@"Indicates the hierarchical structure of the reconciliation result of the Sale to POI reconciliation.")]
[Derivations(typeof(TotalDetails1Code))]
// External derivations that should be provided by the proper interface are: 
public enum TotalDetailsCode
{
    /// <summary>
    /// Give the totals result per POI Identification value.
    /// Encoded/decoded by serializers as "PIID".
    /// </summary>
    [EnumMember(Value = "PIID")]
    [IsoId("_2UMGQN6SEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per POI Identification value.")]
    PerPOIIdentification,
    
    /// <summary>
    /// Give the totals result per Sale Identification value.
    /// Encoded/decoded by serializers as "SAID".
    /// </summary>
    [EnumMember(Value = "SAID")]
    [IsoId("_2Yc7MN6SEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Sale Identification value.")]
    PerSaleIdentification,
    
    /// <summary>
    /// Give the totals result per Operator Identification value.
    /// Encoded/decoded by serializers as "OPID".
    /// </summary>
    [EnumMember(Value = "OPID")]
    [IsoId("_2czPsN6SEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Operator Identification value.")]
    PerCashierIdentification,
    
    /// <summary>
    /// Give the totals result per Totals Group Identification value.
    /// Encoded/decoded by serializers as "TGID".
    /// </summary>
    [EnumMember(Value = "TGID")]
    [IsoId("_2mfXMN6SEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Totals Group Identification value.")]
    PerTotalsGroup,
    
    /// <summary>
    /// Give the totals result per Shift Number Identification value.
    /// Encoded/decoded by serializers as "SNID".
    /// </summary>
    [EnumMember(Value = "SNID")]
    [IsoId("_Af9WsN6TEeiwsev40qZGEQ")]
    [Description(@"Give the totals result per Shift Number Identification value.")]
    PerShiftNumber,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TotalDetailsCodeMetadataExtensions
{
    private static readonly TotalDetailsCodeDropdownSource _dropdownSource = new TotalDetailsCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITotalDetailsCodeDropdownRow GetMetadata(this TotalDetailsCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


