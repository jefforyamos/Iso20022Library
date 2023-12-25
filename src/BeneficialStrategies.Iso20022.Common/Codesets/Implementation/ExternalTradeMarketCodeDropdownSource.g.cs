﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExternalTradeMarketCode.  ISO2002 ID# _NzE0NzM1-AOSNFX-5096928.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external trade market code in the format of character string with a maximum length of 4 characters.
/// External code sets can be downloaded from www.iso20022.org.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExternalTradeMarketCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NzE0NzM1-AOSNFX-5096928")]
public partial class ExternalTradeMarketCodeDropdownSource : EnumMetadataManager<ExternalTradeMarketCode,IExternalTradeMarketCodeDropdownRow,ExternalTradeMarketCodeDropdownRow>
{
    public ExternalTradeMarketCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExternalTradeMarketCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
