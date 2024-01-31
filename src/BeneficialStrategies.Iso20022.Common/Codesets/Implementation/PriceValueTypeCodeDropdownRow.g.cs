﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PriceValueTypeCode.  ISO2002 ID# _aJunEtp-Ed-ak6NoX_4Aeg_-1411699432.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Price will not be paid.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PriceValueTypeCodeDropdownSource"/>.
/// Implements <seealso cref="IPriceValueTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aJunEtp-Ed-ak6NoX_4Aeg_-1411699432")]
public partial class PriceValueTypeCodeDropdownRow : EnumMetadataItem<PriceValueTypeCode>, IPriceValueTypeCodeDropdownRow
{
    /// <summary>
    /// Price will not be paid.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PriceValueTypeCodeDropdownRow(PriceValueTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
