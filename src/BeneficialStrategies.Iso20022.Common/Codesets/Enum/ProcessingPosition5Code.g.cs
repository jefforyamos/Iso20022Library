﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProcessingPosition5Code.  ISO2002 ID# _7_v2oGaxEeWZev0W8F756g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7_v2oGaxEeWZev0W8F756g")]
[Description(@"Specifies when a transaction/instruction is to be executed relative to a linked transaction/instruction.")]
[DerivedFrom(typeof(ProcessingPositionCode))]
public enum ProcessingPosition5Code
{
    /// <summary>
    /// Specifies that the transactions/instructions are linked for information purposes only.
    /// Encoded/decoded by serializers as "INFO".
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_-jjQIWaxEeWZev0W8F756g")]
    [Description(@"Specifies that the transactions/instructions are linked for information purposes only.")]
    Information = ProcessingPositionCode.Information, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProcessingPosition5CodeMetadataExtensions
{
    private static readonly ProcessingPosition5CodeDropdownSource _dropdownSource = new ProcessingPosition5CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProcessingPosition5CodeDropdownRow GetMetadata(this ProcessingPosition5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


