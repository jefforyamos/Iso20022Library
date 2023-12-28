﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExchangePolicy2Code.  ISO2002 ID# _mEFs8Q0vEeqUVL7sB4m7NA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Exchange policy between parties.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExchangePolicy2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mEFs8Q0vEeqUVL7sB4m7NA")]
public partial class ExchangePolicy2CodeDropdownSource : EnumMetadataManager<ExchangePolicy2Code,IExchangePolicy2CodeDropdownRow,ExchangePolicy2CodeDropdownRow>
{
    public ExchangePolicy2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExchangePolicy2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
