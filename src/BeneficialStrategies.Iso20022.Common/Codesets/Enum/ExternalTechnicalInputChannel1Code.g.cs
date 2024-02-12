﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalTechnicalInputChannel1Code.  ISO2002 ID# _amolh9p-Ed-ak6NoX_4Aeg_-614400071.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the technical input channel, as published in an external technical input channel code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amolh9p-Ed-ak6NoX_4Aeg_-614400071")]
[Description(@"Specifies the technical input channel, as published in an external technical input channel code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalTechnicalInputChannelCode))]
public enum ExternalTechnicalInputChannel1Code
{
    /// <summary>
    /// Technical Input Channel is fax or facsimile
    /// Encoded/decoded by serializers as "FAXI".
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_uG8YgvRYEeuLhpyIdtJzwg")]
    [Description(@"Technical Input Channel is fax or facsimile")]
    Fax = ExternalTechnicalInputChannelCode.Fax, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Technical Input Channel is paper
    /// Encoded/decoded by serializers as "PAPR".
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_uG8YhfRYEeuLhpyIdtJzwg")]
    [Description(@"Technical Input Channel is paper")]
    Paper = ExternalTechnicalInputChannelCode.Paper, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Technical Input Channel is tape
    /// Encoded/decoded by serializers as "TAPE".
    /// </summary>
    [EnumMember(Value = "TAPE")]
    [IsoId("_uG8YiPRYEeuLhpyIdtJzwg")]
    [Description(@"Technical Input Channel is tape")]
    Tape = ExternalTechnicalInputChannelCode.Tape, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Technical Input Channel is internet
    /// Encoded/decoded by serializers as "WEBI".
    /// </summary>
    [EnumMember(Value = "WEBI")]
    [IsoId("_uG8Yi_RYEeuLhpyIdtJzwg")]
    [Description(@"Technical Input Channel is internet")]
    Internet = ExternalTechnicalInputChannelCode.Internet, // same ordinal as derivation source for type conversions
    
}
