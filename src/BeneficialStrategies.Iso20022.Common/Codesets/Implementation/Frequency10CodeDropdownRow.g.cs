﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for Frequency10Code.  ISO2002 ID# _iotXoGoEEearR-CA7eRZXQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the regularity of an event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="Frequency10CodeDropdownSource"/>.
/// Implements <seealso cref="IFrequency10CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iotXoGoEEearR-CA7eRZXQ")]
public partial class Frequency10CodeDropdownRow : EnumMetadataItem<Frequency10Code>, IFrequency10CodeDropdownRow
{
    /// <summary>
    /// Specifies the regularity of an event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public Frequency10CodeDropdownRow(Frequency10Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}