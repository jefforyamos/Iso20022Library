﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TechnicalValidationStatus1Code.  ISO2002 ID# _Yll60dp-Ed-ak6NoX_4Aeg_1971021769.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the result of the technical validation carried out by the receiver (forwarding or first agent).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITechnicalValidationStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Yll60dp-Ed-ak6NoX_4Aeg_1971021769")]
public partial class TechnicalValidationStatus1CodeDropdownSource : EnumMetadataManager<TechnicalValidationStatus1Code,ITechnicalValidationStatus1CodeDropdownRow,TechnicalValidationStatus1CodeDropdownRow>
{
    public TechnicalValidationStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TechnicalValidationStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
