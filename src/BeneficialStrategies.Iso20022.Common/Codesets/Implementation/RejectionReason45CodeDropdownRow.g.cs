﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason45Code.  ISO2002 ID# _qjj_cFhpEeS5jeC8QHrlrg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specify the reason why the instruction cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason45CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason45CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qjj_cFhpEeS5jeC8QHrlrg")]
public partial class RejectionReason45CodeDropdownRow : EnumMetadataItem<RejectionReason45Code>, IRejectionReason45CodeDropdownRow
{
    /// <summary>
    /// Specify the reason why the instruction cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason45CodeDropdownRow(RejectionReason45Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
