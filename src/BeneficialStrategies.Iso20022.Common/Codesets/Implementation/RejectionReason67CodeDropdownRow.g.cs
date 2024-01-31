﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason67Code.  ISO2002 ID# _xqxxIBnzEeyroI8qKgB7Mg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason67CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason67CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_xqxxIBnzEeyroI8qKgB7Mg")]
public partial class RejectionReason67CodeDropdownRow : EnumMetadataItem<RejectionReason67Code>, IRejectionReason67CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason67CodeDropdownRow(RejectionReason67Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
