﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DateTypeCode.  ISO2002 ID# _ayjhp9p-Ed-ak6NoX_4Aeg_-2092185589.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Ongoing basis, which indicates that the date is determined by "ongoing basis" process, for example "au fil de l'eau".
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DateTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDateTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ayjhp9p-Ed-ak6NoX_4Aeg_-2092185589")]
public partial class DateTypeCodeDropdownRow : EnumMetadataItem<DateTypeCode>, IDateTypeCodeDropdownRow
{
    /// <summary>
    /// Ongoing basis, which indicates that the date is determined by "ongoing basis" process, for example "au fil de l'eau".
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DateTypeCodeDropdownRow(DateTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
