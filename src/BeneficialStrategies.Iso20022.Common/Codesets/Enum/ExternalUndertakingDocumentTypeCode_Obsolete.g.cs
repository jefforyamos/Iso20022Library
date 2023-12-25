﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUndertakingDocumentTypeCode_Obsolete.  ISO2002 ID# _rJUs5nCcEe2v-4Te0Ownww.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rJUs5nCcEe2v-4Te0Ownww")]
[Description(@"Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately. External code sets can be downloaded from www.iso20022.org.")]
public enum ExternalUndertakingDocumentTypeCode_Obsolete
{
    /// <summary>
    /// Document is a beneficiary statement.
    /// </summary>
    [EnumMember(Value = "BENS")]
    [IsoId("_rJUs53CcEe2v-4Te0Ownww")]
    [Description(@"Document is a beneficiary statement.")]
    BENS,
    
    /// <summary>
    /// Document is an invoice.
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_rJUs6XCcEe2v-4Te0Ownww")]
    [Description(@"Document is an invoice.")]
    CINV,
    
    /// <summary>
    /// Document is a claim form.
    /// </summary>
    [EnumMember(Value = "CLAF")]
    [IsoId("_rJUs63CcEe2v-4Te0Ownww")]
    [Description(@"Document is a claim form.")]
    CLAF,
    
    /// <summary>
    /// Document is an undertaking demand.
    /// </summary>
    [EnumMember(Value = "DEMD")]
    [IsoId("_rJUs6HCcEe2v-4Te0Ownww")]
    [Description(@"Document is an undertaking demand.")]
    DEMD,
    
    /// <summary>
    /// Document is a transfer form.
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_rJUs6nCcEe2v-4Te0Ownww")]
    [Description(@"Document is a transfer form.")]
    TRAF,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUndertakingDocumentTypeCode_ObsoleteMetadataExtensions
{
    private static readonly ExternalUndertakingDocumentTypeCode_ObsoleteDropdownSource _dropdownSource = new ExternalUndertakingDocumentTypeCode_ObsoleteDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUndertakingDocumentTypeCode_ObsoleteDropdownRow GetMetadata(this ExternalUndertakingDocumentTypeCode_Obsolete code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


