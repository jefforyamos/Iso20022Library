﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChequeDelivery1Code.  ISO2002 ID# _a-Usx9p-Ed-ak6NoX_4Aeg_681596924.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method to be used in delivering a cheque to a party.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChequeDelivery1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a-Usx9p-Ed-ak6NoX_4Aeg_681596924")]
public partial class ChequeDelivery1CodeDropdownSource : EnumMetadataManager<ChequeDelivery1Code,IChequeDelivery1CodeDropdownRow,ChequeDelivery1CodeDropdownRow>
{
    public ChequeDelivery1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChequeDelivery1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
