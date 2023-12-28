﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralSubstitutionType1Code.  ISO2002 ID# _YcDkVNp-Ed-ak6NoX_4Aeg_917519215.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralSubstitutionType1CodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralSubstitutionType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcDkVNp-Ed-ak6NoX_4Aeg_917519215")]
public partial class CollateralSubstitutionType1CodeDropdownRow : EnumMetadataItem<CollateralSubstitutionType1Code>, ICollateralSubstitutionType1CodeDropdownRow
{
    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralSubstitutionType1CodeDropdownRow(CollateralSubstitutionType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}