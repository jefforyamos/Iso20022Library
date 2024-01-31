﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for NetDividendRateType5Code.  ISO2002 ID# _V46GLZb9Eee8S7xwGG7Veg.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of net dividend rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="INetDividendRateType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_V46GLZb9Eee8S7xwGG7Veg")]
public partial class NetDividendRateType5CodeDropdownSource : EnumMetadataManager<NetDividendRateType5Code,INetDividendRateType5CodeDropdownRow,NetDividendRateType5CodeDropdownRow>
{
    public NetDividendRateType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new NetDividendRateType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
