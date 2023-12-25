﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RepurchaseTypeV2Code.  ISO2002 ID# _oOW02Y-QEeaVK-2bgpxeYw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Relates to a principal adjustment.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RepurchaseTypeV2CodeDropdownSource"/>.
/// Implements <seealso cref="IRepurchaseTypeV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_oOW02Y-QEeaVK-2bgpxeYw")]
public partial class RepurchaseTypeV2CodeDropdownRow : EnumMetadataItem<RepurchaseTypeV2Code>, IRepurchaseTypeV2CodeDropdownRow
{
    /// <summary>
    /// Relates to a principal adjustment.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RepurchaseTypeV2CodeDropdownRow(RepurchaseTypeV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
