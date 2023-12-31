﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RestrictionTypeCode.  ISO2002 ID# _Y94fBdp-Ed-ak6NoX_4Aeg_-1122710739.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of restriction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RestrictionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IRestrictionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Y94fBdp-Ed-ak6NoX_4Aeg_-1122710739")]
public partial class RestrictionTypeCodeDropdownRow : EnumMetadataItem<RestrictionTypeCode>, IRestrictionTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of restriction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RestrictionTypeCodeDropdownRow(RestrictionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
