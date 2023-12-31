﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PINFormat4Code.  ISO2002 ID# _XsWNgIocEeSirOZJBRz_nA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format of an ATM PIN block before encryption.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PINFormat4CodeDropdownSource"/>.
/// Implements <seealso cref="IPINFormat4CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_XsWNgIocEeSirOZJBRz_nA")]
public partial class PINFormat4CodeDropdownRow : EnumMetadataItem<PINFormat4Code>, IPINFormat4CodeDropdownRow
{
    /// <summary>
    /// Format of an ATM PIN block before encryption.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PINFormat4CodeDropdownRow(PINFormat4Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
