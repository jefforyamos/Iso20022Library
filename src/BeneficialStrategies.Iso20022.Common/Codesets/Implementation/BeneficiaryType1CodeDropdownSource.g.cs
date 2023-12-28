﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BeneficiaryType1Code.  ISO2002 ID# _NtVGAFNhEeijdq8ilaxyOA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of beneficiary.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBeneficiaryType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NtVGAFNhEeijdq8ilaxyOA")]
public partial class BeneficiaryType1CodeDropdownSource : EnumMetadataManager<BeneficiaryType1Code,IBeneficiaryType1CodeDropdownRow,BeneficiaryType1CodeDropdownRow>
{
    public BeneficiaryType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BeneficiaryType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
