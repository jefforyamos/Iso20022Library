﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for Instruction4Code.  ISO2002 ID# _aW-_8tp-Ed-ak6NoX_4Aeg_-1362532082.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aW-_8tp-Ed-ak6NoX_4Aeg_-1362532082")]
[Description(@"Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).")]
[DerivedFrom(typeof(InstructionCode))]
public enum Instruction4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PhoneNextAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aW-_89p-Ed-ak6NoX_4Aeg_-1285879464")]
    [Description(@"??")]
    PhoneNextAgent,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "TelecomNextAgent".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_aW-_9Np-Ed-ak6NoX_4Aeg_-1285879404")]
    [Description(@"??")]
    TelecomNextAgent,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class Instruction4CodeMetadataExtensions
{
    private static readonly Instruction4CodeDropdownSource _dropdownSource = new Instruction4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IInstruction4CodeDropdownRow GetMetadata(this Instruction4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

