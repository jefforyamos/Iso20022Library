﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PrioritisationCode.  ISO2002 ID# _aKBiBNp-Ed-ak6NoX_4Aeg_-62106922.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates if one side or the other of a cross order should be prioritized.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PrioritisationCodeDropdownSource"/>.
/// Implements <seealso cref="IPrioritisationCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aKBiBNp-Ed-ak6NoX_4Aeg_-62106922")]
public partial class PrioritisationCodeDropdownRow : EnumMetadataItem<PrioritisationCode>, IPrioritisationCodeDropdownRow
{
    /// <summary>
    /// Indicates if one side or the other of a cross order should be prioritized.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PrioritisationCodeDropdownRow(PrioritisationCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
