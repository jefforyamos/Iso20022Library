﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for EUDividendStatusCode.  ISO2002 ID# _aiKVONp-Ed-ak6NoX_4Aeg_235937580.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the dividend is in the scope of the European directive on taxation of savings income in the form of interest payments.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IEUDividendStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aiKVONp-Ed-ak6NoX_4Aeg_235937580")]
public partial class EUDividendStatusCodeDropdownSource : EnumMetadataManager<EUDividendStatusCode,IEUDividendStatusCodeDropdownRow,EUDividendStatusCodeDropdownRow>
{
    public EUDividendStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new EUDividendStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
