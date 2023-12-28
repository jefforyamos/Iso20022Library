﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PersonIdentificationType6Code.  ISO2002 ID# _QTJ5MQhFEeSUPbC7DbLJpQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PersonIdentificationType6CodeDropdownSource"/>.
/// Implements <seealso cref="IPersonIdentificationType6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QTJ5MQhFEeSUPbC7DbLJpQ")]
public partial class PersonIdentificationType6CodeDropdownRow : EnumMetadataItem<PersonIdentificationType6Code>, IPersonIdentificationType6CodeDropdownRow
{
    /// <summary>
    /// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PersonIdentificationType6CodeDropdownRow(PersonIdentificationType6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}