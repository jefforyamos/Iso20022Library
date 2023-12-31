﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ModelType1Code.  ISO2002 ID# _mRl-ILC2EeaSl6vJk5Bd8w.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Categorisation of margin models used by central counterparties.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IModelType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_mRl-ILC2EeaSl6vJk5Bd8w")]
public partial class ModelType1CodeDropdownSource : EnumMetadataManager<ModelType1Code,IModelType1CodeDropdownRow,ModelType1CodeDropdownRow>
{
    public ModelType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ModelType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
