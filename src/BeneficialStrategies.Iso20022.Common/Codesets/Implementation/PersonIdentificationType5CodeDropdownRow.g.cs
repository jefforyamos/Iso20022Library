﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PersonIdentificationType5Code.  ISO2002 ID# _o7H_wBQQEeKCyZtSz_i3FA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PersonIdentificationType5CodeDropdownSource"/>.
/// Implements <seealso cref="IPersonIdentificationType5CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_o7H_wBQQEeKCyZtSz_i3FA")]
public partial class PersonIdentificationType5CodeDropdownRow : EnumMetadataItem<PersonIdentificationType5Code>, IPersonIdentificationType5CodeDropdownRow
{
    /// <summary>
    /// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PersonIdentificationType5CodeDropdownRow(PersonIdentificationType5Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
