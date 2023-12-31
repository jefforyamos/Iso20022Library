﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for FailureReason1Code.  ISO2002 ID# _TTG0VgEcEeCQm6a_G2yO_w_-530191250.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// List of incidents happening during the transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="FailureReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IFailureReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TTG0VgEcEeCQm6a_G2yO_w_-530191250")]
public partial class FailureReason1CodeDropdownRow : EnumMetadataItem<FailureReason1Code>, IFailureReason1CodeDropdownRow
{
    /// <summary>
    /// List of incidents happening during the transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public FailureReason1CodeDropdownRow(FailureReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
