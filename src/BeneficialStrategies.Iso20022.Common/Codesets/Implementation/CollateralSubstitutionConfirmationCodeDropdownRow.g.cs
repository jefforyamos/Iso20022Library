﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralSubstitutionConfirmationCode.  ISO2002 ID# _Yb5zU9p-Ed-ak6NoX_4Aeg_33978882.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides the status of the collateral substitution, either returned or released.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralSubstitutionConfirmationCodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralSubstitutionConfirmationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yb5zU9p-Ed-ak6NoX_4Aeg_33978882")]
public partial class CollateralSubstitutionConfirmationCodeDropdownRow : EnumMetadataItem<CollateralSubstitutionConfirmationCode>, ICollateralSubstitutionConfirmationCodeDropdownRow
{
    /// <summary>
    /// Provides the status of the collateral substitution, either returned or released.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralSubstitutionConfirmationCodeDropdownRow(CollateralSubstitutionConfirmationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}