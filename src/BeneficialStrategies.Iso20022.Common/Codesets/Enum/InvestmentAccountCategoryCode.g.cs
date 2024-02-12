﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InvestmentAccountCategoryCode.  ISO2002 ID# _yNcYIBRHEeOKWo1NF21OVw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investment account category.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yNcYIBRHEeOKWo1NF21OVw")]
[Description(@"Specifies the investment account category.")]
[Derivations(typeof(InvestmentAccountCategory1Code))]
public enum InvestmentAccountCategoryCode
{
    /// <summary>
    /// Account is a standard account managed by the investor. The investor issues instructions for the account to the financial institution.
    /// Encoded/decoded by serializers as "RETA".
    /// </summary>
    [EnumMember(Value = "RETA")]
    [IsoId("_32N-gBRHEeOKWo1NF21OVw")]
    [Description(@"Account is a standard account managed by the investor. The investor issues instructions for the account to the financial institution.")]
    RetailAccount,
    
    /// <summary>
    /// Account is fully managed by the financial institution, that is, an investor gives a 'mandate' to the financial institution to execute a mutually agreed investment strategy on its behalf.
    /// Encoded/decoded by serializers as "MAND".
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_35MaABRHEeOKWo1NF21OVw")]
    [Description(@"Account is fully managed by the financial institution, that is, an investor gives a 'mandate' to the financial institution to execute a mutually agreed investment strategy on its behalf.")]
    MandateAccount,
    
}
