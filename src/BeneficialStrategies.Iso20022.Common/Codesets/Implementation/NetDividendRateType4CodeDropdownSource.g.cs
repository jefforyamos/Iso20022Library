﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NetDividendRateType4Code.  ISO2002 ID# _nhweG5b7Eee8S7xwGG7Veg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of net dividend rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INetDividendRateType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_nhweG5b7Eee8S7xwGG7Veg")]
public partial class NetDividendRateType4CodeDropdownSource : EnumMetadataManager<NetDividendRateType4Code,INetDividendRateType4CodeDropdownRow,NetDividendRateType4CodeDropdownRow>
{
    public NetDividendRateType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NetDividendRateType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
