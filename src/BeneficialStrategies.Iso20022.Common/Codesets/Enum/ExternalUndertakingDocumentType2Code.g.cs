﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ExternalUndertakingDocumentType2Code.  ISO2002 ID# _-MrKAm7iEeKo25nLKvGr8w_-463638576.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MrKAm7iEeKo25nLKvGr8w_-463638576")]
[Description(@"Specifies the external undertaking document type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUndertakingDocumentTypeCode_Obsolete))]
public enum ExternalUndertakingDocumentType2Code
{
    /// <summary>
    /// Document is a beneficiary statement.
    /// Encoded/decoded by serializers as "BENS".
    /// </summary>
    [EnumMember(Value = "BENS")]
    [IsoId("_uRhQ0vRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a beneficiary statement.")]
    BeneficiaryStatement = ExternalUndertakingDocumentTypeCode_Obsolete.BeneficiaryStatement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is an invoice.
    /// Encoded/decoded by serializers as "CINV".
    /// </summary>
    [EnumMember(Value = "CINV")]
    [IsoId("_uRhQ1fRYEeuLhpyIdtJzwg")]
    [Description(@"Document is an invoice.")]
    CommercialInvoice = ExternalUndertakingDocumentTypeCode_Obsolete.CommercialInvoice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Document is a transfer form.
    /// Encoded/decoded by serializers as "TRAF".
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_uRhQ2PRYEeuLhpyIdtJzwg")]
    [Description(@"Document is a transfer form.")]
    TransferForm = ExternalUndertakingDocumentTypeCode_Obsolete.TransferForm, // same ordinal as derivation source for type conversions
    
}
