﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AssetClassDetailedSubProductType30Code.  ISO2002 ID# _TcElYbv3EeiLRYqS-r-R-A.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Further sub product code list for commodity derivative Grain.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAssetClassDetailedSubProductType30CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_TcElYbv3EeiLRYqS-r-R-A")]
public partial class AssetClassDetailedSubProductType30CodeDropdownSource : EnumMetadataManager<AssetClassDetailedSubProductType30Code,IAssetClassDetailedSubProductType30CodeDropdownRow,AssetClassDetailedSubProductType30CodeDropdownRow>
{
    public AssetClassDetailedSubProductType30CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AssetClassDetailedSubProductType30CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
