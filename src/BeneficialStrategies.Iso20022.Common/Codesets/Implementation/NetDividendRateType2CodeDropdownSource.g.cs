﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NetDividendRateType2Code.  ISO2002 ID# _0OkFsRFZEeKp2ZN13DI_pA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of net dividend rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INetDividendRateType2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_0OkFsRFZEeKp2ZN13DI_pA")]
public partial class NetDividendRateType2CodeDropdownSource : EnumMetadataManager<NetDividendRateType2Code,INetDividendRateType2CodeDropdownRow,NetDividendRateType2CodeDropdownRow>
{
    public NetDividendRateType2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NetDividendRateType2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
