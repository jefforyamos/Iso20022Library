﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ExtendedOptionFeatureCode.  ISO2002 ID# _1orVtDL3EeKU9IrkkToqcw_-113809036.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ExtendedOptionFeatureCodeDropdownSource"/>.
/// Implements <seealso cref="IExtendedOptionFeatureCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_1orVtDL3EeKU9IrkkToqcw_-113809036")]
public partial class ExtendedOptionFeatureCodeDropdownRow : EnumMetadataItem<ExtendedOptionFeatureCode>, IExtendedOptionFeatureCodeDropdownRow
{
    /// <summary>
    /// Specifies DTCC (The Depository Trust and Clearing Corporation) specific options.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ExtendedOptionFeatureCodeDropdownRow(ExtendedOptionFeatureCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}