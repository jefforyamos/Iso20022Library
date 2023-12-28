﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MoneyLaunderingCheckCode.  ISO2002 ID# _aMj4qNp-Ed-ak6NoX_4Aeg_-1506297478.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of money laundering identification procedures.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMoneyLaunderingCheckCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aMj4qNp-Ed-ak6NoX_4Aeg_-1506297478")]
public partial class MoneyLaunderingCheckCodeDropdownSource : EnumMetadataManager<MoneyLaunderingCheckCode,IMoneyLaunderingCheckCodeDropdownRow,MoneyLaunderingCheckCodeDropdownRow>
{
    public MoneyLaunderingCheckCodeDropdownSource()
        : base( (enumValue, memberInfo) => new MoneyLaunderingCheckCodeDropdownRow(enumValue, memberInfo))
    {
    }
}