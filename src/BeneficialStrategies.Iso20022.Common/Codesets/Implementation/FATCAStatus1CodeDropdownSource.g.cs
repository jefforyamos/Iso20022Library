﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FATCAStatus1Code.  ISO2002 ID# _VA8RAAjUEeS5F6qHcKOrew.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the Foreign Account Tax Compliance Act (FATCA) status.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFATCAStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VA8RAAjUEeS5F6qHcKOrew")]
public partial class FATCAStatus1CodeDropdownSource : EnumMetadataManager<FATCAStatus1Code,IFATCAStatus1CodeDropdownRow,FATCAStatus1CodeDropdownRow>
{
    public FATCAStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FATCAStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}