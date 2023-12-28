﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PledgeeTypeCode.  ISO2002 ID# _fynYkE9ZEeSn2-3swbRbzg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of pledgee.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PledgeeTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IPledgeeTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fynYkE9ZEeSn2-3swbRbzg")]
public partial class PledgeeTypeCodeDropdownRow : EnumMetadataItem<PledgeeTypeCode>, IPledgeeTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of pledgee.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PledgeeTypeCodeDropdownRow(PledgeeTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}