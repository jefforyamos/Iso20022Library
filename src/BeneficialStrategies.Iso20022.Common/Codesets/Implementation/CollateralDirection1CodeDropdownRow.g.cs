﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralDirection1Code.  ISO2002 ID# _bpmYYAMyEeutW5-TpeYJhA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Direction of the collateral being reported expressed as a code.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralDirection1CodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralDirection1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bpmYYAMyEeutW5-TpeYJhA")]
public partial class CollateralDirection1CodeDropdownRow : EnumMetadataItem<CollateralDirection1Code>, ICollateralDirection1CodeDropdownRow
{
    /// <summary>
    /// Direction of the collateral being reported expressed as a code.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralDirection1CodeDropdownRow(CollateralDirection1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
