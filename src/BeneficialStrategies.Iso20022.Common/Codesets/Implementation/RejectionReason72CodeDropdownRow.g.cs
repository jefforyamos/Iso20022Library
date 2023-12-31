﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RejectionReason72Code.  ISO2002 ID# _FT0YVCtWEeyhipY4f42fZQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the settlement instruction has a rejected status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RejectionReason72CodeDropdownSource"/>.
/// Implements <seealso cref="IRejectionReason72CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FT0YVCtWEeyhipY4f42fZQ")]
public partial class RejectionReason72CodeDropdownRow : EnumMetadataItem<RejectionReason72Code>, IRejectionReason72CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the settlement instruction has a rejected status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RejectionReason72CodeDropdownRow(RejectionReason72Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
