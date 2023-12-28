﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Quantity1Code.  ISO2002 ID# _ZXWu9Np-Ed-ak6NoX_4Aeg_1332281009.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies quantity of a financial instrument.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IQuantity1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ZXWu9Np-Ed-ak6NoX_4Aeg_1332281009")]
public partial class Quantity1CodeDropdownSource : EnumMetadataManager<Quantity1Code,IQuantity1CodeDropdownRow,Quantity1CodeDropdownRow>
{
    public Quantity1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Quantity1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
