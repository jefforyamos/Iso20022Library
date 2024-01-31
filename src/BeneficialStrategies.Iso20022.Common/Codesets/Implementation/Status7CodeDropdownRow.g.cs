﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Status7Code.  ISO2002 ID# _WMNrgF6uEeSyc4g_pm5hbw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction/vote.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Status7CodeDropdownSource"/>.
/// Implements <seealso cref="IStatus7CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_WMNrgF6uEeSyc4g_pm5hbw")]
public partial class Status7CodeDropdownRow : EnumMetadataItem<Status7Code>, IStatus7CodeDropdownRow
{
    /// <summary>
    /// Specifies the status of an instruction/vote.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Status7CodeDropdownRow(Status7Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
