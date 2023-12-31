﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMServiceTypeCode.  ISO2002 ID# _bItp4IogEeSirOZJBRz_nA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Describes the type of transaction available for a customer on an ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMServiceTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bItp4IogEeSirOZJBRz_nA")]
public partial class ATMServiceTypeCodeDropdownSource : EnumMetadataManager<ATMServiceTypeCode,IATMServiceTypeCodeDropdownRow,ATMServiceTypeCodeDropdownRow>
{
    public ATMServiceTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMServiceTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
