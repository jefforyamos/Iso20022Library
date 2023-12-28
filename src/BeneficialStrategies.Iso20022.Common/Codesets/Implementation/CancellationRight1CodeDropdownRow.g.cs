﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CancellationRight1Code.  ISO2002 ID# _bYjKpdp-Ed-ak6NoX_4Aeg_-1019449690.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CancellationRight1CodeDropdownSource"/>.
/// Implements <seealso cref="ICancellationRight1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bYjKpdp-Ed-ak6NoX_4Aeg_-1019449690")]
public partial class CancellationRight1CodeDropdownRow : EnumMetadataItem<CancellationRight1Code>, ICancellationRight1CodeDropdownRow
{
    /// <summary>
    /// Specifies if the investor has the right to cancel an instruction or, if not, the reason the investor cannot cancel.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CancellationRight1CodeDropdownRow(CancellationRight1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
