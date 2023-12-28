﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DeliveryTypeV2Code.  ISO2002 ID# _ltUEcNomEeCWg-hsBVGrDA_-989246574.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the delivery or custody arrangement for the underlying securities.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDeliveryTypeV2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ltUEcNomEeCWg-hsBVGrDA_-989246574")]
public partial class DeliveryTypeV2CodeDropdownSource : EnumMetadataManager<DeliveryTypeV2Code,IDeliveryTypeV2CodeDropdownRow,DeliveryTypeV2CodeDropdownRow>
{
    public DeliveryTypeV2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DeliveryTypeV2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}