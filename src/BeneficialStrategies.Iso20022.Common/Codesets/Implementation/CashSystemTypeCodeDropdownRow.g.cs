﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CashSystemTypeCode.  ISO2002 ID# _a7fbNdp-Ed-ak6NoX_4Aeg_-1434318267.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of payment system.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CashSystemTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICashSystemTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a7fbNdp-Ed-ak6NoX_4Aeg_-1434318267")]
public partial class CashSystemTypeCodeDropdownRow : EnumMetadataItem<CashSystemTypeCode>, ICashSystemTypeCodeDropdownRow
{
    /// <summary>
    /// Specifies a type of payment system.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CashSystemTypeCodeDropdownRow(CashSystemTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
