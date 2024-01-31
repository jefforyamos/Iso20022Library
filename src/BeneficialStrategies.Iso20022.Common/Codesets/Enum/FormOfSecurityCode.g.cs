﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for FormOfSecurityCode.  ISO2002 ID# _yTuAQNu8EeGvDJc6a1miEg_1096213532.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the form of the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yTuAQNu8EeGvDJc6a1miEg_1096213532")]
[Description(@"Specifies the form of the security.")]
[Derivations(typeof(FormOfSecurity1Code))]
public enum FormOfSecurityCode
{
    /// <summary>
    /// Shareholder name of the financial instrument appears in the corporation/funds books.
    /// Encoded/decoded by serializers as "REGD".
    /// </summary>
    [EnumMember(Value = "REGD")]
    [IsoId("_arP_w9p-Ed-ak6NoX_4Aeg_1876631848")]
    [Description(@"Shareholder name of the financial instrument appears in the corporation/funds books.")]
    Registered,
    
    /// <summary>
    /// The financial instrument does not specify any registration of ownership, and is payable to whomever possesses the certificate.
    /// Encoded/decoded by serializers as "BEAR".
    /// </summary>
    [EnumMember(Value = "BEAR")]
    [IsoId("_arP_wtp-Ed-ak6NoX_4Aeg_1839687617")]
    [Description(@"The financial instrument does not specify any registration of ownership, and is payable to whomever possesses the certificate.")]
    Bearer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class FormOfSecurityCodeMetadataExtensions
{
    private static readonly FormOfSecurityCodeDropdownSource _dropdownSource = new FormOfSecurityCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IFormOfSecurityCodeDropdownRow GetMetadata(this FormOfSecurityCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


