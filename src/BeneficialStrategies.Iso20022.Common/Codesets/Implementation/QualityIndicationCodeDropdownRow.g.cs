﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for QualityIndicationCode.  ISO2002 ID# _ZXWu8Np-Ed-ak6NoX_4Aeg_336258088.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the relative quality of the indication of interest.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="QualityIndicationCodeDropdownSource"/>.
/// Implements <seealso cref="IQualityIndicationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZXWu8Np-Ed-ak6NoX_4Aeg_336258088")]
public partial class QualityIndicationCodeDropdownRow : EnumMetadataItem<QualityIndicationCode>, IQualityIndicationCodeDropdownRow
{
    /// <summary>
    /// Indicates the relative quality of the indication of interest.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public QualityIndicationCodeDropdownRow(QualityIndicationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}