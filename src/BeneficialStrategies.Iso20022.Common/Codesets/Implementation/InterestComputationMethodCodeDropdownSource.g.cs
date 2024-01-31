﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InterestComputationMethodCode.  ISO2002 ID# _aZrHltp-Ed-ak6NoX_4Aeg_1988747412.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method used to compute accruing interest of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInterestComputationMethodCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aZrHltp-Ed-ak6NoX_4Aeg_1988747412")]
public partial class InterestComputationMethodCodeDropdownSource : EnumMetadataManager<InterestComputationMethodCode,IInterestComputationMethodCodeDropdownRow,InterestComputationMethodCodeDropdownRow>
{
    public InterestComputationMethodCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InterestComputationMethodCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
