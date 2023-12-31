﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for CollateralManagementCancellationReason1Code.  ISO2002 ID# _Ybm4aNp-Ed-ak6NoX_4Aeg_177526096.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the instruction/request has been cancelled.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ICollateralManagementCancellationReason1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Ybm4aNp-Ed-ak6NoX_4Aeg_177526096")]
public partial class CollateralManagementCancellationReason1CodeDropdownSource : EnumMetadataManager<CollateralManagementCancellationReason1Code,ICollateralManagementCancellationReason1CodeDropdownRow,CollateralManagementCancellationReason1CodeDropdownRow>
{
    public CollateralManagementCancellationReason1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new CollateralManagementCancellationReason1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
