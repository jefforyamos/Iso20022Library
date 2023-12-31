﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TypeTransactionTotals1Code.  ISO2002 ID# _TUJ9PwEcEeCQm6a_G2yO_w_592182673.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of transactions which are included in the totals.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TypeTransactionTotals1CodeDropdownSource"/>.
/// Implements <seealso cref="ITypeTransactionTotals1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TUJ9PwEcEeCQm6a_G2yO_w_592182673")]
public partial class TypeTransactionTotals1CodeDropdownRow : EnumMetadataItem<TypeTransactionTotals1Code>, ITypeTransactionTotals1CodeDropdownRow
{
    /// <summary>
    /// Identification of the type of transactions which are included in the totals.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TypeTransactionTotals1CodeDropdownRow(TypeTransactionTotals1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
