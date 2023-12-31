﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartialInstruction3Code.  ISO2002 ID# _ZxSR49p-Ed-ak6NoX_4Aeg_528226726.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartialInstruction3CodeDropdownSource"/>.
/// Implements <seealso cref="IPartialInstruction3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZxSR49p-Ed-ak6NoX_4Aeg_528226726")]
public partial class PartialInstruction3CodeDropdownRow : EnumMetadataItem<PartialInstruction3Code>, IPartialInstruction3CodeDropdownRow
{
    /// <summary>
    /// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartialInstruction3CodeDropdownRow(PartialInstruction3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
