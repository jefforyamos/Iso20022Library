﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FractionDispositionType1Code.  ISO2002 ID# _arP_xNp-Ed-ak6NoX_4Aeg_-1827765528.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFractionDispositionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_arP_xNp-Ed-ak6NoX_4Aeg_-1827765528")]
public partial class FractionDispositionType1CodeDropdownSource : EnumMetadataManager<FractionDispositionType1Code,IFractionDispositionType1CodeDropdownRow,FractionDispositionType1CodeDropdownRow>
{
    public FractionDispositionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new FractionDispositionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
