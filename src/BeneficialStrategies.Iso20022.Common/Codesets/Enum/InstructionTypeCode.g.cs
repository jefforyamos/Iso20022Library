﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InstructionTypeCode.  ISO2002 ID# _aYxvstp-Ed-ak6NoX_4Aeg_-1770372143.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the action that the TSU must take on a baseline or a data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aYxvstp-Ed-ak6NoX_4Aeg_-1770372143")]
[Description(@"Specifies the action that the TSU must take on a baseline or a data set.")]
[Derivations(typeof(InstructionType3Code),typeof(InstructionType1Code))]
public enum InstructionTypeCode
{
    /// <summary>
    /// Instruction to lodge a baseline.
    /// Encoded/decoded by serializers as "LODG".
    /// </summary>
    [EnumMember(Value = "LODG")]
    [IsoId("_aYxvs9p-Ed-ak6NoX_4Aeg_-145895778")]
    [Description(@"Instruction to lodge a baseline.")]
    Lodge,
    
    /// <summary>
    /// Instruction to push full baseline information to the correspondent.
    /// Encoded/decoded by serializers as "FPTR".
    /// </summary>
    [EnumMember(Value = "FPTR")]
    [IsoId("_aYxvtNp-Ed-ak6NoX_4Aeg_-117267164")]
    [Description(@"Instruction to push full baseline information to the correspondent.")]
    FullPushThrough,
    
    /// <summary>
    /// Indication that a twin baseline is submitted.
    /// Encoded/decoded by serializers as "TWSB".
    /// </summary>
    [EnumMember(Value = "TWSB")]
    [IsoId("_aYxvtdp-Ed-ak6NoX_4Aeg_-1769402272")]
    [Description(@"Indication that a twin baseline is submitted.")]
    TwinSubmit,
    
    /// <summary>
    /// Indication that a twin baseline is resubmitted.
    /// Encoded/decoded by serializers as "TWRS".
    /// </summary>
    [EnumMember(Value = "TWRS")]
    [IsoId("_aYxvttp-Ed-ak6NoX_4Aeg_-1724148376")]
    [Description(@"Indication that a twin baseline is resubmitted.")]
    TwinResubmit,
    
    /// <summary>
    /// Instruction to match a data set.
    /// Encoded/decoded by serializers as "MTCH".
    /// </summary>
    [EnumMember(Value = "MTCH")]
    [IsoId("_aYxvt9p-Ed-ak6NoX_4Aeg_-1722557554")]
    [Description(@"Instruction to match a data set.")]
    Match,
    
    /// <summary>
    /// Instruction to pre-match a data set.
    /// Encoded/decoded by serializers as "PMTC".
    /// </summary>
    [EnumMember(Value = "PMTC")]
    [IsoId("_aYxvuNp-Ed-ak6NoX_4Aeg_-1691157375")]
    [Description(@"Instruction to pre-match a data set.")]
    PreMatch,
    
}
