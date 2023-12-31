﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ResidenceType1Code.  ISO2002 ID# _JX1ngGjNEeiRg5NzP0jkQg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of residence where the party has its permanent home or principal establishment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ResidenceType1CodeDropdownSource"/>.
/// Implements <seealso cref="IResidenceType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JX1ngGjNEeiRg5NzP0jkQg")]
public partial class ResidenceType1CodeDropdownRow : EnumMetadataItem<ResidenceType1Code>, IResidenceType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of residence where the party has its permanent home or principal establishment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ResidenceType1CodeDropdownRow(ResidenceType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
