﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstructionQueryTypeCode.  ISO2002 ID# _jj4Sgu5NEeCisYr99QEiWA_1468427888.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of instruction queried.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jj4Sgu5NEeCisYr99QEiWA_1468427888")]
[Description(@"Specifies the type of instruction queried.")]
public enum InstructionQueryTypeCode
{
    /// <summary>
    /// Query is performed on settlement transactions.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_jj4Sg-5NEeCisYr99QEiWA_-977223942")]
    [Description(@"Query is performed on settlement transactions.")]
    SETT,
    
    /// <summary>
    /// Query is performed on intra-position movements.
    /// </summary>
    [EnumMember(Value = "IPOS")]
    [IsoId("_jj4ShO5NEeCisYr99QEiWA_-1633617554")]
    [Description(@"Query is performed on intra-position movements.")]
    IPOS,
    
    /// <summary>
    /// Query is performed on both settlement transactions and intra-position movements.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_jkCDgO5NEeCisYr99QEiWA_298522406")]
    [Description(@"Query is performed on both settlement transactions and intra-position movements.")]
    BOTH,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstructionQueryTypeCodeMetadataExtensions
{
    private static readonly InstructionQueryTypeCodeDropdownSource _dropdownSource = new InstructionQueryTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstructionQueryTypeCodeDropdownRow GetMetadata(this InstructionQueryTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


