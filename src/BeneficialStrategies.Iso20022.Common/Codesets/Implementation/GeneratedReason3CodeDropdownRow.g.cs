﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for GeneratedReason3Code.  ISO2002 ID# _OAFTICRjEeOCueHDQ36sww.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the transaction was generated.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="GeneratedReason3CodeDropdownSource"/>.
/// Implements <seealso cref="IGeneratedReason3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OAFTICRjEeOCueHDQ36sww")]
public partial class GeneratedReason3CodeDropdownRow : EnumMetadataItem<GeneratedReason3Code>, IGeneratedReason3CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public GeneratedReason3CodeDropdownRow(GeneratedReason3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
