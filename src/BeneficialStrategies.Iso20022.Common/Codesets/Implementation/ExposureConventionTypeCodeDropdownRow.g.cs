﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExposureConventionTypeCode.  ISO2002 ID# _YczLM9p-Ed-ak6NoX_4Aeg_-483728852.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines how the variation margin requirement will be calculated, either net or gross.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExposureConventionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IExposureConventionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YczLM9p-Ed-ak6NoX_4Aeg_-483728852")]
public partial class ExposureConventionTypeCodeDropdownRow : EnumMetadataItem<ExposureConventionTypeCode>, IExposureConventionTypeCodeDropdownRow
{
    /// <summary>
    /// Determines how the variation margin requirement will be calculated, either net or gross.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExposureConventionTypeCodeDropdownRow(ExposureConventionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
