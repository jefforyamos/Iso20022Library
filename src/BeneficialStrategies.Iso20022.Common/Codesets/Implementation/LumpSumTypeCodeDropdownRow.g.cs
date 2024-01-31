﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LumpSumTypeCode.  ISO2002 ID# _SbbakLKdEeiXL6Ccd-oU8g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of lump sum.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LumpSumTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ILumpSumTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_SbbakLKdEeiXL6Ccd-oU8g")]
public partial class LumpSumTypeCodeDropdownRow : EnumMetadataItem<LumpSumTypeCode>, ILumpSumTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of lump sum.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LumpSumTypeCodeDropdownRow(LumpSumTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
