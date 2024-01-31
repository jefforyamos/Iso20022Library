﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ConsolidationType1Code.  ISO2002 ID# _3fs5YCDVEeWCLu74WLgP4w.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the consolidation type.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ConsolidationType1CodeDropdownSource"/>.
/// Implements <seealso cref="IConsolidationType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3fs5YCDVEeWCLu74WLgP4w")]
public partial class ConsolidationType1CodeDropdownRow : EnumMetadataItem<ConsolidationType1Code>, IConsolidationType1CodeDropdownRow
{
    /// <summary>
    /// Specifies the consolidation type.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ConsolidationType1CodeDropdownRow(ConsolidationType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
