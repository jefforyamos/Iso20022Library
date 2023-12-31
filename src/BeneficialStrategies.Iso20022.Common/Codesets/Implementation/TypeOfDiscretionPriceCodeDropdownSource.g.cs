﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TypeOfDiscretionPriceCode.  ISO2002 ID# _YwduFtp-Ed-ak6NoX_4Aeg_337179698.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Contains the type of price to which the discretion offset is related to.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITypeOfDiscretionPriceCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YwduFtp-Ed-ak6NoX_4Aeg_337179698")]
public partial class TypeOfDiscretionPriceCodeDropdownSource : EnumMetadataManager<TypeOfDiscretionPriceCode,ITypeOfDiscretionPriceCodeDropdownRow,TypeOfDiscretionPriceCodeDropdownRow>
{
    public TypeOfDiscretionPriceCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TypeOfDiscretionPriceCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
