﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for NoticePeriodTypeCode.  ISO2002 ID# _aNwLcNp-Ed-ak6NoX_4Aeg_1085847746.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of notice period.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="NoticePeriodTypeCodeDropdownSource"/>.
/// Implements <seealso cref="INoticePeriodTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aNwLcNp-Ed-ak6NoX_4Aeg_1085847746")]
public partial class NoticePeriodTypeCodeDropdownRow : EnumMetadataItem<NoticePeriodTypeCode>, INoticePeriodTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of notice period.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public NoticePeriodTypeCodeDropdownRow(NoticePeriodTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
