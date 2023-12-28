﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstalmentAmountDetailsTypeCode.  ISO2002 ID# _J00oB9uYEei2qvU6FBLZYA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the details of the grace period applicable to the instalment
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstalmentAmountDetailsTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_J00oB9uYEei2qvU6FBLZYA")]
public partial class InstalmentAmountDetailsTypeCodeDropdownSource : EnumMetadataManager<InstalmentAmountDetailsTypeCode,IInstalmentAmountDetailsTypeCodeDropdownRow,InstalmentAmountDetailsTypeCodeDropdownRow>
{
    public InstalmentAmountDetailsTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstalmentAmountDetailsTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}