﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RepurchaseType9Code.  ISO2002 ID# _e06jwI-REeaVK-2bgpxeYw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RepurchaseType9CodeDropdownSource"/>.
/// Implements <seealso cref="IRepurchaseType9CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_e06jwI-REeaVK-2bgpxeYw")]
public partial class RepurchaseType9CodeDropdownRow : EnumMetadataItem<RepurchaseType9Code>, IRepurchaseType9CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of repurchase transaction.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RepurchaseType9CodeDropdownRow(RepurchaseType9Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
