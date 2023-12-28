﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeliveryReturn1Code.  ISO2002 ID# _azTIg9p-Ed-ak6NoX_4Aeg_-1245884336.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of delivery return.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeliveryReturn1CodeDropdownSource"/>.
/// Implements <seealso cref="IDeliveryReturn1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_azTIg9p-Ed-ak6NoX_4Aeg_-1245884336")]
public partial class DeliveryReturn1CodeDropdownRow : EnumMetadataItem<DeliveryReturn1Code>, IDeliveryReturn1CodeDropdownRow
{
    /// <summary>
    /// Specifies the type of delivery return.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeliveryReturn1CodeDropdownRow(DeliveryReturn1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
