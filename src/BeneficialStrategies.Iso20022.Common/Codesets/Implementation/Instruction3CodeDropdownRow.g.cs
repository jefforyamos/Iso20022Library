﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Instruction3Code.  ISO2002 ID# _aW12Bdp-Ed-ak6NoX_4Aeg_68416834.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Instruction3CodeDropdownSource"/>.
/// Implements <seealso cref="IInstruction3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aW12Bdp-Ed-ak6NoX_4Aeg_68416834")]
public partial class Instruction3CodeDropdownRow : EnumMetadataItem<Instruction3Code>, IInstruction3CodeDropdownRow
{
    /// <summary>
    /// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Instruction3CodeDropdownRow(Instruction3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
