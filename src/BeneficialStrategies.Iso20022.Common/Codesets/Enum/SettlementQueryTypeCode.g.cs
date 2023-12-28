﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SettlementQueryTypeCode.  ISO2002 ID# _j4AIZO5NEeCisYr99QEiWA_1321527549.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of settlement instruction query to be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j4AIZO5NEeCisYr99QEiWA_1321527549")]
[Description(@"Specifies the type of settlement instruction query to be executed.")]
public enum SettlementQueryTypeCode
{
    /// <summary>
    /// Queries settlement instructions based on criteria excluding statuses.
    /// Encoded/decoded by serializers as "INST".
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_j4JSUO5NEeCisYr99QEiWA_-2074590614")]
    [Description(@"Queries settlement instructions based on criteria excluding statuses.")]
    Instruction,
    
    /// <summary>
    /// Queries settlement instructions based on criteria that includes statuses.
    /// Encoded/decoded by serializers as "STTS".
    /// </summary>
    [EnumMember(Value = "STTS")]
    [IsoId("_j4JSUe5NEeCisYr99QEiWA_965427297")]
    [Description(@"Queries settlement instructions based on criteria that includes statuses.")]
    Status,
    
    /// <summary>
    /// Queries settlement instructions based on criteria that includes statuses during a period.
    /// Encoded/decoded by serializers as "STPD".
    /// </summary>
    [EnumMember(Value = "STPD")]
    [IsoId("_j4JSUu5NEeCisYr99QEiWA_-206849825")]
    [Description(@"Queries settlement instructions based on criteria that includes statuses during a period.")]
    StatusPeriod,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SettlementQueryTypeCodeMetadataExtensions
{
    private static readonly SettlementQueryTypeCodeDropdownSource _dropdownSource = new SettlementQueryTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISettlementQueryTypeCodeDropdownRow GetMetadata(this SettlementQueryTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


