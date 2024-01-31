﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DividendTypeCode.  ISO2002 ID# _axNd2dp-Ed-ak6NoX_4Aeg_-1189024253.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the dividend.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DividendTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IDividendTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_axNd2dp-Ed-ak6NoX_4Aeg_-1189024253")]
public partial class DividendTypeCodeDropdownRow : EnumMetadataItem<DividendTypeCode>, IDividendTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the nature of the dividend.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DividendTypeCodeDropdownRow(DividendTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
