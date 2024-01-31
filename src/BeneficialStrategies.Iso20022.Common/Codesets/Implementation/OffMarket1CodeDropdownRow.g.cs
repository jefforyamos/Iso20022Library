﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for OffMarket1Code.  ISO2002 ID# _aOfyUdp-Ed-ak6NoX_4Aeg_1810038493.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the trade was executed off-market.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="OffMarket1CodeDropdownSource"/>.
/// Implements <seealso cref="IOffMarket1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aOfyUdp-Ed-ak6NoX_4Aeg_1810038493")]
public partial class OffMarket1CodeDropdownRow : EnumMetadataItem<OffMarket1Code>, IOffMarket1CodeDropdownRow
{
    /// <summary>
    /// Indicates that the trade was executed off-market.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public OffMarket1CodeDropdownRow(OffMarket1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
