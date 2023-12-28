﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Instruction5Code.  ISO2002 ID# _aW-_9dp-Ed-ak6NoX_4Aeg_1768251033.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aW-_9dp-Ed-ak6NoX_4Aeg_1768251033")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).")]
[DerivedFrom(typeof(InstructionCode))]
public enum Instruction5Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhoneBeneficiary".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aW-_9tp-Ed-ak6NoX_4Aeg_1896618964")]
    [Description(@"??")]
    PhoneBeneficiary,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Telecom".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aW-_99p-Ed-ak6NoX_4Aeg_1896618989")]
    [Description(@"??")]
    Telecom,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Instruction5CodeMetadataExtensions
{
    private static readonly Instruction5CodeDropdownSource _dropdownSource = new Instruction5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstruction5CodeDropdownRow GetMetadata(this Instruction5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


