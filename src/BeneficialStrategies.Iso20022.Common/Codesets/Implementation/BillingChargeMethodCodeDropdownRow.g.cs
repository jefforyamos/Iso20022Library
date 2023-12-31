﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BillingChargeMethodCode.  ISO2002 ID# _6VBJ4JqlEeGSON8vddiWzQ_185173983.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines how the billing charge is calculated.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BillingChargeMethodCodeDropdownSource"/>.
/// Implements <seealso cref="IBillingChargeMethodCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6VBJ4JqlEeGSON8vddiWzQ_185173983")]
public partial class BillingChargeMethodCodeDropdownRow : EnumMetadataItem<BillingChargeMethodCode>, IBillingChargeMethodCodeDropdownRow
{
    /// <summary>
    /// Defines how the billing charge is calculated.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BillingChargeMethodCodeDropdownRow(BillingChargeMethodCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
