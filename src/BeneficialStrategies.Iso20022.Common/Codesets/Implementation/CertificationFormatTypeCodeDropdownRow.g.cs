﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CertificationFormatTypeCode.  ISO2002 ID# _a78HI9p-Ed-ak6NoX_4Aeg_-1769527950.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the certification format required, that is, physical or electronic format.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CertificationFormatTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICertificationFormatTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a78HI9p-Ed-ak6NoX_4Aeg_-1769527950")]
public partial class CertificationFormatTypeCodeDropdownRow : EnumMetadataItem<CertificationFormatTypeCode>, ICertificationFormatTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the certification format required, that is, physical or electronic format.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CertificationFormatTypeCodeDropdownRow(CertificationFormatTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
