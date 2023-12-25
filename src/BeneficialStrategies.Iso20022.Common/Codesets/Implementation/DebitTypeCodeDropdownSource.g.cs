﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DebitTypeCode.  ISO2002 ID# _JtKwwMmKEeWAGphE2LvqeA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of debit to be applied to the payment.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDebitTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_JtKwwMmKEeWAGphE2LvqeA")]
public partial class DebitTypeCodeDropdownSource : EnumMetadataManager<DebitTypeCode,IDebitTypeCodeDropdownRow,DebitTypeCodeDropdownRow>
{
    public DebitTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DebitTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
