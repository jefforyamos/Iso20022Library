﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for SourceOfCash1Code.  ISO2002 ID# _kWhF0DlHEealR6-8aQ15BA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the origin of cash.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="SourceOfCash1CodeDropdownSource"/>.
/// Implements <seealso cref="ISourceOfCash1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kWhF0DlHEealR6-8aQ15BA")]
public partial class SourceOfCash1CodeDropdownRow : EnumMetadataItem<SourceOfCash1Code>, ISourceOfCash1CodeDropdownRow
{
    /// <summary>
    /// Specifies the origin of cash.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public SourceOfCash1CodeDropdownRow(SourceOfCash1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}