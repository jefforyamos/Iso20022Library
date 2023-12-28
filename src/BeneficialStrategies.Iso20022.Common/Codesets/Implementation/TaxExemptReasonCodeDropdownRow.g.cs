﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TaxExemptReasonCode.  ISO2002 ID# _YhkWcNp-Ed-ak6NoX_4Aeg_-1906851692.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TaxExemptReasonCodeDropdownSource"/>.
/// Implements <seealso cref="ITaxExemptReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YhkWcNp-Ed-ak6NoX_4Aeg_-1906851692")]
public partial class TaxExemptReasonCodeDropdownRow : EnumMetadataItem<TaxExemptReasonCode>, ITaxExemptReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason a specific tax has not been levied/deducted on a given transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TaxExemptReasonCodeDropdownRow(TaxExemptReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}