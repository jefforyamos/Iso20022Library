﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OutputFormat1Code.  ISO2002 ID# _8r6YYHr5EeSZrs_hiwNOWA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Message format.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OutputFormat1CodeDropdownSource"/>.
/// Implements <seealso cref="IOutputFormat1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8r6YYHr5EeSZrs_hiwNOWA")]
public partial class OutputFormat1CodeDropdownRow : EnumMetadataItem<OutputFormat1Code>, IOutputFormat1CodeDropdownRow
{
    /// <summary>
    /// Message format.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OutputFormat1CodeDropdownRow(OutputFormat1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
