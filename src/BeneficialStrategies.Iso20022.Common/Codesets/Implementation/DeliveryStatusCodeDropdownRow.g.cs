﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeliveryStatusCode.  ISO2002 ID# _MKgsMQ2pEeWH49U6bkyMaA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides an explicit indication whether the delivery attempt resulted in success or failure.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeliveryStatusCodeDropdownSource"/>.
/// Implements <seealso cref="IDeliveryStatusCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_MKgsMQ2pEeWH49U6bkyMaA")]
public partial class DeliveryStatusCodeDropdownRow : EnumMetadataItem<DeliveryStatusCode>, IDeliveryStatusCodeDropdownRow
{
    /// <summary>
    /// Provides an explicit indication whether the delivery attempt resulted in success or failure.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeliveryStatusCodeDropdownRow(DeliveryStatusCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
