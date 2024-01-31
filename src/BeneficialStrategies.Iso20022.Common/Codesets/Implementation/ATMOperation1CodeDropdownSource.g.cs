﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMOperation1Code.  ISO2002 ID# _2p6D0OhAEeSbwP3G-MV9YA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of logical or physical operation on an ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMOperation1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_2p6D0OhAEeSbwP3G-MV9YA")]
public partial class ATMOperation1CodeDropdownSource : EnumMetadataManager<ATMOperation1Code,IATMOperation1CodeDropdownRow,ATMOperation1CodeDropdownRow>
{
    public ATMOperation1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMOperation1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
