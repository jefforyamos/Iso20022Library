﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AmountTypeCode.  ISO2002 ID# _be0KtNp-Ed-ak6NoX_4Aeg_-1456928482.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why an amount is not specified.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AmountTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IAmountTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_be0KtNp-Ed-ak6NoX_4Aeg_-1456928482")]
public partial class AmountTypeCodeDropdownRow : EnumMetadataItem<AmountTypeCode>, IAmountTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why an amount is not specified.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AmountTypeCodeDropdownRow(AmountTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
