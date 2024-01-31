﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassSubProductType10Code.  ISO2002 ID# _BJaa8AnzEeWnS-yHF1QhNQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Emission.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassSubProductType10CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_BJaa8AnzEeWnS-yHF1QhNQ")]
public partial class AssetClassSubProductType10CodeDropdownSource : EnumMetadataManager<AssetClassSubProductType10Code,IAssetClassSubProductType10CodeDropdownRow,AssetClassSubProductType10CodeDropdownRow>
{
    public AssetClassSubProductType10CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassSubProductType10CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
