﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for DeliveryPlaceV2Code.  ISO2002 ID# _iSfctg1eEeu_4e16J8D_UA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the place of delivery.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="DeliveryPlaceV2CodeDropdownSource"/>.
/// Implements <seealso cref="IDeliveryPlaceV2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iSfctg1eEeu_4e16J8D_UA")]
public partial class DeliveryPlaceV2CodeDropdownRow : EnumMetadataItem<DeliveryPlaceV2Code>, IDeliveryPlaceV2CodeDropdownRow
{
    /// <summary>
    /// Specifies the place of delivery.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public DeliveryPlaceV2CodeDropdownRow(DeliveryPlaceV2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
