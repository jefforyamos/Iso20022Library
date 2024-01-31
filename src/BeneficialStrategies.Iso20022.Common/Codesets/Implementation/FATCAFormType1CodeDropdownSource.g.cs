﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FATCAFormType1Code.  ISO2002 ID# _kZxV0AjMEeS5F6qHcKOrew.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFATCAFormType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_kZxV0AjMEeS5F6qHcKOrew")]
public partial class FATCAFormType1CodeDropdownSource : EnumMetadataManager<FATCAFormType1Code,IFATCAFormType1CodeDropdownRow,FATCAFormType1CodeDropdownRow>
{
    public FATCAFormType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FATCAFormType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
