﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason54Code.  ISO2002 ID# _YckA2uXyEemEj48jhmlA0Q.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction request has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason54CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason54CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YckA2uXyEemEj48jhmlA0Q")]
public partial class RejectionReason54CodeDropdownRow : EnumMetadataItem<RejectionReason54Code>, IRejectionReason54CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the instruction request has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason54CodeDropdownRow(RejectionReason54Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
