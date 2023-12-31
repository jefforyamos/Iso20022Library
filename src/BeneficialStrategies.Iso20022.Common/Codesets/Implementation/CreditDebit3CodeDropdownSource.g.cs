﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CreditDebit3Code.  ISO2002 ID# _s9EFxjzcEeWg1_uD_bF5Og.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies if an operation is an increase or a decrease.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICreditDebit3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_s9EFxjzcEeWg1_uD_bF5Og")]
public partial class CreditDebit3CodeDropdownSource : EnumMetadataManager<CreditDebit3Code,ICreditDebit3CodeDropdownRow,CreditDebit3CodeDropdownRow>
{
    public CreditDebit3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CreditDebit3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
