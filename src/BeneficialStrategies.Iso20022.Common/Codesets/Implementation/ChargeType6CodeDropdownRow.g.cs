﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for ChargeType6Code.  ISO2002 ID# _VlqmANp-Ed-ak6NoX_4Aeg_1005907551.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of service for which a charge is asked or paid.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="ChargeType6CodeDropdownSource"/>.
/// Implements <seealso cref="IChargeType6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VlqmANp-Ed-ak6NoX_4Aeg_1005907551")]
public partial class ChargeType6CodeDropdownRow : EnumMetadataItem<ChargeType6Code>, IChargeType6CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of service for which a charge is asked or paid.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public ChargeType6CodeDropdownRow(ChargeType6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
