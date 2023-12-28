﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for LodgingActivity1Code.  ISO2002 ID# _AWjbYGMdEeexSYCBvAp_qA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Lodging type of activity.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="LodgingActivity1CodeDropdownSource"/>.
/// Implements <seealso cref="ILodgingActivity1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AWjbYGMdEeexSYCBvAp_qA")]
public partial class LodgingActivity1CodeDropdownRow : EnumMetadataItem<LodgingActivity1Code>, ILodgingActivity1CodeDropdownRow
{
    /// <summary>
    /// Lodging type of activity.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public LodgingActivity1CodeDropdownRow(LodgingActivity1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
