﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SettlementDateCode.  ISO2002 ID# _ZLby19p-Ed-ak6NoX_4Aeg_336259131.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the date of settlement, in coded form.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SettlementDateCodeDropdownSource"/>.
/// Implements <seealso cref="ISettlementDateCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZLby19p-Ed-ak6NoX_4Aeg_336259131")]
public partial class SettlementDateCodeDropdownRow : EnumMetadataItem<SettlementDateCode>, ISettlementDateCodeDropdownRow
{
    /// <summary>
    /// Specifies the date of settlement, in coded form.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SettlementDateCodeDropdownRow(SettlementDateCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
