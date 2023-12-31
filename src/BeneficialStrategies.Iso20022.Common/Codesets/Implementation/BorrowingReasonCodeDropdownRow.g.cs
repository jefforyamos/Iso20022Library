﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BorrowingReasonCode.  ISO2002 ID# __0dT09ojEeC60axPepSq7g_1572602070.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the underlying reason for the borrowing.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BorrowingReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IBorrowingReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__0dT09ojEeC60axPepSq7g_1572602070")]
public partial class BorrowingReasonCodeDropdownRow : EnumMetadataItem<BorrowingReasonCode>, IBorrowingReasonCodeDropdownRow
{
    /// <summary>
    /// Identifies the underlying reason for the borrowing.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BorrowingReasonCodeDropdownRow(BorrowingReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
