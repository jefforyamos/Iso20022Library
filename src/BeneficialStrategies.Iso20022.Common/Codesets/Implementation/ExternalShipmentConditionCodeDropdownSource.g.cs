﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalShipmentConditionCode.  ISO2002 ID# _AFUk0e8hEemHC5W45DWzKA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a shipment conditions code, as published in the external ISO 20022 external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalShipmentConditionCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AFUk0e8hEemHC5W45DWzKA")]
public partial class ExternalShipmentConditionCodeDropdownSource : EnumMetadataManager<ExternalShipmentConditionCode,IExternalShipmentConditionCodeDropdownRow,ExternalShipmentConditionCodeDropdownRow>
{
    public ExternalShipmentConditionCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalShipmentConditionCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
