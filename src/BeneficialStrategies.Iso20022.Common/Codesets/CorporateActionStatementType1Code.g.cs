﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionStatementType1Code.  ISO2002 ID# _bTMJgtp-Ed-ak6NoX_4Aeg_844748567.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates whether the statement contains missing instructions only or all instructions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bTMJgtp-Ed-ak6NoX_4Aeg_844748567")]
[Description(@"Indicates whether the statement contains missing instructions only or all instructions.")]
[DerivedFrom(typeof(CorporateActionStatementTypeCode))]
public enum CorporateActionStatementType1Code
{
    /// <summary>
    /// Statement contains missing instructions.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_bTMJg9p-Ed-ak6NoX_4Aeg_1348068920")]
    [Description(@"Statement contains missing instructions.")]
    Missing = CorporateActionStatementTypeCode.Missing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Statement contains all instructions.
    /// Encoded/decoded by serializers as &quot;ALLL&quot;.
    /// </summary>
    [EnumMember(Value = "ALLL")]
    [IsoId("_bTMJhNp-Ed-ak6NoX_4Aeg_1358228102")]
    [Description(@"Statement contains all instructions.")]
    All = CorporateActionStatementTypeCode.All, // same ordinal as derivation source for type conversions
    
}
