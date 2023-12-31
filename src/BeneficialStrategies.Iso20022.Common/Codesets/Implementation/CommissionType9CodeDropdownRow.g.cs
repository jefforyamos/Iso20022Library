﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CommissionType9Code.  ISO2002 ID# __1f1pNojEeC60axPepSq7g_1349927182.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of service for which the commission is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CommissionType9CodeDropdownSource"/>.
/// Implements <seealso cref="ICommissionType9CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__1f1pNojEeC60axPepSq7g_1349927182")]
public partial class CommissionType9CodeDropdownRow : EnumMetadataItem<CommissionType9Code>, ICommissionType9CodeDropdownRow
{
    /// <summary>
    /// Type of service for which the commission is asked or paid.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CommissionType9CodeDropdownRow(CommissionType9Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
