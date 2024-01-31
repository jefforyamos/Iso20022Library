﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for UnaffirmedReasonCode.  ISO2002 ID# __qxMVNojEeC60axPepSq7g_1753446814.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unaffirmed.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IUnaffirmedReasonCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__qxMVNojEeC60axPepSq7g_1753446814")]
public partial class UnaffirmedReasonCodeDropdownSource : EnumMetadataManager<UnaffirmedReasonCode,IUnaffirmedReasonCodeDropdownRow,UnaffirmedReasonCodeDropdownRow>
{
    public UnaffirmedReasonCodeDropdownSource()
        : base( (enumValue, memberInfo) => new UnaffirmedReasonCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
