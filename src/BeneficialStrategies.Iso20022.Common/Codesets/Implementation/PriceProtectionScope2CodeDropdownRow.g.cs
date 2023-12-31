﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PriceProtectionScope2Code.  ISO2002 ID# _aI1PMdp-Ed-ak6NoX_4Aeg_-86829705.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of price protection the customer requires on their order. Defines the scope of the "related to" price of the peg or the scope of "related to" price of the discretion (for example, local, global etc).
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PriceProtectionScope2CodeDropdownSource"/>.
/// Implements <seealso cref="IPriceProtectionScope2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aI1PMdp-Ed-ak6NoX_4Aeg_-86829705")]
public partial class PriceProtectionScope2CodeDropdownRow : EnumMetadataItem<PriceProtectionScope2Code>, IPriceProtectionScope2CodeDropdownRow
{
    /// <summary>
    /// Defines the type of price protection the customer requires on their order. Defines the scope of the "related to" price of the peg or the scope of "related to" price of the discretion (for example, local, global etc).
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PriceProtectionScope2CodeDropdownRow(PriceProtectionScope2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
