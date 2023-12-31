﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for CollateralSubstitutionSequenceCode.  ISO2002 ID# _YcDkUdp-Ed-ak6NoX_4Aeg_406031234.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates whether the collateral substitution request is new or updated.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="CollateralSubstitutionSequenceCodeDropdownSource"/>.
/// Implements <seealso cref="ICollateralSubstitutionSequenceCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YcDkUdp-Ed-ak6NoX_4Aeg_406031234")]
public partial class CollateralSubstitutionSequenceCodeDropdownRow : EnumMetadataItem<CollateralSubstitutionSequenceCode>, ICollateralSubstitutionSequenceCodeDropdownRow
{
    /// <summary>
    /// Indicates whether the collateral substitution request is new or updated.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public CollateralSubstitutionSequenceCodeDropdownRow(CollateralSubstitutionSequenceCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
