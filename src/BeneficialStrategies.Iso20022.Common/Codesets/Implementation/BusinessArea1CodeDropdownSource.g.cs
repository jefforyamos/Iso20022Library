﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BusinessArea1Code.  ISO2002 ID# _JfLxsE4OEey_VecAUE-C9Q.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the business context of the transaction
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBusinessArea1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JfLxsE4OEey_VecAUE-C9Q")]
public partial class BusinessArea1CodeDropdownSource : EnumMetadataManager<BusinessArea1Code,IBusinessArea1CodeDropdownRow,BusinessArea1CodeDropdownRow>
{
    public BusinessArea1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BusinessArea1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
