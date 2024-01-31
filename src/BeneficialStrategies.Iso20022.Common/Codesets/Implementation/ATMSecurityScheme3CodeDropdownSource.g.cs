﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMSecurityScheme3Code.  ISO2002 ID# _Ps-QMV2VEeekzJIz1JxYSQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Key exchange security scheme in activation on the ATM for the host manager.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMSecurityScheme3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ps-QMV2VEeekzJIz1JxYSQ")]
public partial class ATMSecurityScheme3CodeDropdownSource : EnumMetadataManager<ATMSecurityScheme3Code,IATMSecurityScheme3CodeDropdownRow,ATMSecurityScheme3CodeDropdownRow>
{
    public ATMSecurityScheme3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMSecurityScheme3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
