﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMOperationCode.  ISO2002 ID# _VNYCoOhAEeSbwP3G-MV9YA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of logical or physical operation on an ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMOperationCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VNYCoOhAEeSbwP3G-MV9YA")]
public partial class ATMOperationCodeDropdownSource : EnumMetadataManager<ATMOperationCode,IATMOperationCodeDropdownRow,ATMOperationCodeDropdownRow>
{
    public ATMOperationCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMOperationCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
