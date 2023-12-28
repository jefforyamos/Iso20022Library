﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for StoredValueTransactionTypeCode.  ISO2002 ID# _OuAlgNuNEeiB5uLfkg9ZJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of operation to proceed on the stored value account or the stored value card.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="StoredValueTransactionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IStoredValueTransactionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_OuAlgNuNEeiB5uLfkg9ZJA")]
public partial class StoredValueTransactionTypeCodeDropdownRow : EnumMetadataItem<StoredValueTransactionTypeCode>, IStoredValueTransactionTypeCodeDropdownRow
{
    /// <summary>
    /// Identification of operation to proceed on the stored value account or the stored value card.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public StoredValueTransactionTypeCodeDropdownRow(StoredValueTransactionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}