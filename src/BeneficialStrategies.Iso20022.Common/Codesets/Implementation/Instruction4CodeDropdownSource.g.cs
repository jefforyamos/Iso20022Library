﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for Instruction4Code.  ISO2002 ID# _aW-_8tp-Ed-ak6NoX_4Aeg_-1362532082.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies further instructions concerning the processing of a payment instruction, provided by the sending clearing agent to the next agent(s).
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IInstruction4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_aW-_8tp-Ed-ak6NoX_4Aeg_-1362532082")]
public partial class Instruction4CodeDropdownSource : EnumMetadataManager<Instruction4Code,IInstruction4CodeDropdownRow,Instruction4CodeDropdownRow>
{
    public Instruction4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new Instruction4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
