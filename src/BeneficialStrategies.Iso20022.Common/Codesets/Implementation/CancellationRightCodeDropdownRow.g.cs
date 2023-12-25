﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancellationRightCode.  ISO2002 ID# _bYs7odp-Ed-ak6NoX_4Aeg_1275993288.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancellationRightCodeDropdownSource"/>.
/// Implements <seealso cref="ICancellationRightCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bYs7odp-Ed-ak6NoX_4Aeg_1275993288")]
public partial class CancellationRightCodeDropdownRow : EnumMetadataItem<CancellationRightCode>, ICancellationRightCodeDropdownRow
{
    /// <summary>
    /// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancellationRightCodeDropdownRow(CancellationRightCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
