﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeliveryStatus1Code.  ISO2002 ID# _8aALYA2pEeWH49U6bkyMaA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Provides an explicit indication whether the delivery attempt resulted in success or failure.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeliveryStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="IDeliveryStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8aALYA2pEeWH49U6bkyMaA")]
public partial class DeliveryStatus1CodeDropdownRow : EnumMetadataItem<DeliveryStatus1Code>, IDeliveryStatus1CodeDropdownRow
{
    /// <summary>
    /// Provides an explicit indication whether the delivery attempt resulted in success or failure.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeliveryStatus1CodeDropdownRow(DeliveryStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
