﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CallTypeCode.  ISO2002 ID# _ha1jt2liEeGaMcKyqKNRfQ_1405973074.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of execution of the call feature.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CallTypeCodeDropdownSource"/>.
/// Implements <seealso cref="ICallTypeCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ha1jt2liEeGaMcKyqKNRfQ_1405973074")]
public partial class CallTypeCodeDropdownRow : EnumMetadataItem<CallTypeCode>, ICallTypeCodeDropdownRow
{
    /// <summary>
    /// Defines the type of execution of the call feature.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CallTypeCodeDropdownRow(CallTypeCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
