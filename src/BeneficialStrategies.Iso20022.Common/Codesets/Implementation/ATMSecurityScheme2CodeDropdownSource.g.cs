﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ATMSecurityScheme2Code.  ISO2002 ID# _pdrXsIr5EeSvuOJS0mmL0g.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Key exchange security schemes implemented in the hardware security module of the ATM.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IATMSecurityScheme2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_pdrXsIr5EeSvuOJS0mmL0g")]
public partial class ATMSecurityScheme2CodeDropdownSource : EnumMetadataManager<ATMSecurityScheme2Code,IATMSecurityScheme2CodeDropdownRow,ATMSecurityScheme2CodeDropdownRow>
{
    public ATMSecurityScheme2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ATMSecurityScheme2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
