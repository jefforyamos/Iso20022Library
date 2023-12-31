﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ChequeType2Code.  ISO2002 ID# _a-xYudp-Ed-ak6NoX_4Aeg_1427080756.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of cheque.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IChequeType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_a-xYudp-Ed-ak6NoX_4Aeg_1427080756")]
public partial class ChequeType2CodeDropdownSource : EnumMetadataManager<ChequeType2Code,IChequeType2CodeDropdownRow,ChequeType2CodeDropdownRow>
{
    public ChequeType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ChequeType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
