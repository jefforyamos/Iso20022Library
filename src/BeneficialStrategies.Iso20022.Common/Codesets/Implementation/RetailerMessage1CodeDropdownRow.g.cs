﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RetailerMessage1Code.  ISO2002 ID# _nGL_MNj5EeiojJsa6FYyew.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to the message.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RetailerMessage1CodeDropdownSource"/>.
/// Implements <seealso cref="IRetailerMessage1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nGL_MNj5EeiojJsa6FYyew")]
public partial class RetailerMessage1CodeDropdownRow : EnumMetadataItem<RetailerMessage1Code>, IRetailerMessage1CodeDropdownRow
{
    /// <summary>
    /// Identifies the type of process related to the message.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RetailerMessage1CodeDropdownRow(RetailerMessage1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
