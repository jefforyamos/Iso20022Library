﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CreditDebit3Code.  ISO2002 ID# _s9EFxjzcEeWg1_uD_bF5Og.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if an operation is an increase or a decrease.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CreditDebit3CodeDropdownSource"/>.
/// Implements <seealso cref="ICreditDebit3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_s9EFxjzcEeWg1_uD_bF5Og")]
public partial class CreditDebit3CodeDropdownRow : EnumMetadataItem<CreditDebit3Code>, ICreditDebit3CodeDropdownRow
{
    /// <summary>
    /// Specifies if an operation is an increase or a decrease.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CreditDebit3CodeDropdownRow(CreditDebit3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
