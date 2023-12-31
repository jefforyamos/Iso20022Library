﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TerminationReason1Code.  ISO2002 ID# _0mEXMHyiEeGWJuGCfvwOsQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the termination reason.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TerminationReason1CodeDropdownSource"/>.
/// Implements <seealso cref="ITerminationReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0mEXMHyiEeGWJuGCfvwOsQ")]
public partial class TerminationReason1CodeDropdownRow : EnumMetadataItem<TerminationReason1Code>, ITerminationReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the termination reason.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TerminationReason1CodeDropdownRow(TerminationReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
