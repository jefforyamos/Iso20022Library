﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMDevice1Code.  ISO2002 ID# _TVx90IqIEeSRT5rEzcAHEw.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// ATM device to output message.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMDevice1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TVx90IqIEeSRT5rEzcAHEw")]
public partial class ATMDevice1CodeDropdownSource : EnumMetadataManager<ATMDevice1Code,IATMDevice1CodeDropdownRow,ATMDevice1CodeDropdownRow>
{
    public ATMDevice1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMDevice1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
