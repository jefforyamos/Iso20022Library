﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ClosedStatusReason1Code.  ISO2002 ID# _Sx9Z8E_wEeaB8-OWTiMVrQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason for the closed status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ClosedStatusReason1CodeDropdownSource"/>.
/// Implements <seealso cref="IClosedStatusReason1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Sx9Z8E_wEeaB8-OWTiMVrQ")]
public partial class ClosedStatusReason1CodeDropdownRow : EnumMetadataItem<ClosedStatusReason1Code>, IClosedStatusReason1CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason for the closed status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ClosedStatusReason1CodeDropdownRow(ClosedStatusReason1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}