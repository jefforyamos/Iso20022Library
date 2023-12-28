﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DTCAdjustmentPaymentTypeV3Code.  ISO2002 ID# _vYTypsMMEee-Vv_OVx0uAQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the payment adjustment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DTCAdjustmentPaymentTypeV3CodeDropdownSource"/>.
/// Implements <seealso cref="IDTCAdjustmentPaymentTypeV3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vYTypsMMEee-Vv_OVx0uAQ")]
public partial class DTCAdjustmentPaymentTypeV3CodeDropdownRow : EnumMetadataItem<DTCAdjustmentPaymentTypeV3Code>, IDTCAdjustmentPaymentTypeV3CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of the payment adjustment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DTCAdjustmentPaymentTypeV3CodeDropdownRow(DTCAdjustmentPaymentTypeV3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}