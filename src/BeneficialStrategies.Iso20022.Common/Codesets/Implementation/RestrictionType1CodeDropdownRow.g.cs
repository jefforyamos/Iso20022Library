﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RestrictionType1Code.  ISO2002 ID# _hbcArmliEeGaMcKyqKNRfQ_2033612003.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of restriction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RestrictionType1CodeDropdownSource"/>.
/// Implements <seealso cref="IRestrictionType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_hbcArmliEeGaMcKyqKNRfQ_2033612003")]
public partial class RestrictionType1CodeDropdownRow : EnumMetadataItem<RestrictionType1Code>, IRestrictionType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of restriction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RestrictionType1CodeDropdownRow(RestrictionType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}