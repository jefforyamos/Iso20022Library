﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CarRentalActivity1Code.  ISO2002 ID# _nyCBAFyrEeeve7Je9cXtkQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of car rental activity.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICarRentalActivity1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nyCBAFyrEeeve7Je9cXtkQ")]
public partial class CarRentalActivity1CodeDropdownSource : EnumMetadataManager<CarRentalActivity1Code,ICarRentalActivity1CodeDropdownRow,CarRentalActivity1CodeDropdownRow>
{
    public CarRentalActivity1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CarRentalActivity1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
