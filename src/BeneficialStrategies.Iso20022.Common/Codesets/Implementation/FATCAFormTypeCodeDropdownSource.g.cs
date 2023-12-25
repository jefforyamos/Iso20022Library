﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FATCAFormTypeCode.  ISO2002 ID# _qRYe4QjLEeS5F6qHcKOrew.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFATCAFormTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_qRYe4QjLEeS5F6qHcKOrew")]
public partial class FATCAFormTypeCodeDropdownSource : EnumMetadataManager<FATCAFormTypeCode,IFATCAFormTypeCodeDropdownRow,FATCAFormTypeCodeDropdownRow>
{
    public FATCAFormTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FATCAFormTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
