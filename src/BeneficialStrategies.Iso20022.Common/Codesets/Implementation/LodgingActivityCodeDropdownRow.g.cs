﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LodgingActivityCode.  ISO2002 ID# _U7-5MGMbEeexSYCBvAp_qA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of lodging activity.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LodgingActivityCodeDropdownSource"/>.
/// Implements <seealso cref="ILodgingActivityCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_U7-5MGMbEeexSYCBvAp_qA")]
public partial class LodgingActivityCodeDropdownRow : EnumMetadataItem<LodgingActivityCode>, ILodgingActivityCodeDropdownRow
{
    /// <summary>
    /// Type of lodging activity.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LodgingActivityCodeDropdownRow(LodgingActivityCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}