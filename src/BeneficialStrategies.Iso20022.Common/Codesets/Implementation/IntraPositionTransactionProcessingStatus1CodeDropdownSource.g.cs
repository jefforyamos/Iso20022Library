﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for IntraPositionTransactionProcessingStatus1Code.  ISO2002 ID# _aa3aYtp-Ed-ak6NoX_4Aeg_-836406022.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IIntraPositionTransactionProcessingStatus1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aa3aYtp-Ed-ak6NoX_4Aeg_-836406022")]
public partial class IntraPositionTransactionProcessingStatus1CodeDropdownSource : EnumMetadataManager<IntraPositionTransactionProcessingStatus1Code,IIntraPositionTransactionProcessingStatus1CodeDropdownRow,IntraPositionTransactionProcessingStatus1CodeDropdownRow>
{
    public IntraPositionTransactionProcessingStatus1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new IntraPositionTransactionProcessingStatus1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
