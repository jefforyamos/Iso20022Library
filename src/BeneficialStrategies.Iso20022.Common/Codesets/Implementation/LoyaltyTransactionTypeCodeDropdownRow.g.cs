﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LoyaltyTransactionTypeCode.  ISO2002 ID# _fVeOYNuKEeiB5uLfkg9ZJA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of loyalty transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LoyaltyTransactionTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ILoyaltyTransactionTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_fVeOYNuKEeiB5uLfkg9ZJA")]
public partial class LoyaltyTransactionTypeCodeDropdownRow : EnumMetadataItem<LoyaltyTransactionTypeCode>, ILoyaltyTransactionTypeCodeDropdownRow
{
    /// <summary>
    /// Type of loyalty transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LoyaltyTransactionTypeCodeDropdownRow(LoyaltyTransactionTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
