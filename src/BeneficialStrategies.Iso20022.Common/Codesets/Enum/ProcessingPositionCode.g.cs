﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProcessingPositionCode.  ISO2002 ID# _aLED0tp-Ed-ak6NoX_4Aeg_1278061835.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies when an transaction/instruction is to be executed relative to a linked transaction/instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLED0tp-Ed-ak6NoX_4Aeg_1278061835")]
[Description(@"Specifies when an transaction/instruction is to be executed relative to a linked transaction/instruction.")]
public enum ProcessingPositionCode
{
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed after the linked transaction/instruction.
    /// Encoded/decoded by serializers as "AFTE".
    /// </summary>
    [EnumMember(Value = "AFTE")]
    [IsoId("_aLED09p-Ed-ak6NoX_4Aeg_1278061854")]
    [Description(@"Specifies that the transaction/instruction is to be executed after the linked transaction/instruction.")]
    After,
    
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed with the linked transaction/instruction.
    /// Encoded/decoded by serializers as "WITH".
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_aLED1Np-Ed-ak6NoX_4Aeg_1278061870")]
    [Description(@"Specifies that the transaction/instruction is to be executed with the linked transaction/instruction.")]
    With,
    
    /// <summary>
    /// Specifies that the transaction/instruction is to be executed before the linked transaction/instruction.
    /// Encoded/decoded by serializers as "BEFO".
    /// </summary>
    [EnumMember(Value = "BEFO")]
    [IsoId("_aLED1dp-Ed-ak6NoX_4Aeg_1278061871")]
    [Description(@"Specifies that the transaction/instruction is to be executed before the linked transaction/instruction.")]
    Before,
    
    /// <summary>
    /// Specifies that the transactions/instructions are linked for information purposes only.
    /// Encoded/decoded by serializers as "INFO".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_aLED1tp-Ed-ak6NoX_4Aeg_1278061880")]
    [Description(@"Specifies that the transactions/instructions are linked for information purposes only.")]
    Information,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProcessingPositionCodeMetadataExtensions
{
    private static readonly ProcessingPositionCodeDropdownSource _dropdownSource = new ProcessingPositionCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProcessingPositionCodeDropdownRow GetMetadata(this ProcessingPositionCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

