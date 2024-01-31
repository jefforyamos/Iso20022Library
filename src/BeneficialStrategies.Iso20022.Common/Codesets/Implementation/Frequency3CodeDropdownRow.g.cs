﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Frequency3Code.  ISO2002 ID# _Yajvh9p-Ed-ak6NoX_4Aeg_560112330.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Frequency3CodeDropdownSource"/>.
/// Implements <seealso cref="IFrequency3CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yajvh9p-Ed-ak6NoX_4Aeg_560112330")]
public partial class Frequency3CodeDropdownRow : EnumMetadataItem<Frequency3Code>, IFrequency3CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Frequency3CodeDropdownRow(Frequency3Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
