﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Frequency11Code.  ISO2002 ID# _1UEkQMhvEeadgvwNGwK05w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Frequency11CodeDropdownSource"/>.
/// Implements <seealso cref="IFrequency11CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1UEkQMhvEeadgvwNGwK05w")]
public partial class Frequency11CodeDropdownRow : EnumMetadataItem<Frequency11Code>, IFrequency11CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Frequency11CodeDropdownRow(Frequency11Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
