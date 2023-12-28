﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectReason1Code.  ISO2002 ID# _TT2bOAEcEeCQm6a_G2yO_w_-1578182906.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Reason of transmission of a rejection message in response to a request or an advice.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TT2bOAEcEeCQm6a_G2yO_w_-1578182906")]
public partial class RejectReason1CodeDropdownRow : EnumMetadataItem<RejectReason1Code>, IRejectReason1CodeDropdownRow
{
    /// <summary>
    /// Reason of transmission of a rejection message in response to a request or an advice.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectReason1CodeDropdownRow(RejectReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
