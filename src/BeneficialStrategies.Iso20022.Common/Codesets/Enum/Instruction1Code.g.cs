﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Instruction1Code.  ISO2002 ID# _aW12Adp-Ed-ak6NoX_4Aeg_-499701817.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aW12Adp-Ed-ak6NoX_4Aeg_-499701817")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).")]
[DerivedFrom(typeof(InstructionCode))]
public enum Instruction1Code
{
    /// <summary>
    /// (Ultimate) creditor to be paid only after verification of identity.
    /// Encoded/decoded by serializers as "PayTheBeneficiary".
    /// </summary>
    [EnumMember(Value = "PBEN")]
    [IsoId("_aW12Atp-Ed-ak6NoX_4Aeg_-499701816")]
    [Description(@"(Ultimate) creditor to be paid only after verification of identity.")]
    PayTheBeneficiary,
    
    /// <summary>
    /// Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected.
    /// Encoded/decoded by serializers as "TimeTill".
    /// </summary>
    [EnumMember(Value = "TTIL")]
    [IsoId("_aW12A9p-Ed-ak6NoX_4Aeg_-499701815")]
    [Description(@"Payment instruction is valid and eligible for execution until the date and time stipulated. Otherwise, the payment instruction will be rejected.")]
    TimeTill,
    
    /// <summary>
    /// Payment instruction will be valid and eligible for execution from the date and time stipulated.
    /// Encoded/decoded by serializers as "TimeFrom".
    /// </summary>
    [EnumMember(Value = "TFRO")]
    [IsoId("_aW12BNp-Ed-ak6NoX_4Aeg_-499701814")]
    [Description(@"Payment instruction will be valid and eligible for execution from the date and time stipulated.")]
    TimeFrom,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Instruction1CodeMetadataExtensions
{
    private static readonly Instruction1CodeDropdownSource _dropdownSource = new Instruction1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstruction1CodeDropdownRow GetMetadata(this Instruction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


