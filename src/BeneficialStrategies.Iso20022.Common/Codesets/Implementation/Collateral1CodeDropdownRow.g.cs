﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Collateral1Code.  ISO2002 ID# _ObDuwCC-EeWPMvNwVtiMsA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the item is used as collateral.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Collateral1CodeDropdownSource"/>.
/// Implements <seealso cref="ICollateral1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ObDuwCC-EeWPMvNwVtiMsA")]
public partial class Collateral1CodeDropdownRow : EnumMetadataItem<Collateral1Code>, ICollateral1CodeDropdownRow
{
    /// <summary>
    /// Specifies whether the item is used as collateral.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Collateral1CodeDropdownRow(Collateral1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
