﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PreferredContactMethod1Code.  ISO2002 ID# _6UHyApqlEeGSON8vddiWzQ_1788250895.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Preferred method used to reach the individual contact within an organisation.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PreferredContactMethod1CodeDropdownSource"/>.
/// Implements <seealso cref="IPreferredContactMethod1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_6UHyApqlEeGSON8vddiWzQ_1788250895")]
public partial class PreferredContactMethod1CodeDropdownRow : EnumMetadataItem<PreferredContactMethod1Code>, IPreferredContactMethod1CodeDropdownRow
{
    /// <summary>
    /// Preferred method used to reach the individual contact within an organisation.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PreferredContactMethod1CodeDropdownRow(PreferredContactMethod1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
