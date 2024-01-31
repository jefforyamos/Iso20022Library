﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChargeBearerCode.  ISO2002 ID# _a8F4Itp-Ed-ak6NoX_4Aeg_-746027402.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies which party(ies) will pay charges due for processing of the payment transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChargeBearerCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a8F4Itp-Ed-ak6NoX_4Aeg_-746027402")]
public partial class ChargeBearerCodeDropdownSource : EnumMetadataManager<ChargeBearerCode,IChargeBearerCodeDropdownRow,ChargeBearerCodeDropdownRow>
{
    public ChargeBearerCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChargeBearerCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
