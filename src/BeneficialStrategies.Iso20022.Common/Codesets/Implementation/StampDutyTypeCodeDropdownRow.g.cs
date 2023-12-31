﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StampDutyTypeCode.  ISO2002 ID# _ZPdXN9p-Ed-ak6NoX_4Aeg_930727871.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the stamp duty is applicable.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StampDutyTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IStampDutyTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZPdXN9p-Ed-ak6NoX_4Aeg_930727871")]
public partial class StampDutyTypeCodeDropdownRow : EnumMetadataItem<StampDutyTypeCode>, IStampDutyTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies if the stamp duty is applicable.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StampDutyTypeCodeDropdownRow(StampDutyTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
