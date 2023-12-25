﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProcessingPosition1Code.  ISO2002 ID# _aKxI5tp-Ed-ak6NoX_4Aeg_1002961302.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates when an instruction is to be executed relative to a linked instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aKxI5tp-Ed-ak6NoX_4Aeg_1002961302")]
[Description(@"Indicates when an instruction is to be executed relative to a linked instruction.")]
public enum ProcessingPosition1Code
{
    /// <summary>
    /// Indicates that the instruction is to be executed after the linked instruction.
    /// </summary>
    [EnumMember(Value = "AFTR")]
    [IsoId("_aKxI59p-Ed-ak6NoX_4Aeg_1050983994")]
    [Description(@"Indicates that the instruction is to be executed after the linked instruction.")]
    AFTR,
    
    /// <summary>
    /// Indicates that the instruction is to be executed with the linked instruction.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aKxI6Np-Ed-ak6NoX_4Aeg_1067607065")]
    [Description(@"Indicates that the instruction is to be executed with the linked instruction.")]
    WITH,
    
    /// <summary>
    /// Indicates that the instruction is to be executed before the linked instruction.
    /// </summary>
    [EnumMember(Value = "BEFR")]
    [IsoId("_aK654Np-Ed-ak6NoX_4Aeg_1089773397")]
    [Description(@"Indicates that the instruction is to be executed before the linked instruction.")]
    BEFR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProcessingPosition1CodeMetadataExtensions
{
    private static readonly ProcessingPosition1CodeDropdownSource _dropdownSource = new ProcessingPosition1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProcessingPosition1CodeDropdownRow GetMetadata(this ProcessingPosition1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


