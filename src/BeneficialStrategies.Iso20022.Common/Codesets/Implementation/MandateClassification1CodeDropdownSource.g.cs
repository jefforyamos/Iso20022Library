﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MandateClassification1Code.  ISO2002 ID# _dYdaoGVREeacpJ-gG9kyUQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of direct debit amount, such as fixed or variable.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMandateClassification1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dYdaoGVREeacpJ-gG9kyUQ")]
public partial class MandateClassification1CodeDropdownSource : EnumMetadataManager<MandateClassification1Code,IMandateClassification1CodeDropdownRow,MandateClassification1CodeDropdownRow>
{
    public MandateClassification1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MandateClassification1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
