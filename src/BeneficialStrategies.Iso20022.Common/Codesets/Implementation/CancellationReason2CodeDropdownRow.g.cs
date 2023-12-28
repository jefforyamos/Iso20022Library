﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancellationReason2Code.  ISO2002 ID# _bX9Ux9p-Ed-ak6NoX_4Aeg_1539844320.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancellationReason2CodeDropdownSource"/>.
/// Implements <seealso cref="ICancellationReason2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bX9Ux9p-Ed-ak6NoX_4Aeg_1539844320")]
public partial class CancellationReason2CodeDropdownRow : EnumMetadataItem<CancellationReason2Code>, ICancellationReason2CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for requesting the cancellation of a payment instruction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancellationReason2CodeDropdownRow(CancellationReason2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}