﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StatementSource1Code.  ISO2002 ID# _m5hTcvNBEeCuA5Tr22BnwA_770688257.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of the report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m5hTcvNBEeCuA5Tr22BnwA_770688257")]
[Description(@"Specifies the source of the report.")]
[DerivedFrom(typeof(StatementSourceCode))]
public enum StatementSource1Code
{
    /// <summary>
    /// Accounting.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_m5hTc_NBEeCuA5Tr22BnwA_770688282")]
    [Description(@"Accounting.")]
    Accounting = StatementSourceCode.Accounting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custody.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_m5hTdPNBEeCuA5Tr22BnwA_770688600")]
    [Description(@"Custody.")]
    Custody = StatementSourceCode.Custody, // same ordinal as derivation source for type conversions
    
}
