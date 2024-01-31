﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CommissionTypeV2Code.  ISO2002 ID# _bAHcidp-Ed-ak6NoX_4Aeg_-432346988.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which the commission is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CommissionTypeV2CodeDropdownSource"/>.
/// Implements <seealso cref="ICommissionTypeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bAHcidp-Ed-ak6NoX_4Aeg_-432346988")]
public partial class CommissionTypeV2CodeDropdownRow : EnumMetadataItem<CommissionTypeV2Code>, ICommissionTypeV2CodeDropdownRow
{
    /// <summary>
    /// Type of service for which the commission is asked or paid.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CommissionTypeV2CodeDropdownRow(CommissionTypeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
