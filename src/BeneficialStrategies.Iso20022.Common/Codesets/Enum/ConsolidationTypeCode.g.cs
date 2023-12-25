﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ConsolidationTypeCode.  ISO2002 ID# _Zjlq8CDVEeWCLu74WLgP4w.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the consolidation type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zjlq8CDVEeWCLu74WLgP4w")]
[Description(@"Specifies the consolidation type.")]
public enum ConsolidationTypeCode
{
    /// <summary>
    /// Consolidation is general.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_mJEkwCDVEeWCLu74WLgP4w")]
    [Description(@"Consolidation is general.")]
    GENL,
    
    /// <summary>
    /// Consolidation is at the level of the participant.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_pNTx0CDVEeWCLu74WLgP4w")]
    [Description(@"Consolidation is at the level of the participant.")]
    PART,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ConsolidationTypeCodeMetadataExtensions
{
    private static readonly ConsolidationTypeCodeDropdownSource _dropdownSource = new ConsolidationTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IConsolidationTypeCodeDropdownRow GetMetadata(this ConsolidationTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


