﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Frequency1Code.  ISO2002 ID# _ar_mp9p-Ed-ak6NoX_4Aeg_1946817553.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Frequency1CodeDropdownSource"/>.
/// Implements <seealso cref="IFrequency1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ar_mp9p-Ed-ak6NoX_4Aeg_1946817553")]
public partial class Frequency1CodeDropdownRow : EnumMetadataItem<Frequency1Code>, IFrequency1CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Frequency1CodeDropdownRow(Frequency1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
