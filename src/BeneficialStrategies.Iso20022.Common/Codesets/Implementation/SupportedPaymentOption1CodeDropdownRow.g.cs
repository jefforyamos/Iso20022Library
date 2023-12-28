﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SupportedPaymentOption1Code.  ISO2002 ID# _-6mVcDANEeOqioR9srQH1g.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the options supported for a payment transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SupportedPaymentOption1CodeDropdownSource"/>.
/// Implements <seealso cref="ISupportedPaymentOption1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-6mVcDANEeOqioR9srQH1g")]
public partial class SupportedPaymentOption1CodeDropdownRow : EnumMetadataItem<SupportedPaymentOption1Code>, ISupportedPaymentOption1CodeDropdownRow
{
    /// <summary>
    /// Specifies the options supported for a payment transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SupportedPaymentOption1CodeDropdownRow(SupportedPaymentOption1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
