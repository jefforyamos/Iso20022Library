﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TelephonyCallType1Code.  ISO2002 ID# _YOAJsDEvEemzCpWiCwK4aQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the call type
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TelephonyCallType1CodeDropdownSource"/>.
/// Implements <seealso cref="ITelephonyCallType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YOAJsDEvEemzCpWiCwK4aQ")]
public partial class TelephonyCallType1CodeDropdownRow : EnumMetadataItem<TelephonyCallType1Code>, ITelephonyCallType1CodeDropdownRow
{
    /// <summary>
    /// Indicates the call type
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TelephonyCallType1CodeDropdownRow(TelephonyCallType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
