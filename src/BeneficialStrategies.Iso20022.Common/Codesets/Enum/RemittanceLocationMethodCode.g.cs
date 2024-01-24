﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RemittanceLocationMethodCode.  ISO2002 ID# _ZshGodp-Ed-ak6NoX_4Aeg_-702329779.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the method used to deliver the remittance advice information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZshGodp-Ed-ak6NoX_4Aeg_-702329779")]
[Description(@"Specifies the method used to deliver the remittance advice information.")]
[Derivations(typeof(RemittanceLocationMethod1Code),typeof(RemittanceLocationMethod2Code))]
public enum RemittanceLocationMethodCode
{
    /// <summary>
    /// Remittance advice information must be faxed.
    /// Encoded/decoded by serializers as "FAXI".
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_ZshGotp-Ed-ak6NoX_4Aeg_-652459149")]
    [Description(@"Remittance advice information must be faxed.")]
    Fax,
    
    /// <summary>
    /// Remittance advice information must be sent through Electronic Data Interchange (EDI).
    /// Encoded/decoded by serializers as "EDIC".
    /// </summary>
    [EnumMember(Value = "EDIC")]
    [IsoId("_ZshGo9p-Ed-ak6NoX_4Aeg_-357854504")]
    [Description(@"Remittance advice information must be sent through Electronic Data Interchange (EDI).")]
    ElectronicDataInterchange,
    
    /// <summary>
    /// Remittance advice information needs to be sent to a Uniform Resource Identifier (URI). URI is a compact string of characters that uniquely identify an abstract or physical resource. URI's are the super-set of identifiers, such as URLs, email addresses, ftp sites, etc, and as such, provide the syntax for all of the identification schemes.
    /// Encoded/decoded by serializers as "URID".
    /// </summary>
    [EnumMember(Value = "URID")]
    [IsoId("_ZshGpNp-Ed-ak6NoX_4Aeg_-357854132")]
    [Description(@"Remittance advice information needs to be sent to a Uniform Resource Identifier (URI). URI is a compact string of characters that uniquely identify an abstract or physical resource. URI's are the super-set of identifiers, such as URLs, email addresses, ftp sites, etc, and as such, provide the syntax for all of the identification schemes.")]
    UniformResourceIdentifier,
    
    /// <summary>
    /// Remittance advice information must be sent through e-mail.
    /// Encoded/decoded by serializers as "EMAL".
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_ZshGpdp-Ed-ak6NoX_4Aeg_-356933514")]
    [Description(@"Remittance advice information must be sent through e-mail.")]
    EMail,
    
    /// <summary>
    /// Remittance advice information must be sent through postal services.
    /// Encoded/decoded by serializers as "POST".
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_ZshGptp-Ed-ak6NoX_4Aeg_-200858418")]
    [Description(@"Remittance advice information must be sent through postal services.")]
    Post,
    
    /// <summary>
    /// Remittance advice information must be sent through by phone as a short message service (SMS).
    /// Encoded/decoded by serializers as "SMSM".
    /// </summary>
    [EnumMember(Value = "SMSM")]
    [IsoId("_ZshGp9p-Ed-ak6NoX_4Aeg_-1754667285")]
    [Description(@"Remittance advice information must be sent through by phone as a short message service (SMS).")]
    SMS,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RemittanceLocationMethodCodeMetadataExtensions
{
    private static readonly RemittanceLocationMethodCodeDropdownSource _dropdownSource = new RemittanceLocationMethodCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRemittanceLocationMethodCodeDropdownRow GetMetadata(this RemittanceLocationMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


