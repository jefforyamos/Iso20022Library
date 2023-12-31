﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RepurchaseType2Code.  ISO2002 ID# _ZTe7ltp-Ed-ak6NoX_4Aeg_212758394.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of repurchase transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RepurchaseType2CodeDropdownSource"/>.
/// Implements <seealso cref="IRepurchaseType2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZTe7ltp-Ed-ak6NoX_4Aeg_212758394")]
public partial class RepurchaseType2CodeDropdownRow : EnumMetadataItem<RepurchaseType2Code>, IRepurchaseType2CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RepurchaseType2CodeDropdownRow(RepurchaseType2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
