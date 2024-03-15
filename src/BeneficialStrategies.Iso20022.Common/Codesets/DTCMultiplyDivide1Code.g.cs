﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCMultiplyDivide1Code.  ISO2002 ID# _1p3ogjL3EeKU9IrkkToqcw_560476019.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTC (The Depository Trust Company) entitlement calculation logic.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1p3ogjL3EeKU9IrkkToqcw_560476019")]
[Description(@"Specifies DTC (The Depository Trust Company) entitlement calculation logic.")]
[DerivedFrom(typeof(DTCMultiplyDivideCode))]
public enum DTCMultiplyDivide1Code
{
    /// <summary>
    /// Positions multiplied by rate.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_1p3ogzL3EeKU9IrkkToqcw_1860873575")]
    [Description(@"Positions multiplied by rate.")]
    Multiply = DTCMultiplyDivideCode.Multiply, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Positions divided by rate.
    /// Encoded/decoded by serializers as &quot;DVDE&quot;.
    /// </summary>
    [EnumMember(Value = "DVDE")]
    [IsoId("_1p3ohDL3EeKU9IrkkToqcw_-935145883")]
    [Description(@"Positions divided by rate.")]
    Divide = DTCMultiplyDivideCode.Divide, // same ordinal as derivation source for type conversions
    
}
