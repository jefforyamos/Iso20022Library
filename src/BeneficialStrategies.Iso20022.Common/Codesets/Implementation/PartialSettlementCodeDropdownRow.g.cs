﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PartialSettlementCode.  ISO2002 ID# _ZxlM09p-Ed-ak6NoX_4Aeg_1795335735.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Information about partial settlement.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PartialSettlementCodeDropdownSource"/>.
/// Implements <seealso cref="IPartialSettlementCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZxlM09p-Ed-ak6NoX_4Aeg_1795335735")]
public partial class PartialSettlementCodeDropdownRow : EnumMetadataItem<PartialSettlementCode>, IPartialSettlementCodeDropdownRow
{
    /// <summary>
    /// Information about partial settlement.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PartialSettlementCodeDropdownRow(PartialSettlementCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
