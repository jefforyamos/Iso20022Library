﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FXAmountTypeCode.  ISO2002 ID# _7XcKNQNyEe2-vqzwMUAewg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of amount for foreign exchange commissions or fees.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FXAmountTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IFXAmountTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7XcKNQNyEe2-vqzwMUAewg")]
public partial class FXAmountTypeCodeDropdownRow : EnumMetadataItem<FXAmountTypeCode>, IFXAmountTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the type of amount for foreign exchange commissions or fees.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FXAmountTypeCodeDropdownRow(FXAmountTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
