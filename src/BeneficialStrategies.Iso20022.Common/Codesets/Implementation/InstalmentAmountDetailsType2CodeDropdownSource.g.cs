﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for InstalmentAmountDetailsType2Code.  ISO2002 ID# _8d5Y8JJNEeuuktRxxQZoNQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Instalment amount detail type.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstalmentAmountDetailsType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_8d5Y8JJNEeuuktRxxQZoNQ")]
public partial class InstalmentAmountDetailsType2CodeDropdownSource : EnumMetadataManager<InstalmentAmountDetailsType2Code,IInstalmentAmountDetailsType2CodeDropdownRow,InstalmentAmountDetailsType2CodeDropdownRow>
{
    public InstalmentAmountDetailsType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new InstalmentAmountDetailsType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
