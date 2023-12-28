﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DistributionType3Code.  ISO2002 ID# _wahTcCXWEeOL3KXg7zAfKA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DistributionType3CodeDropdownSource"/>.
/// Implements <seealso cref="IDistributionType3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wahTcCXWEeOL3KXg7zAfKA")]
public partial class DistributionType3CodeDropdownRow : EnumMetadataItem<DistributionType3Code>, IDistributionType3CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DistributionType3CodeDropdownRow(DistributionType3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
