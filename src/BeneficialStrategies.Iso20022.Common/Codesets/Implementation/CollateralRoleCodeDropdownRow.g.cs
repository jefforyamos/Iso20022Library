﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralRoleCode.  ISO2002 ID# _glgtoCDCEeaned5xL18mUQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralRoleCodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralRoleCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_glgtoCDCEeaned5xL18mUQ")]
public partial class CollateralRoleCodeDropdownRow : EnumMetadataItem<CollateralRoleCode>, ICollateralRoleCodeDropdownRow
{
    /// <summary>
    /// Identifies whether the reporting counterparty is a collateral provider or a collateral taker.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralRoleCodeDropdownRow(CollateralRoleCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}