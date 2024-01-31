﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TypeTransactionTotalsCode.  ISO2002 ID# _TVfZ-gEcEeCQm6a_G2yO_w_-334806911.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of transactions which are included in the totals.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TypeTransactionTotalsCodeDropdownSource"/>.
/// Implements <seealso cref="ITypeTransactionTotalsCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVfZ-gEcEeCQm6a_G2yO_w_-334806911")]
public partial class TypeTransactionTotalsCodeDropdownRow : EnumMetadataItem<TypeTransactionTotalsCode>, ITypeTransactionTotalsCodeDropdownRow
{
    /// <summary>
    /// Identification of the type of transactions which are included in the totals.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TypeTransactionTotalsCodeDropdownRow(TypeTransactionTotalsCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
