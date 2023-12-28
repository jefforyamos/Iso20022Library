﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for FinalStatusCode.  ISO2002 ID# _an04VNp-Ed-ak6NoX_4Aeg_-1727527994.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the final status of a transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IFinalStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_an04VNp-Ed-ak6NoX_4Aeg_-1727527994")]
public partial class FinalStatusCodeDropdownSource : EnumMetadataManager<FinalStatusCode,IFinalStatusCodeDropdownRow,FinalStatusCodeDropdownRow>
{
    public FinalStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new FinalStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
