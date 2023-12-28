﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DTCBaseDisbursed1Code.  ISO2002 ID# _1qBZgzL3EeKU9IrkkToqcw_633983663.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code qualifying whether the calculation basis is on base (original) or disbursed (distributed) security.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DTCBaseDisbursed1CodeDropdownSource"/>.
/// Implements <seealso cref="IDTCBaseDisbursed1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1qBZgzL3EeKU9IrkkToqcw_633983663")]
public partial class DTCBaseDisbursed1CodeDropdownRow : EnumMetadataItem<DTCBaseDisbursed1Code>, IDTCBaseDisbursed1CodeDropdownRow
{
    /// <summary>
    /// Code qualifying whether the calculation basis is on base (original) or disbursed (distributed) security.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DTCBaseDisbursed1CodeDropdownRow(DTCBaseDisbursed1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
