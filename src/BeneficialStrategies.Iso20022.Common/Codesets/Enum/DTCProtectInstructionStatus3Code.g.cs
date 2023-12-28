﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCProtectInstructionStatus3Code.  ISO2002 ID# _CYfP4e2MEeiWtrflKsFqHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// DTC (The Depository Trust Company) system status code of protect instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CYfP4e2MEeiWtrflKsFqHg")]
[Description(@"DTC (The Depository Trust Company) system status code of protect instruction.")]
[DerivedFrom(typeof(DTCInstructionStatusCode))]
public enum DTCProtectInstructionStatus3Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingApproval".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DAg5Me2MEeiWtrflKsFqHg")]
    [Description(@"??")]
    PendingApproval,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Withdrawn".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_DAg5M-2MEeiWtrflKsFqHg")]
    [Description(@"??")]
    Withdrawn,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DTCProtectInstructionStatus3CodeMetadataExtensions
{
    private static readonly DTCProtectInstructionStatus3CodeDropdownSource _dropdownSource = new DTCProtectInstructionStatus3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDTCProtectInstructionStatus3CodeDropdownRow GetMetadata(this DTCProtectInstructionStatus3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


