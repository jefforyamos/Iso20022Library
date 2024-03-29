﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReconciliationFunction1Code.  ISO2002 ID# _rWAiEC7OEemIy6A-26wnAg.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the message is a request for totals or to convey totals. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rWAiEC7OEemIy6A-26wnAg")]
[Description(@"Indicates whether the message is a request for totals or to convey totals. ")]
[DerivedFrom(typeof(ReconciliationFunctionCode))]
public enum ReconciliationFunction1Code
{
    /// <summary>
    /// Inquiry for reconciliation totals
    /// Encoded/decoded by serializers as &quot;INQR&quot;.
    /// </summary>
    [EnumMember(Value = "INQR")]
    [IsoId("_sqvgYS7OEemIy6A-26wnAg")]
    [Description(@"Inquiry for reconciliation totals")]
    Inquire = ReconciliationFunctionCode.Inquire, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initiation of a cutover. 
    /// Encoded/decoded by serializers as &quot;INCU&quot;.
    /// </summary>
    [EnumMember(Value = "INCU")]
    [IsoId("_tIhokS7OEemIy6A-26wnAg")]
    [Description(@"Initiation of a cutover. ")]
    InitiateCutover = ReconciliationFunctionCode.InitiateCutover, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Convey reconciliation totals
    /// Encoded/decoded by serializers as &quot;CNVY&quot;.
    /// </summary>
    [EnumMember(Value = "CNVY")]
    [IsoId("_tOg70S7OEemIy6A-26wnAg")]
    [Description(@"Convey reconciliation totals")]
    Convey = ReconciliationFunctionCode.Convey, // same ordinal as derivation source for type conversions
    
}
