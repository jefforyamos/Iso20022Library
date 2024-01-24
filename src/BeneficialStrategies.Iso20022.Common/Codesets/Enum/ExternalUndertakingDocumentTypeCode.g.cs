﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUndertakingDocumentTypeCode.  ISO2002 ID# _-MrKA27iEeKo25nLKvGr8w_-2015115819.
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
[IsoId("_-MrKA27iEeKo25nLKvGr8w_-2015115819")]
[Description(@"Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalUndertakingDocumentType1Code))]
public enum ExternalUndertakingDocumentTypeCode
{
    /// <summary>
    /// Document is a beneficiary statement.
    /// Encoded/decoded by serializers as "BENS".
    /// </summary>
    [EnumMember(Value = "BENS")]
    [IsoId("_uRYG4PRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a beneficiary statement.")]
    BeneficiaryStatement,
    
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as "CINV".
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_uRYG4_RYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice,
    
    /// <summary>
    /// Document is a claim form.
    /// Encoded/decoded by serializers as "CLAF".
    /// </summary>
    [EnumMember(Value = "CLAF")]
    [IsoId("_uRYG5vRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a claim form.")]
    ClaimForm,
    
    /// <summary>
    /// Document is an undertaking demand.
    /// Encoded/decoded by serializers as "DEMD".
    /// </summary>
    [EnumMember(Value = "DEMD")]
    [IsoId("_uRYG6fRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an undertaking demand.")]
    Demand,
    
    /// <summary>
    /// Document is a transfer form.
    /// Encoded/decoded by serializers as "TRAF".
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_uRYG7PRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a transfer form.")]
    TransferForm,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ExternalUndertakingDocumentTypeCodeMetadataExtensions
{
    private static readonly ExternalUndertakingDocumentTypeCodeDropdownSource _dropdownSource = new ExternalUndertakingDocumentTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IExternalUndertakingDocumentTypeCodeDropdownRow GetMetadata(this ExternalUndertakingDocumentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


