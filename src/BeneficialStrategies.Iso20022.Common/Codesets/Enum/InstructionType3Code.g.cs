﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstructionType3Code.  ISO2002 ID# _aYn-uNp-Ed-ak6NoX_4Aeg_-1349456912.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the submitted data set must be matched or pre-matched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aYn-uNp-Ed-ak6NoX_4Aeg_-1349456912")]
[Description(@"Specifies whether the submitted data set must be matched or pre-matched.")]
[DerivedFrom(typeof(InstructionTypeCode))]
public enum InstructionType3Code
{
    /// <summary>
    /// Instruction to match a data set.
    /// Encoded/decoded by serializers as "MTCH".
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_aYxvsNp-Ed-ak6NoX_4Aeg_-1294968773")]
    [Description(@"Instruction to match a data set.")]
    Match = InstructionTypeCode.Match, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction to pre-match a data set.
    /// Encoded/decoded by serializers as "PMTC".
    /// </summary>
    [EnumMember(Value = "PMTC")]
    [IsoId("_aYxvsdp-Ed-ak6NoX_4Aeg_-1294968370")]
    [Description(@"Instruction to pre-match a data set.")]
    PreMatch = InstructionTypeCode.PreMatch, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class InstructionType3CodeMetadataExtensions
{
    private static readonly InstructionType3CodeDropdownSource _dropdownSource = new InstructionType3CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstructionType3CodeDropdownRow GetMetadata(this InstructionType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


